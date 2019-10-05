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
            numero = rnd.Next(1, 7);
            materia = rnd.Next(1, 7);
            switch (materia)
            {
                case 1:
                    tema = "Historia";
                    break;
                case 2:
                    tema = "Geografia";
                    break;
                case 3:
                    tema = "Deportes";
                    break;
                case 4:
                    tema = "Cine";
                    break;
                case 5:
                    tema = "Musica";
                    break;
                case 6:
                    tema = "Naturaleza";
                    break;


            }
        }

    }

}
