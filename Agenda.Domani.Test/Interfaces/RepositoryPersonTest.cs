using Agenda.Domain.Entity;
using Agenda.Domain.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NdEngSoft.InfraMongo.Contexto;
using NdEngSoft.InfraMongo.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Domani.Test.Interfaces
{
    [TestClass]
    class RepositoryPersonTest
    {
        [TestMethod]
        public async Task VerficicaSeTemUmaPessoaSalvaNoBanco()
        {
            var con = new MongoContexto();
            var rep = new RepositorioPessoas(con);

            var name = new Name("Carlos", "Fernades");
            var pessoa = new Person(name);
            var address = new Address("rua das almacias");
            pessoa.Add(address);

            await rep.Add(pessoa);

            await rep.Add(pessoa);
            var resp = await rep.SearchForName(name.FisrtName);
            Assert.IsNotNull(rep);

        }
    }
}
