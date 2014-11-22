using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionalidadesRavenDB
{
    class Usuario
    {
        public int id { get;set;}
        public String nome { get; set; }
        public char sexo { get; set;}
        public int idade { get; set; }
        public DateTime dataNascimento { get; set; }
        public long telefone { get; set; }
    }
}
