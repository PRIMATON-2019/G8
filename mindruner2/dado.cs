using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindruner2
{
   public class dado
    {
        Random r;
        private int numero;

        public int lanzar ()
        {
            numero = r.Next(6) + 1;
            return numero;
        }

       
        

        }
}
