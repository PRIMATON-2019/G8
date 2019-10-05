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
        public int materia;
        Random rnd = new Random();
        public string tema = "";
  

        public void lanzar()
        {
            materia = rnd.Next(1, 7);
            numero = rnd.Next(1, 7);
            switch (numero)
            {
                case 1:
                    tema = "Opc.1 Historia";
                    break;
                case 2:
                    tema = "Opc.2 Geografia";
                    break;
                case 3:
                    tema = "Opc.3 Deportes";
                    break;
                case 4:
                    tema = "Opc.4 Cine";
                    break;
                case 5:
                    tema = "Opc.5 Musica";
                    break;
                case 6:
                    tema = "Opc.6 Naturaleza";
                    break;


            }
        }

    }

}
