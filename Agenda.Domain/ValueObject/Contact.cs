using Agenda.Domain.Entity;
using Agenda.Domain.Enum;

namespace Agenda.Domain.ValueObject
{
    public class  Contact
    {
        public Contact(EContactType type, string value)
        {
            Type = type;
            Value = value;
            Marker = new ContactMarker("Smartphone");
        }

        public EContactType Type { get; private set; }
        public string Value { get; private set; }
        public ContactMarker Marker { get; private set; }

        public void Update(string value)
        {
            if (!string.IsNullOrEmpty(value))
                this.Value = value;
        }
        public void Update(EContactType tipo)
        {
            if (tipo <= 0)
            {
                this.Type = tipo;
            }
        }
        public void Update(ContactMarker marcador)
        {
            if (marcador != null)
                this.Marker = marcador;
        }
    }
}
