using Flunt.Notifications;
using Flunt.Validations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using NdEngSoft.Shared.ValoresObjeto;
using System;

namespace Agenda.Dominio.Entidades
{
    public class MarcadorContato
    {
        public MarcadorContato(string nome)
        {
            this.Nome = nome;
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; private set; }
        public string Nome { get; private set; }

        public void AlterarNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                this.Nome = nome;
            }
            else
            {
                this.Nome = "Erro!Ser em Branco";
            }
        }
        

        public override string ToString()
        {
            return Nome.ToString();
        }
    }
}
