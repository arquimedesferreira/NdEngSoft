using Agenda.Domain.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Domani.Test.Entity
{
    [TestClass]
    class AddresTest
    {
        [TestMethod]
        public void TesteSeEnderecoPodeTerValorVazioNoNome()
        {
            var adress = new Address("asdasdasd");
            Assert.IsFalse(adress.Logradouro == null);
        }
    }
}
