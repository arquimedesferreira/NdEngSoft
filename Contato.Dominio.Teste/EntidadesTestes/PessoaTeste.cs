using System;
using Contato.Dominio.Entidades;
using Contato.Dominio.Enum;
using Contato.Dominio.ValoresDeObjetos;
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

            var contato = new Entidades.Contato(EContatoTipo.CELULAR,"testando");
            var contato1 = new Entidades.Contato(EContatoTipo.CELULAR,"testando");

            _pessoa.Adiciona(contato);
            _pessoa.Adiciona(contato1);
            var tamanho_da_lista = _pessoa.Contatos;
            Console.Write("Teste"+ tamanho_da_lista.Count);

            Assert.IsTrue(tamanho_da_lista.Count != 0);
        }

    }
}
