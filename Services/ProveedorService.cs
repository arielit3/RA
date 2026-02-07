using RepromosRA.Models;
using RepromosRA.Repositories;
using System.Collections.Generic;

namespace RepromosRA.Services
{
    public class ProveedorService
    {
        private readonly ProveedorRepository _repo;

        public ProveedorService(ProveedorRepository repo)
        {
            _repo = repo;
        }

        public List<Proveedor> Listar() => _repo.GetAll();

        public void Crear(Proveedor p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre))
                throw new System.Exception("El nombre es obligatorio.");

            _repo.Add(p);
        }

        public void Editar(Proveedor p)
        {
            if (p.Id <= 0)
                throw new System.Exception("Proveedor inválido.");

            _repo.Update(p);
        }

        public void Eliminar(int id)
        {
            _repo.Desactivar(id);
        }
    }
}
