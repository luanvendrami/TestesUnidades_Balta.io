using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Cliente : Entity
    {
        
        public string Name { get; private set; }
        public string Email { get; private set; }
        public Cliente(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
