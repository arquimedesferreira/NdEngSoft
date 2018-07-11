using Agenda.Domain.Enum;
using Agenda.Domain.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Domani.Test.Entity
{
    [TestClass]
    class ContactTest
    {
        [TestMethod]
        public void TestaSeContatoPodeSerTipoNullo()
        {
            var contato = new Contact(EContactType.CELULAR, "12312312");
            Assert.IsTrue(contato.Type == 0);
        }

        [TestMethod]
        public void TesteSeContatoPodeTerValorVazio()
        {
            var contato = new Contact(EContactType.EMAIL, "");
            Assert.IsFalse(contato.Type == 3);
        }
    }
}
