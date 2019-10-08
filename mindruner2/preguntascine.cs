using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindruner2
{
    class preguntascine
    {
        private string[,] PYR = new string[6, 5];


        #region Metodos

        public string Preguntas(string NumerodePregunta)
        {
            PYR[0, 0] = "¿Que personaje de Star Wars se convierte en Darth Vader?";
            PYR[1, 0] = "¿Que actor representa a Jack Sparrow en Piratas del Caribe?";
            PYR[2, 0] = "¿Que personaje de los Simpson tiene un bypass?";
            PYR[3, 0] = "¿Que tipo de pez es Nemo?";
            PYR[4, 0] = "¿Que animal es Patricio en la serie Bob Esponja? ";           
            PYR[5, 0] = "¿Cual es la pelicula más taquillera de la historia?";
            

            string pregunta = PYR[Convert.ToInt32(NumerodePregunta) - 1, 0];

            return pregunta;

        }
        public string opc1(string NumerodePregunta)
        {
            PYR[0, 1] = " Yoda";
            PYR[1, 1] = " Orlando Bloom";
            PYR[2, 1] = " El señor Burns";
            PYR[3, 1] = " Pez payaso.";
            PYR[4, 1] = " Delfín";
            PYR[5, 1] = " Titanic";
            string opc1 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 1];
            return opc1;

        }
        public string opc2(string NumerodePregunta)
        {
            PYR[0, 2] = "Kenobi";
            PYR[1, 2] = "Johnny Deep";
            PYR[2, 2] = "Krosty, el payaso";
            PYR[3, 2] = "Pez globo";
            PYR[4, 2] = "Cangrejo";
            PYR[5, 2] = "Avengers: Eng Game";


            string opc2 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 2];
            return opc2;
        }
        public string opc3(string NumerodePregunta)
        {
            PYR[0, 3] = "Skywalker";
            PYR[1, 3] = "Antonio Banderas";
            PYR[2, 3] = "Moe";
            PYR[3, 3] = "Pez dorado";
            PYR[4, 3] = "Estrella de mar rosa";
            PYR[5, 3] = "Avatar";

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
            string resultado = PYR[Convert.ToInt32(NumerodePregunta) - 1, 4];
            return resultado;
        }
        #endregion
    }
}