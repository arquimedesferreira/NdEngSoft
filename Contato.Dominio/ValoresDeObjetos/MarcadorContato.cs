using Flunt.Validations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using NdEngSoft.Shared.ValoresObjeto;
using System;

namespace Contato.Dominio.Entidades
{
    public class MarcadorContato: ValorObjeto
    {
        public MarcadorContato(string nome)
        {
            this.Nome = nome;
            AddNotifications(new Contract()
                    .Requires()
                    .HasMinLen(Nome, 3, "Macador.Contato", "O campo nome não pode ter menos que ,três caracteres"));
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
                new Exception("Nome do Tipo de Contato não pode ser vazio!");
            }
        }
        

        public override string ToString()
        {
            return Nome.ToString();
        }
    }
}
