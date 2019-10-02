using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindruner2
{
    
   public class dado
    {

        public int numero;
        Random rnd = new Random();

        public void lanzar ()
        {
            numero = rnd.Next(1, 7);
        }
      
    }

}
