using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindruner2
{
   public class dado
    {
        private int numero;

        public void lanzar (Random r)
        {
            numero = r.Next(6) + 1;

        }

        public int numeroobtenido()
        {
            return numero;

        }

        public void mostrar(System.Windows.Forms.PictureBox pb )

        {
            switch (numero)
            {
                case 1:

                    pb.Image = mindruner2.Properties.Resources.lado1;
                    break;

                case 2:

                    pb.Image = mindruner2.Properties.Resources.lado2;
                    break;

                case 3:

                    pb.Image = mindruner2.Properties.Resources.lado3;
                    break;

                case 4:

                    pb.Image = mindruner2.Properties.Resources.lado4;
                    break;

                case 5:

                    pb.Image = mindruner2.Properties.Resources.lado5;
                    break;

                case 6:

                    pb.Image = mindruner2.Properties.Resources.lado6;
                    break;
            }

        }
    }
}
