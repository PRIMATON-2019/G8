using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindruner2
{
    public class preguntados
    {
        
        private string[,] PYR = new string[6, 5];

        
        #region Metodos

        public string Preguntas(string NumerodePregunta)
        {
            PYR[0, 0] = "quien descubrio america";             
            PYR[1, 0] = "quien es el chabo del 8"; 
            PYR[2, 0] = "quien cruzo los andes";
            PYR[3, 0] = "quien es el chabo del 8";
            PYR[4, 0] = "que sale de mezclar amarillo y azul";
            PYR[4, 4] = "2";
            PYR[5, 0] = "quien es super man";
            PYR[5, 4] = "1";
                       
            string pregunta = PYR[Convert.ToInt32(NumerodePregunta) - 1, 0];
                 
            return pregunta;

        }
        public string opc1(string NumerodePregunta)
        {
            PYR[0, 1] = " Napoleon";
            PYR[1, 1] = " kiko";
            PYR[2, 1] = " san martin";
            PYR[3, 1] = " kiko";
            PYR[4, 1] = " violeta";
            PYR[5, 1] = " clar ken";
            string opc1 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 1];
            return opc1;

        }
        public string opc2(string NumerodePregunta)
        {
            PYR[0, 2] = "Jesus";
            PYR[1, 2] = "el chapulin";
            PYR[2, 2] = "pepe argento";
            PYR[3, 2] = "el chapulin";
            PYR[4, 2] = "verde";
            PYR[5, 2] = "barby";


            string opc2 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 2];
            return opc2;
        }
        public string opc3(string NumerodePregunta)
        {
            PYR[0, 3] = "Colon";
            PYR[1, 3] = "chespirito";
            PYR[2, 3] = "tinelli";
            PYR[3, 3] = "chespirito";
            PYR[4, 3] = "negro";
            PYR[5, 3] = "chapo guzma";

            string opc3 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 3];
            return opc3;
        }
        public string resultado (string NumerodePregunta)
        {
            PYR[0, 4] = "3";
            PYR[1, 4] = "3";
            PYR[2, 4] = "1";
            PYR[3, 4] = "3";
            PYR[4, 4] = "2";
            PYR[5, 4] = "1";
            string resultado = PYR[Convert.ToInt32(NumerodePregunta) - 1, 4];
            return resultado;
        }
        #endregion


        //mm
    }

}
