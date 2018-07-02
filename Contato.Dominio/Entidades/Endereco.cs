using Flunt.Notifications;
using Flunt.Validations;
using NdEngSoft.Shared.ValoresObjeto;
using System;

namespace Contato.Dominio.Entidades
{
    public class Endereco : Notifiable
    {
        public Endereco(string logradouro)
        {
            Logradouro = logradouro;
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Logradouro, 3, "Endereco.Logradouro", "Valor não pode ser inferior a 3 caracteres"));
        }

        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Complemento { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }

        public void atualizarLogradouro(string texto)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(texto, "Endereco.Logradouro", "Valor não pode ser nulo ou vazio")
                .HasMinLen(texto, 3, "Endereco.Logradouro", "Valor não pode ser inferior a 3 caracteres"));
            if (this.Valid)
                this.Logradouro = texto;
        }
        public void atualizarNumero(string texto)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(texto, "Endereco.Numero", "Valor não pode ser nulo ou vazio")
                .HasMinLen(texto, 3, "Endereco.Numero", "Valor não pode ser inferior a 3 caracteres"));
            if (this.Valid)
                this.Numero = texto;
        }
        public void atualizarBairro(string texto)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(texto, "Endereco.Bairro", "Valor não pode ser nulo ou vazio")
                .HasMinLen(texto, 3, "Endereco.Bairro", "Valor não pode ser inferior a 3 caracteres"));
            if (this.Valid)
                this.Bairro = texto;
        }
        public void atualizarCidade(string texto)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(texto, "Endereco.Cidade", "Valor não pode ser nulo ou vazio")
                .HasMinLen(texto, 3, "Endereco.Cidade", "Valor não pode ser inferior a 3 caracteres"));
            if (this.Valid)
                this.Cidade = texto;
        }

        public void atualizarEstado(string texto)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(texto, "Endereco.Estado", "Valor não pode ser nulo ou vazio")
                .HasMinLen(texto, 3, "Endereco.Estado", "Valor não pode ser inferior a 3 caracteres"));
            if (this.Valid)
                this.Estado = texto;
        }
    }
}
