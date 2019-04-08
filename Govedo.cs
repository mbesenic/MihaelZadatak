using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MihaelZadatak
{
    class Govedo
    {
        public string Boja { get; set; }
        public string Spol { get; set; }
        public Govedo(string boja, string spol) {
            this.Boja = boja;
            this.Spol = spol;
        }
        
    }
}
