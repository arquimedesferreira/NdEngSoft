using System;
using Contato.Dominio.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Contato.Dominio.Teste.EntidadesTestes
{
    [TestClass]
    public class ContatoTeste
    {
       

        [TestMethod]
        public void TestaSeContatoPodeSerTipoNullo()
        {
            var contato = new Entidades.Contato(EContatoTipo.CELULAR, "12312312");
            Assert.IsTrue(contato.Valid);
        }

        [TestMethod]
        public void TesteSeContatoPodeTerValorVazio()
        {
           var contato = new Entidades.Contato(EContatoTipo.EMAIL, "");
           Assert.IsFalse(contato.Valid);
        }
    }
}
