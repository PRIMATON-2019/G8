using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindruner2
{
    class preguntasnaturaleza
    {
        private string[,] PYR = new string[6, 5];


        #region Metodos

        public string Preguntas(string NumerodePregunta)
        {
            PYR[0, 0] = "quien hizo rambo";
            PYR[1, 0] = "como es el apellido de susana";
            PYR[2, 0] = "quien conduce Show Mach";
            PYR[3, 0] = "quien es el actor principal de el sexto sentido";
            PYR[4, 0] = "cuanto personages tiene la serie FRIENDS";
            PYR[5, 0] = "Como se llama el hijo de HOMERO";


            string pregunta = PYR[Convert.ToInt32(NumerodePregunta) - 1, 0];

            return pregunta;

        }
        public string opc1(string NumerodePregunta)
        {
            PYR[0, 1] = " chuck Norris";
            PYR[1, 1] = " gonzalez";
            PYR[2, 1] = " Mirtha Legrand";
            PYR[3, 1] = " Bruce Willis";
            PYR[4, 1] = " 7";
            PYR[5, 1] = " lisa";
            string opc1 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 1];
            return opc1;

        }
        public string opc2(string NumerodePregunta)
        {
            PYR[0, 2] = "Bruce wils";
            PYR[1, 2] = "Gimenez";
            PYR[2, 2] = "Marcelo Tinelli";
            PYR[3, 2] = "el chapulin";
            PYR[4, 2] = "20";
            PYR[5, 2] = "bart";


            string opc2 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 2];
            return opc2;
        }
        public string opc3(string NumerodePregunta)
        {
            PYR[0, 3] = "Silvestre Stalone";
            PYR[1, 3] = "Perez";
            PYR[2, 3] = "Charly Garcia";
            PYR[3, 3] = "Maradona";
            PYR[4, 3] = "5";
            PYR[5, 3] = "maguie";

            string opc3 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 3];
            return opc3;
        }
        public string resultado(string NumerodePregunta)
        {
            PYR[0, 4] = "3";
            PYR[1, 4] = "2";
            PYR[2, 4] = "2";
            PYR[3, 4] = "1";
            PYR[4, 4] = "5";
            PYR[5, 4] = "2";
            string resultado = PYR[Convert.ToInt32(NumerodePregunta) - 1, 4];
            return resultado;
        }
        #endregion
    }
}

