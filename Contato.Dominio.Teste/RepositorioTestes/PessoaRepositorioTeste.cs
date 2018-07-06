using System;
using Agenda.Dominio.Entidades;
using Agenda.Dominio.ValoresDeObjetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NdEngSoft.InfraMongo.Contexto;
using NdEngSoft.InfraMongo.Repositorios;

namespace Contato.Dominio.Teste
{
    [TestClass]
    public class RepositorioContatoTeste
    {
        [TestMethod]
        public async void VerficicaSeTemUmaPessoaSalvaNoBanco()
        {
            var con = new MongoContexto();
            var rep = new RepositorioPessoas(con);

            var nome = new Nome("Carlos", "Fernades");
            var pessoa = new Pessoa(nome);
            var endereco = new Endereco("rua das almacias");
            pessoa.Adiciona(endereco);

            rep.Adicionar(pessoa);

            rep.Adicionar(pessoa);
            var resp =  rep.Buscar(nome.PrimeiroNome);
            Assert.IsNotNull(rep);

        }
    }
}
