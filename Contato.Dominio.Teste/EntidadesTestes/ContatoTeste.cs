using System;
using Agenda.Dominio.Enum;
using Agenda.Dominio.Entidades;
using Agenda.Dominio.ValoresDeObjetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Contato.Dominio.Teste.EntidadesTestes
{
    [TestClass]
    public class ContatoTeste
    {
       

        [TestMethod]
        public void TestaSeContatoPodeSerTipoNullo()
        {
            var contato = new Contato(EContatoTipo.CELULAR, "12312312");
            Assert.IsTrue(contato.Valid);
        }

        [TestMethod]
        public void TesteSeContatoPodeTerValorVazio()
        {
           var contato = new Contato(EContatoTipo.EMAIL, "");
           Assert.IsFalse(contato.Valid);
        }
    }
}
