using System;
using Agenda.Dominio.Entidades;
using Agenda.Dominio.Enum;
using Agenda.Dominio.ValoresDeObjetos;
using Flunt.Notifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Contato.Dominio.Teste
{
    [TestClass]
    public class PessoaTeste: Notifiable
    {
        private Pessoa _pessoa;
        public void CriaUmaPessoa()
        {
            if (_pessoa == null)
            {
                var nome = new Nome("C", "F");
                _pessoa = new Pessoa(nome);
            }
        }

        [TestMethod]
        public void TestaCriarPessoa()
        {
            CriaUmaPessoa();
            Assert.IsTrue( _pessoa != null );
        }

        [TestMethod]
        public void TestaAdicionarUmContato()
        {
            CriaUmaPessoa();
            var endereco = new Endereco("rua das almacias");

            var contato = new Contato(EContatoTipo.CELULAR,"testando");
            var contato1 = new Contato(EContatoTipo.CELULAR,"testando");

            _pessoa.Adiciona(contato);
            _pessoa.Adiciona(contato1);
            var tamanho_da_lista = _pessoa.Contatos;
            Console.Write("Teste"+ tamanho_da_lista.Count);

            Assert.IsTrue(tamanho_da_lista.Count != 0);
        }


        [TestMethod]
        public void TestaAdicionarUmEndereco()
        {
            CriaUmaPessoa();
            var endereco = new Endereco("rua das almacias");
            var endereco1 = new Endereco("rua das almacias");
            
            _pessoa.Adiciona(endereco);
            _pessoa.Adiciona(endereco1);
            var tamanho_da_lista = _pessoa.Enderecos;
            Console.Write("Teste" + tamanho_da_lista.Count);

            Assert.IsTrue(tamanho_da_lista.Count != 0);
        }
    }
}
