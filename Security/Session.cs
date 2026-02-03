using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RepromosRA.Models;

namespace RepromosRA.Security
{
    public static class Session
    {
        public static Usuario? CurrentUser { get; private set; }

        public static void Start(Usuario user) => CurrentUser = user;

        public static void End() => CurrentUser = null;
    }
}

