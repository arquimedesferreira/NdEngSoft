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
            var contact = new Contact(EContactType.CELULAR, "12312312");
            Assert.IsTrue(contact.Type == 0);
        }

        [TestMethod]
        public void TesteSeContatoPodeTerValorVazio()
        {
            var contact = new Contact(EContactType.EMAIL, "");
            var cValue = contact.Type;
            Assert.IsFalse(cValue == 0);
        }
    }
}
