using Contato.Dominio.Enum;
using Contato.Dominio.ValoresDeObjetos;
using Flunt.Notifications;
using Flunt.Validations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using NdEngSoft.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contato.Dominio.Entidades
{
    public class Pessoa: Notifiable
    {
        private IList<Contato> _contados;
        private IList<Endereco> _enderecos;
        public Pessoa(Nome nome )
        {
            this.Nome = nome;
            _contados = new List<Contato>();
            _enderecos = new List<Endereco>();
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; private set; }

        public Nome Nome { get; private set; }
        public IReadOnlyCollection<Endereco> Enderecos {
            get
            {
                //var novosEnderecos = new List<Endereco>();
                //try
                //{
                //    foreach (var item in _enderecos)
                //    {
                //        novosEnderecos.Add(item);
                //    }
                //}
                //catch (Exception e)
                //{
                //    throw new Exception("Erro  ao copiar a lista antiga de endereços!");
                //}

                return _enderecos.ToArray();
            }
        }

        public IReadOnlyCollection<Contato> Contatos{
            get {
                //var novaLista = new List<Contato>();
                //try
                //{
                //    foreach (var item in _contados)
                //    {
                //        novaLista.Add(item);
                //    }
                //}
                //catch (Exception e)
                //{
                //    throw new Exception("Erro  ao copiar os contatos!");
                //}
                return _contados.ToArray();
             }
        }

        public void TrocarNome (Nome nome)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNull(nome, "Pessoa.TrocarNome(nome)", "Valor não pode ser nulo!"));
            if (this.Valid)
                this.Nome = nome;
        }


        public void Adiciona(Endereco endereco)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNull(endereco, "Pessoa.Adiciona(endereco)", "Valor não pode ser nulo!"));
            if (this.Valid)
                _enderecos.Add(endereco);
        }

        public void Adiciona(Contato contato)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNull(contato, "Pessoa.Adiciona(contato)", "Valor não pode ser nulo!"));
            if (this.Valid)
                _contados.Add(contato);
        }
    }
}
