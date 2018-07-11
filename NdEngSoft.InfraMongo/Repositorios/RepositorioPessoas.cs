using Agenda.Domain.Entity;
using Agenda.Domain.Interface.Repository;
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
    public class RepositorioPessoas : IRepositoryPerson
    {
        private MongoContexto _contextoBanco;


        public RepositorioPessoas(MongoContexto contexto)
        {
            _contextoBanco = contexto;
        }


        public async Task Add(Person pessoa)
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
        public async Task<IList<Person>> SearchAll()
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

        public async Task<Person> SearchForName(string primeirNome)
        {
            try
            {
                var construtor = Builders<Person>.Filter;
                var filtro = construtor.Eq(x => x.Name.FisrtName, primeirNome);
                return await _contextoBanco.Pessoas.Find(filtro).FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                var ee = e;
                return null;
            }
        }
        public async Task<Person> SearchForId(string id)
        {
            try
            {
                var construtor = Builders<Person>.Filter;
                var filtro = construtor.Eq(x => x.Id, id);
                return await _contextoBanco.Pessoas.Find(filtro).FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                var ee = e;
                return null;
            }
        }

        public async Task Remove(Person pessoa)
        {
            try
            {
                var construtor = Builders<Person>.Filter;
                var filtro = construtor.Eq(x => x.Id, pessoa.Id);
                await _contextoBanco.Pessoas.DeleteOneAsync(filtro);
            }
            catch (Exception e)
            {
                var ee = e;
            }
        }

        public async void Update(Person pessoa)
        {
            try
            {
                var construtor = Builders<Person>.Filter;
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
