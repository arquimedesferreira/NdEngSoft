using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Domain.ValueObject
{
    public class Address
    {
        public Address(string logradouro)
        {
            Logradouro = logradouro;
            if (!string.IsNullOrEmpty(logradouro))
                this.Logradouro = logradouro;
        }

        public string Logradouro { get; private set; }
        public string Number { get; private set; }
        public string District { get; private set; }
        public string Complement { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }

        public void updateLogradouro(string value)
        {
            if (!string.IsNullOrEmpty(value))
                this.Logradouro = value;
        }
        public void updateNumber(string value)
        {
            if (!string.IsNullOrEmpty(value))
                this.Number = value;
        }
        public void updateDistrict(string value)
        {
            if (!string.IsNullOrEmpty(value))
                this.District = value;
        }
        public void updateComplement(string value)
        {
            if (!string.IsNullOrEmpty(value))
                this.Complement = value;
        }

        public void updateCity(string value)
        {
            if (!string.IsNullOrEmpty(value))
                this.City = value;
        }

        public void updateState(string texto)
        {
            if (!string.IsNullOrEmpty(texto))
                this.State = texto;
        }

    }
}
