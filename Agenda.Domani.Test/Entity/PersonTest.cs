using Agenda.Domain.Entity;
using Agenda.Domain.Enum;
using Agenda.Domain.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Domani.Test.Entity
{
    [TestClass]
    class PersonTest
    {
        private Person _person;
        public void NewPerson()
        {
            if (_person == null)
            {
                var name = new Name("C", "F");
                _person = new Person(name);
            }
        }

        [TestMethod]
        public void TestaCriarPessoa()
        {
            NewPerson();
            Assert.IsTrue(_person != null);
        }

        [TestMethod]
        public void TestaAdicionarUmContato()
        {
            NewPerson();
            var adress = new Address("rua das almacias");

            var contact = new Contact(EContactType.CELULAR, "testando");
            var contact1 = new Contact(EContactType.CELULAR, "testando");

            _person.Add(contact);
            _person.Add(contact1);
            var size_list = _person.Contacts;

            Assert.IsTrue(size_list.Count != 0);
        }


        [TestMethod]
        public void TestaAdicionarUmEndereco()
        {
            NewPerson();
            var endereco = new Address("rua das almacias");
            var endereco1 = new Address("rua das almacias");

            _person.Add(endereco);
            _person.Add(endereco1);
            var tamanho_da_lista = _person.Adresses;
            Console.Write("Teste" + tamanho_da_lista.Count);

            Assert.IsTrue(tamanho_da_lista.Count != 0);
        }
    }
}
