using Agenda.Dominio.Entidades;
using Agenda.Dominio.Interfaces.Repositorios;
using MongoDB.Bson;
using MongoDB.Driver;
using NdEngSoft.InfraMongo.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdEngSoft.InfraMongo.Repositorios
{
    public class RepositorioPessoas : IRepositorioDePessoas
    {
        private MongoContexto _contextoBanco;


        public RepositorioPessoas(MongoContexto contexto)
        {
            _contextoBanco = contexto;
        }


        public async Task Adicionar(Pessoa pessoa)
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
        public async Task<Pessoa> Buscar(string primeirNome)
        {
            try
            {
                var construtor = Builders<Pessoa>.Filter;
                var filtro = construtor.Eq(x => x.Nome.PrimeiroNome, primeirNome);
                return await _contextoBanco.Pessoas.Find(filtro).FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                var ee = e;
                return null;
            }
        }
        public async Task<IList<Pessoa>> BuscarTodas()
        {
            try
            {
                return await _contextoBanco.Pessoas.Find(new BsonDocument()).ToListAsync();
            }
            catch (Exception e)
            {
                var ee = e;
                return null;
            }
        }
        public async Task Remover(Pessoa pessoa)
        {
            try
            {
                var construtor = Builders<Pessoa>.Filter;
                var filtro = construtor.Eq(x => x.Id, pessoa.Id);
                await _contextoBanco.Pessoas.DeleteOneAsync(filtro);
            }
            catch (Exception e)
            {
                var ee = e;
            }
        }

        public async void Atualizar(Pessoa pessoa)
        {
            try
            {
                var construtor = Builders<Pessoa>.Filter;
                var filtro = construtor.Eq(x => x.Id, pessoa.Id);
                await _contextoBanco.Pessoas.ReplaceOneAsync(filtro, pessoa);
            }
            catch (Exception e)
            {
                var ee = e;
            }
        }

        
    }
}
