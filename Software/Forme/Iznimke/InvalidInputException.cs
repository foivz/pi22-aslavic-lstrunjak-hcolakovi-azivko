using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forme.Iznimke
{
    public class InvalidInputException : ApplicationException
    {
        public string Poruka { get; set; }
        public InvalidInputException()
        {

        }
        public InvalidInputException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
