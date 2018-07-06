using Flunt.Notifications;
using Flunt.Validations;
using System;

namespace Agenda.Dominio.ValoresDeObjetos
{
    public class Endereco 
    {
        public Endereco(string logradouro)
        {
            Logradouro = logradouro;
        }

        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Complemento { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }

        public void atualizarLogradouro(string texto)
        {
            if (!string.IsNullOrEmpty(texto))
                this.Logradouro = texto;
        }
        public void atualizarNumero(string texto)
        {
            if (!string.IsNullOrEmpty(texto))
                this.Numero = texto;
        }
        public void atualizarBairro(string texto)
        {
            if (!string.IsNullOrEmpty(texto))
                this.Bairro = texto;
        }
        public void atualizarCidade(string texto)
        {
            if (!string.IsNullOrEmpty(texto))
                this.Cidade = texto;
        }

        public void atualizarEstado(string texto)
        {
            if (!string.IsNullOrEmpty(texto))
                this.Estado = texto;
        }
    }
}
