using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindruner2
{
    class preguntados
    {
        public string[,] PYR = new string[6, 5];

        public string  PreguntasYRespuestas(string NumerodePregunta)
        {
            PYR[0, 0] = "quien descubrio america";
            PYR[0, 1] = " Napoleon";
            PYR[0, 2] = "Jesus";
            PYR[0, 3] = "Colon";
            PYR[0, 4] = "3";

            PYR[1, 0] = "quien es el chabo del 8";
            PYR[1, 1] = " kiko";
            PYR[1, 2] = "el chapulin";
            PYR[1, 3] = "chespirito";
            PYR[1, 4] = "3";

            PYR[2, 0] = "quien cruzo los andes";
            PYR[2, 1] = " san martin";
            PYR[2, 2] = "pepe argento";
            PYR[2, 3] = "tinelli";
            PYR[2, 4] = "1";

            PYR[3, 0] = "quien es el chabo del 8";
            PYR[3, 1] = " kiko";
            PYR[3, 2] = "el chapulin";
            PYR[3, 3] = "chespirito";
            PYR[3, 4] = "3";

            PYR[4, 0] = "que sale de mezclar amarillo y azul";
            PYR[4, 1] = " violeta";
            PYR[4, 2] = "verde";
            PYR[4, 3] = "negro";
            PYR[4, 4] = "2";

            PYR[5, 0] = "quien es super man";
            PYR[5, 1] = " clar ken";
            PYR[5, 2] = "barby";
            PYR[5, 3] = "chapo guzma";
            PYR[5, 4] = "1";

            string pregunta = "";
            pregunta = PYR[Convert.ToInt32(NumerodePregunta)-1,0];
            
            return pregunta;


        }








    }
}
