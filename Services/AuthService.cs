using ReprmosRA.Security;
using RepromosRA.Models;
using RepromosRA.Repositories;
using RepromosRA.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepromosRA.Services
{
    public class AuthService
    {
        private readonly UsuarioRepository _repo;

        public AuthService(UsuarioRepository repo)
        {
            _repo = repo;
        }

        public Usuario Login(string username, string password)
        {
            var user = _repo.GetByUsername(username);
            if (user == null)
                throw new InvalidOperationException("User not found.");

            string hash = PasswordHasher.Hash(password);
            if (hash != user.PasswordHash)
                throw new InvalidOperationException("Invalid password.");

            // Inicia sesión
            Session.Start(user);
            return user;
        }

        public void Logout()
        {
            Session.End();
        }
    }
}
