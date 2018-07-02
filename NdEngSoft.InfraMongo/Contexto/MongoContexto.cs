using Contato.Dominio.Entidades;
using Contato.Dominio.Interfaces.Repositorios;
using MongoDB.Driver;

namespace NdEngSoft.InfraMongo.Contexto
{
    public class MongoContexto:IContextoBanco
    {
        public const string STRING_DE_CONEXAO = "mongodb://localhost:27017";
        public const string NOME_DA_BASE = "testeAgenda";
        public const string COLECAO_MOTIVOS = "Contatos";
        public const string COLECAO_ACESSOS = "Acessos";

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

        public IMongoCollection<Pessoa> Pessoas
        {
            get { return _BaseDeDados.GetCollection<Pessoa>(COLECAO_MOTIVOS); }
        }

        //public IMongoCollection<AcessosRecepcao> Acessos
        //{
        //    get { return _BaseDeDados.GetCollection<AcessosRecepcao>(COLECAO_ACESSOS); }
        //}
    }
}
