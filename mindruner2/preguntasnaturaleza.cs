using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindruner2
{
    class preguntasnaturaleza
    {
        private string[,] PYR = new string[20, 5];


        #region Metodos

        public string Preguntas(string NumerodePregunta)
        {
            PYR[0, 0] = "quien hizo rambo";
            PYR[1, 0] = "como es el apellido de susana";
            PYR[2, 0] = "quien conduce Show Mach";
            PYR[3, 0] = "quien es el actor principal de el sexto sentido";
            PYR[4, 0] = "cuanto personages tiene la serie FRIENDS";
            PYR[5, 0] = "Como se llama el hijo de HOMERO";
            PYR[6, 0] = "¿?";
            PYR[7, 0] = "¿?";
            PYR[8, 0] = "¿?";
            PYR[9, 0] = "¿?";
            PYR[10, 0] = "¿ ";
            PYR[11, 0] = "¿Cual?";
            PYR[12, 0] = "¿Qu?";
            PYR[13, 0] = "¿Que ae?";
            PYR[14, 0] = "¿Ques?";
            PYR[15, 0] = "¿Que ?";
            PYR[16, 0] = "¿Qja? ";
            PYR[17, 0] = "¿C?";
            PYR[18, 0] = "¿Q?";
            PYR[19, 0] = "¿Que a?";

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
            PYR[6, 1] = " ";
            PYR[7, 1] = " ";
            PYR[8, 1] = " ";
            PYR[9, 1] = " .";
            PYR[10, 1] = " ";
            PYR[11, 1] = " ";
            PYR[12, 1] = " ";
            PYR[13, 1] = " ";
            PYR[14, 1] = " ";
            PYR[15, 1] = " .";
            PYR[16, 1] = " ";
            PYR[17, 1] = " ";
            PYR[18, 1] = " ";
            PYR[19, 1] = " ";

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
            PYR[6, 2] = " ";
            PYR[7, 2] = " ";
            PYR[8, 2] = " ";
            PYR[9, 2] = " .";
            PYR[10, 2] = " ";
            PYR[11, 2] = " ";
            PYR[12, 2] = " ";
            PYR[13, 2] = " ";
            PYR[14, 2] = " ";
            PYR[15, 2] = " .";
            PYR[16, 2] = " ";
            PYR[17, 2] = " ";
            PYR[18, 2] = " ";
            PYR[19, 2] = " ";



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
            PYR[6, 3] = " ";
            PYR[7, 3] = " ";
            PYR[8, 3] = " ";
            PYR[9, 3] = " .";
            PYR[10, 3] = " ";
            PYR[11, 3] = " ";
            PYR[12, 3] = " ";
            PYR[13, 3] = " ";
            PYR[14, 3] = " ";
            PYR[15, 3] = " .";
            PYR[16, 3] = " ";
            PYR[17, 3] = " ";
            PYR[18, 3] = " ";
            PYR[19, 3] = " ";

            string opc3 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 3];
            return opc3;
        }
        public string resultado(string NumerodePregunta)
        {
            PYR[0, 4] = "3";
            PYR[1, 4] = "2";
            PYR[2, 4] = "2";
            PYR[3, 4] = "1";
            PYR[4, 4] = "3";
            PYR[5, 4] = "2";
            PYR[6, 4] = "";
            PYR[7, 4] = "";
            PYR[8, 4] = "";
            PYR[9, 4] = "";
            PYR[10, 4] = "";
            PYR[11, 4] = "";
            PYR[12, 4] = "";
            PYR[13, 4] = "";
            PYR[14, 4] = "";
            PYR[15, 4] = "";
            PYR[16, 4] = "";
            PYR[17, 4] = "";
            PYR[18, 4] = "";
            PYR[19, 4] = "";
            string resultado = PYR[Convert.ToInt32(NumerodePregunta) - 1, 4];
            return resultado;
        }
        #endregion
    }
}

