using Agenda.Dominio.ValoresDeObjetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Contato.Dominio.Teste.EntidadesTestes
{
    [TestClass]
    public class EnderecoTeste
    {
        [TestMethod]
        public void TesteSeEnderecoPodeTerValorVazioNoNome()
        {
            var endereco = new Endereco("");
            Assert.IsFalse(endereco.Valid);
        }

    }
}
