using Agenda.Dominio.Entidades;
using Agenda.Dominio.Enum;
using Flunt.Notifications;
using Flunt.Validations;
using System;

namespace Agenda.Dominio.ValoresDeObjetos
{
    public class Contato
    {
        public Contato(EContatoTipo tipo, string valor)
        {
            Tipo = tipo;
            Valor = valor;
            Marcador = new MarcadorContato("Celurar");
        }

        public EContatoTipo Tipo { get; private set; }
        public string Valor { get; private set; }
        public MarcadorContato Marcador { get; private set; }

        public void Alterar(string valor)
        {
            if (!string.IsNullOrEmpty(valor))
                this.Valor = valor;
        }
        public void Alterar(EContatoTipo tipo)
        {
            if (tipo<=0)
            {
                this.Tipo = tipo;
            }
        }

        public void Alterar(MarcadorContato marcador)
        {
            if (marcador != null)
                this.Marcador = marcador;
        }
    }
}
