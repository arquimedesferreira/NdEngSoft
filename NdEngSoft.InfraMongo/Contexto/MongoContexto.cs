﻿using Agenda.Domain.Entity;
using MongoDB.Driver;

namespace NdEngSoft.InfraMongo.Contexto
{
    public class MongoContexto
    {
        public const string STRING_DE_CONEXAO = "mongodb://localhost:27017";
        public const string NOME_DA_BASE = "agendaTeste";
        public const string COLECAO_MOTIVOS = "Agenda";
        public const string COLECAO_ACESSOS = "MarcadoresContato";

        private static readonly IMongoClient _cliente;
        private static readonly IMongoDatabase _BaseDeDados;

        static MongoContexto()
        {
            if (_cliente == null)
            {
                _cliente = new MongoClient(STRING_DE_CONEXAO);
                _BaseDeDados = _cliente.GetDatabase(NOME_DA_BASE);
            }
        }

        public IMongoClient Cliente
        {
            get { return _cliente; }
        }

        public IMongoCollection<Person> Pessoas
        {
            get { return _BaseDeDados.GetCollection<Person>(COLECAO_MOTIVOS); }
        }

        public IMongoCollection<ContactMarker> MarcadoresContato
        {
            get { return _BaseDeDados.GetCollection<ContactMarker>(COLECAO_ACESSOS); }
        }
    }
}
