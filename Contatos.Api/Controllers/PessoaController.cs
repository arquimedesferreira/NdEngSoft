using Agenda.Dominio.Entidades;
using Agenda.Dominio.Enum;
using Agenda.Dominio.Interfaces.Repositorios;
using Agenda.Dominio.ValoresDeObjetos;
using Contatos.Api.Models.Pessoa;
using NdEngSoft.InfraMongo.Contexto;
using NdEngSoft.InfraMongo.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;


namespace Contatos.Api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PessoaController : ApiController
    {
        private IRepositorioDePessoas _repositorio;

        public PessoaController()
        {
            var context = new MongoContexto();
            _repositorio = new RepositorioPessoas(context);

        }

        [HttpGet]
        [Route("api/v0/pessoa")]
        public async Task<HttpResponseMessage> Pessoa()
        {
            try
            {
                var resul = await _repositorio.BuscarTodas();
                return Request.CreateResponse(HttpStatusCode.OK, resul, "application/json");
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Ops! Algo aconteceu de errado !", "application/json");
            }
        }

        [HttpPost]
        [Route("api/v0/pessoa/deletar/{id}")]
        public async Task<HttpResponseMessage> DeletarPessoaCom(string id)
        {
            try
            {
                var pessoa = await _repositorio.BuscarPorId(id);
                if(pessoa==null)
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                var resul = _repositorio.Remover(pessoa);
                return Request.CreateResponse(HttpStatusCode.OK, "application/json");
                
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.NotModified,"application/json");
            }
        }

        [HttpPost]
        [Route("api/v0/pessoa/atualizar")]
        public async Task<HttpResponseMessage> AtualizarPessoaCom(PessoaModel  pessoa)
        {

            var p = await _repositorio.BuscarPorId(pessoa.Id);
            if (p == null)
                return Request.CreateResponse(HttpStatusCode.NotFound);
            //return Request.CreateResponse(HttpStatusCode.OK, listaOrdenada, "application/json");
            return Request.CreateResponse(HttpStatusCode.OK, $"Pessoas de nome{p.Nome.PrimeiroNome} atualizada!", "application/json");
        }

        private void CarregarListadeTesteDePessoas()
        {
            var n = new Nome("Carlos", "Anderson");
            var p = new Pessoa(n);
            var e = new Endereco("rua das pedras");
            var c = new Contato(EContatoTipo.EMAIL,"teste@teste.com");
            var cc = new Contato(EContatoTipo.EMAIL, "teste@teste.com");
            p.Adiciona(e);
            p.Adiciona(c);
            p.Adiciona(cc);



            var n1 = new Nome("Carlos2", "Anderson2");
            var p1 = new Pessoa(n);
            var e1 = new Endereco("rua das pedras2");
            var c1 = new Contato(EContatoTipo.EMAIL, "teste@teste.com");
            var cc1 = new Contato(EContatoTipo.EMAIL, "teste@teste.com");
            p1.Adiciona(e);
            p1.Adiciona(c1);
            p1.Adiciona(cc1);
            try
            {
                _repositorio.Adicionar(p);
                _repositorio.Adicionar(p1);
            }
            catch (Exception er)
            {

                var ee = er;
            }
        }
    }
}
