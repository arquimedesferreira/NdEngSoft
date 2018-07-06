using Flunt.Validations;
using NdEngSoft.Shared.ValoresObjeto;

namespace Agenda.Dominio.ValoresDeObjetos
{
    public class Nome
    {
        public Nome(string primeiroNome, string segundoNome)
        {
            PrimeiroNome = primeiroNome;
            SegundoNome = segundoNome;
        }

        public string PrimeiroNome { get; private set; }
        public string SegundoNome { get;private set; }


        public override string ToString()
        {
            return $"{PrimeiroNome} {SegundoNome}";
        }
    }
}
