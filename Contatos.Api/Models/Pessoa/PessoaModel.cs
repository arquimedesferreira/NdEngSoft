using Agenda.Dominio.ValoresDeObjetos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Contatos.Api.Models.Pessoa
{
    public class PessoaModel
    {
        [Required]
        [DataType(DataType.Text)]
        //[Display(Name = "Email")]
        public string Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        //[Display(Name = "Senha")]
        public Nome Nome { get; set; }

        public ICollection<Endereco> Enderecos { get;  set; }
        public ICollection<Contato> Contatos { get;  set; }
    }
}