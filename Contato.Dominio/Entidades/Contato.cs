using Contato.Dominio.Enum;
using Flunt.Notifications;
using Flunt.Validations;
using NdEngSoft.Shared.ValoresObjeto;
using System;

namespace Contato.Dominio.Entidades
{
    public class Contato: Notifiable
    {
        public Contato(EContatoTipo tipo, string valor)
        {
            Tipo = tipo;
            Valor = valor;
            Marcador = new MarcadorContato("Familia");
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(valor,"Contato.Valor", "Valor não pode ser nulo!"));
        }

        public EContatoTipo Tipo { get; set; }
        public string Valor { get; private set; }
        public MarcadorContato Marcador { get; private set; }


        public void Alterar(string valor)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(valor, "Contato.Altera(valor)", "Não é possível subtituir o valor atual por null"));
            if (this.Valid)
                this.Valor = valor;
        }
        public void Alterar(EContatoTipo tipo)
        {
            if (tipo!=0)
            {
                this.Tipo = tipo;
            }
            else
            {
                AddNotification("Contato.Altera(contatoTipo)","não foi possível realizar a auteração !");
            }
        }

        public void Alterar(MarcadorContato marcador)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNull(marcador, "Contato.Altera(marcadorContato)", "Não é possível subtituir o valor atual por null"));
            if (this.Valid)
                this.Marcador = marcador;
        }
    }
}
