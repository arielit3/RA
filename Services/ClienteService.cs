using RepromosRA.Models;
using RepromosRA.Repositories;
using System.Collections.Generic;

namespace RepromosRA.Services
{
    public class ClienteService
    {
        private readonly ClienteRepository _repo;

        public ClienteService(ClienteRepository repo)
        {
            _repo = repo;
        }

        public List<Cliente> Listar() => _repo.GetAll();

        public void Crear(Cliente c)
        {
            if (string.IsNullOrWhiteSpace(c.Nombre))
                throw new System.Exception("El nombre es obligatorio.");

            _repo.Add(c);
        }

        public void Editar(Cliente c)
        {
            if (c.Id <= 0)
                throw new System.Exception("Cliente inválido.");

            _repo.Update(c);
        }

        public void Eliminar(int id)
        {
            _repo.Desactivar(id);
        }
    }
}
