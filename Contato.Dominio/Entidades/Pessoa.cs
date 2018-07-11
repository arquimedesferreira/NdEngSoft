using Agenda.Dominio.ValoresDeObjetos;
using Flunt.Notifications;
using Flunt.Validations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.Linq;
namespace Agenda.Dominio.Entidades
{
    public class Pessoa
    {
        public Pessoa(Nome nome )
        {
            this.Nome = nome;
            
            this.Enderecos = new List<Endereco>();
            this.Contatos = new List<Contato>();
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; private set; }
        public Nome Nome { get; private set; }
        public ICollection<Endereco> Enderecos { get; private set; }
        public ICollection<Contato> Contatos{ get; private set; }

        public void TrocarNome (Nome nome)
        {
            if (nome!= null)
                this.Nome = nome;
        }

        public void Adiciona(Endereco endereco)
        {
            if (endereco != null)
                Enderecos.Add(endereco);
        }

        public void Adiciona(Contato contato)
        {
            if (contato != null)
                Contatos.Add(contato);
        }
    }
}
