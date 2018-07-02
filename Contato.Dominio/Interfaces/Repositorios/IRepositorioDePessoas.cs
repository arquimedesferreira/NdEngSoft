using Contato.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contato.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioDePessoas
    {
        void Atualizar(Pessoa pessoa);
        Pessoa Buscar(string nome);
        Task<IList<Pessoa>> BuscarTodas();
        void Adicionar(Pessoa pessoa);
    }
}
