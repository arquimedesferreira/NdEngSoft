using Agenda.Api.Models.Person;
using Agenda.Domain.Entity;
using Agenda.Domain.Enum;
using Agenda.Domain.Interface.Repository;
using Agenda.Domain.ValueObject;
using NdEngSoft.InfraMongo.Contexto;
using NdEngSoft.InfraMongo.Repositorios;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Agenda.Api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PersonController: ApiController
    {
        private IRepositoryPerson _repository;

        public PersonController()
        {
            var context = new MongoContexto();
            _repository = new RepositorioPessoas(context);

        }

        [HttpGet]
        [Route("api/v0/pessoa")]
        public async Task<HttpResponseMessage> Persons()
        {
            try
            {
                var resul = await _repository.SearchAll();
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
                var person = await _repository.SearchForId(id);
                if (person == null)
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                var resul = _repository.Remove(person);
                return Request.CreateResponse(HttpStatusCode.OK, "application/json");

            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.NotModified, "application/json");
            }
        }

        [HttpPost]
        [Route("api/v0/pessoa/atualizar")]
        public async Task<HttpResponseMessage> AtualizarPessoaCom(PersonModel person)
        {

            var p = await _repository.SearchForId(person.Id);
            if (p == null)
                return Request.CreateResponse(HttpStatusCode.NotFound);
            //return Request.CreateResponse(HttpStatusCode.OK, listaOrdenada, "application/json");
            return Request.CreateResponse(HttpStatusCode.OK, $"Pessoas de nome{p.Name.FisrtName} atualizada!", "application/json");
        }

        private void CarregarListadeTesteDePessoas()
        {
            var n = new Name("Carlos", "Anderson");
            var p = new Person(n);
            var e = new Address("rua das pedras");
            var c = new Contact(EContactType.EMAIL, "teste@teste.com");
            var cc = new Contact(EContactType.EMAIL, "teste@teste.com");
            p.Add(e);
            p.Add(c);
            p.Add(cc);



            var n1 = new Name("Carlos2", "Anderson2");
            var p1 = new Person(n);
            var e1 = new Address("rua das pedras2");
            var c1 = new Contact(EContactType.EMAIL, "teste@teste.com");
            var cc1 = new Contact(EContactType.EMAIL, "teste@teste.com");
            p1.Add(e);
            p1.Add(c1);
            p1.Add(cc1);
            try
            {
                _repository.Add(p);
                _repository.Add(p1);
            }
            catch (Exception er)
            {

                var ee = er;
            }
        }
    }
}