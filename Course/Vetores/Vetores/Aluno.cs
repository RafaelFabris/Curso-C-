using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    class Aluno
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int NumQuarto { get; set; }

        public Aluno(string name, string email , int numQuarto)
        {
            Name = name;
            Email = email;
            NumQuarto = numQuarto;
        }

        public override string ToString()
        {
            return NumQuarto
                + ":"
                + Name
                + ", "
                + Email;
                
        }

    }
}
