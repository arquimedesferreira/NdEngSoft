using Contato.Dominio.Entidades;
using Contato.Dominio.Interfaces.Repositorios;
using NdEngSoft.InfraMongo.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdEngSoft.InfraMongo.Repositorios
{
    public class PessoasRepositorio : IRepositorioDePessoas
    {
        private IList<Pessoa> _pessoas;
        private MongoContexto _contextoBanco;


        public PessoasRepositorio(IContextoBanco contexto)
        {
            this._contextoBanco = contexto;
        }
        


        public async void Adicionar(Pessoa pessoa)
        {
            try
            {
                await _contextoBanco.Pessoas.InsertOneAsync(pessoa);
            }
            catch (Exception e)
            {
                var ee = e;
            }
        }
        public async Task<Pessoa> Buscar(string nome)
        {
            try
            {
                await _contextoBanco.Pessoas.FindAsync(nome);
                return null;
            }
            catch (Exception e)
            {
                var ee = e;
                return null;
            }
        }
        public async Task<IList<Pessoa>> BuscarTodas()
        {
            //AtualizarListaDePessoas();
            //return _pessoas;
            return null;
        }

        public async void Atualizar(Pessoa pessoa)
        {
            try
            {
                await _contextoBanco.Pessoas.InsertOneAsync(pessoa);
            }
            catch (Exception e)
            {
                var ee = e;
            }
        }
        private void AtualizarListaDePessoas()
        {
            throw new NotImplementedException();
        }
    }
}
