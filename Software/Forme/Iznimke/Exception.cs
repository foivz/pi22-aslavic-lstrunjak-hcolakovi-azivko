using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forme.Iznimke
{
    public class Exception : ApplicationException
    {
        public string Poruka { get; set; }

        public Exception(string poruka)
        {
            Poruka = poruka;
        }
    }
}
