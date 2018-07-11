using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Domain.ValueObject
{
    public class Name
    {
        public Name( string fisrtName, string nextName)
        {
            this.FisrtName = fisrtName;
            this.NextName = nextName;
        }

        public string FisrtName { get; private set; }
        public string NextName { get; private set; }

        public override string ToString()
        {
            return $"{FisrtName} {NextName}";
        }
    }
}
