using Flunt.Validations;
using NdEngSoft.Shared.ValoresObjeto;

namespace Contato.Dominio.ValoresDeObjetos
{
    public class Nome: ValorObjeto
    {
        public Nome(string primeiroNome, string segundoNome)
        {
            PrimeiroNome = primeiroNome;
            SegundoNome = segundoNome;

            AddNotifications(new Contract()
                    .Requires()
                    .HasMinLen(PrimeiroNome, 3,"Nome.PrimeiroNome","O campo nome não pode ser nulo!")
                    .HasMinLen(SegundoNome, 3,"Nome.PrimeiroNome","O campo nome não pode ser nulo!"));
        }

        public string PrimeiroNome { get; private set; }
        public string SegundoNome { get;private set; }


        public override string ToString()
        {
            return $"{PrimeiroNome} {SegundoNome}";
        }
    }
}
