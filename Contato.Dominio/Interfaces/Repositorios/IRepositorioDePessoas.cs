using Agenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioDePessoas
    {
        void Atualizar(Pessoa pessoa);
        Task<Pessoa> BuscarPorNome(string primeirNome);
        Task<Pessoa> BuscarPorId(string id);
        Task<IList<Pessoa>> BuscarTodas();
        Task Remover(Pessoa pessoa);
        Task Adicionar(Pessoa pessoa);
    }
}
