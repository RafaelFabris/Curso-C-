using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeracaoComposicao.Entities
{
    class Department
    {
        public String Name { get; set; }

        public Department()
        {
        }

        public Department(string name)
        {
            Name = name;
        }

    }
}
