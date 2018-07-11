using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Agenda.Domain.Entity
{
    public class ContactMarker
    {
        public ContactMarker(string name)
        {
            this.Name = name;
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; private set; }
        public string Name { get; private set; }

        public void AlterarNome(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                this.Name = name;
            }
            else
            {
                this.Name = "Erro!";
            }
        }


        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
