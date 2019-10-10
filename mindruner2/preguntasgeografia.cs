using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindruner2
{
    class preguntasgeografia
    {
        private string[,] PYR = new string[20, 5];


        #region Metodos

        public string Preguntas(string NumerodePregunta)
        {
            PYR[0, 0] = "¿En que continente estan las montañas Rocallosas?";
            PYR[1, 0] = "¿En que país está el Taj Mahal?.";
            PYR[2, 0] =  "¿En que provincia está la ciudad de Trelew?";
            PYR[3, 0] =  "¿En que país está la región de Transilvania, patria de Drácula?";
            PYR[4, 0] =  "¿En que país es el quechua una lengua oficial?";
            PYR[5, 0] =  "¿Que país tiene un machete en la bandera?" ;
            PYR[6, 0] =  "¿De que provincia es la capital de la ciudad de Paraná?";
            PYR[7, 0] =  " ¿En que país se encuentra la ciudad de Viña del Mar?";
            PYR[8, 0] =  "¿Cerca de las costas de que país está la Isla de Aruba?";
            PYR[9, 0] =  "¿En que país está el puerto de Casablaca?";
            PYR[10, 0] =  "¿En que mar se encuentra la Isla de Chipre?";
            PYR[11, 0] =  "¿Cómo se dice al que nació en Vizcaya?";
            PYR[12, 0] =  "¿En que mar desemboca el Río Nilo?";
            PYR[13, 0] =  "¿En que ciudad estadounidense está el puente Golden Gate?";
            PYR[14, 0] =  "Hélade era el nombre primitivo ¿de que país?";
            PYR[15, 0] =  "¿A que país pertenece la Isla Margarita";
            PYR[16, 0] =  "¿Que animal hay en la bandera de bután";
            PYR[17, 0] =  "¿Cuál es el único país africano en donde se habla español?";
            PYR[18, 0] =  "¿Cuál es el país del mundo que tiene más volcanes?";
            PYR[19, 0] =  "¿En que mar desemboca el Río Jordán?";
 

            string pregunta = PYR[Convert.ToInt32(NumerodePregunta) - 1, 0];

            return pregunta;

        }
        public string opc1(string NumerodePregunta)
        {
            PYR[0, 1] = " Asia.";
            PYR[1, 1] = " Arabia";
            PYR[2, 1] = "  Rio Negro";
            PYR[3, 1] = "  Rumania";
            PYR[4, 1] = " Peru ";
            PYR[5, 1] = " Haití";
            PYR[6, 1] =  " Entre Ríos";
            PYR[7, 1] =  "España";
            PYR[8, 1] =  "Colombia";
            PYR[9, 1] =  "Uruguay";
            PYR[10, 1] =  "en el Mediterráneo";
            PYR[11, 1] =  "Vizcaíno";
            PYR[12, 1] =  "Rojo";
            PYR[13, 1] =  "Los Angeles";
            PYR[14, 1] =  "Grecia";
            PYR[15, 1] =  "Cuba";
            PYR[16, 1] =  "Un Águila";
            PYR[17, 1] =  "Mauritania";
            PYR[18, 1] =  "Estados Unidos";
            PYR[19, 1] =  "En el Mar Caspio";
            string opc1 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 1];
            return opc1;

        }
        public string opc2(string NumerodePregunta)
        {
            PYR[0, 2] =" Europa.";
            PYR[1, 2] = "Tailandia";
            PYR[2, 2] = "Chubut";
            PYR[3, 2] = " Alemania";
            PYR[4, 2] = "Paraguay";
            PYR[5, 2] = "Filipinas ";
            PYR[6, 2] =  "Santa Fe ";
            PYR[7, 2] =  "Chile";
            PYR[8, 2] =  "Brasil";
            PYR[9, 2] =  "México";
            PYR[10, 2] =  "En el Mar de Oman";
            PYR[11, 2] =  "Vizcaitarra ";
            PYR[12, 2] =  " Mediterraneo";
            PYR[13, 2] =  "San Francisco";
            PYR[14, 2] =  "Islandia";
            PYR[15, 2] =  "Ecuador";
            PYR[16, 2] =  "Un León";
            PYR[17, 2] =  "Sierra Leona";
            PYR[18, 2] =  "Indonesia";
            PYR[19, 2] =  "En el Mar Muerto";


            string opc2 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 2];
            return opc2;
        }
        public string opc3(string NumerodePregunta)
        {
            PYR[0, 3] = " America.";
            PYR[1, 3] = "India";
            PYR[2, 3] = "Santa Cruz";
            PYR[3, 3] = " Rusia";
            PYR[4, 3] = " Bolivia";
            PYR[5, 3] = "Angola";
            PYR[6, 3] =  "Misiones ";
            PYR[7, 3] =  "Colombia";
            PYR[8, 3] =  "Venezuela";
            PYR[9, 3] =  "Marruecos";
            PYR[10, 3] =  "En el Mar Negro";
            PYR[11, 3] =  "Vizcalino";
            PYR[12, 3] =  "Arábigo";
            PYR[13, 3] =  "Houston";
            PYR[14, 3] =  "Finlandia";
            PYR[15, 3] =  "Venezuela";
            PYR[16, 3] =  "Un Dragón";
            PYR[17, 3] =  "Guinea Ecuatorial";
            PYR[18, 3] =  "Japón";
            PYR[19, 3] =  "En el Mar Mediterraneo";

            string opc3 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 3];
            return opc3;
        }
        public string resultado(string NumerodePregunta)
        {
            PYR[0, 4] = "3";
            PYR[1, 4] = "3";
            PYR[2, 4] = "2";
            PYR[3, 4] = "1";
            PYR[4, 4] = "1";
            PYR[5, 4] = "3";
            PYR[6, 4] =  "1";
            PYR[7, 4] =  "2";
            PYR[8, 4] =  "3";
            PYR[9, 4] =  "3";
            PYR[10, 4] =  "1";
            PYR[11, 4] =  "1";
            PYR[12, 4] =  "2";
            PYR[13, 4] =  "2";
            PYR[14, 4] =  "1";
            PYR[15, 4] =  "3";
            PYR[16, 4] =  "3";
            PYR[17, 4] =  "3";
            PYR[18, 4] =  "2";
            PYR[19, 4] =  "2";

            string resultado = PYR[Convert.ToInt32(NumerodePregunta) - 1, 4];
            return resultado;
        }
        #endregion
    }
}