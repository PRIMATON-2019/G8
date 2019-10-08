using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindruner2
{
    class preguntasdeportes
    {
        private string[,] PYR = new string[6, 5];


        #region Metodos

        public string Preguntas(string NumerodePregunta)
        {
            PYR[0, 0] = "¿Que equipo tiene su estadio en el barrio de Nueva Italia en Córdoba?";
            PYR[1, 0] = "¿A qué equipo le pertenece el mundialmente famoso Estadio Santiago Bernabéu?";
            PYR[2, 0] = "¿A que equipo italiano se lo conoce como La Veccia Signora?";
            PYR[3, 0] = "¿En que país se disputaron por primera vez los juegos panamericanos?";
            PYR[4, 0] = "¿Cuantos partidos de Copa del Mundo jugó Diego Armando Maradona?";
            PYR[5, 0] = "¿En que deporte se ha destacado Shaquille O' Neal?";


            string pregunta = PYR[Convert.ToInt32(NumerodePregunta) - 1, 0];

            return pregunta;

        }
        public string opc1(string NumerodePregunta)
        {
            PYR[0, 1] = " Deportivo Italiano";
            PYR[1, 1] = " Sevilla FC";
            PYR[2, 1] = " Inter";
            PYR[3, 1] = " Bruce Willis";
            PYR[4, 1] = " 7";
            PYR[5, 1] = " Golf";
            string opc1 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 1];
            return opc1;

        }
        public string opc2(string NumerodePregunta)
        {
            PYR[0, 2] = "Talleres";
            PYR[1, 2] = "Real Madrid";
            PYR[2, 2] = "Juventus";
            PYR[3, 2] = "el chapulin";
            PYR[4, 2] = "15";
            PYR[5, 2] = "Basquet";


            string opc2 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 2];
            return opc2;
        }
        public string opc3(string NumerodePregunta)
        {
            PYR[0, 3] = "Racing de Córdoba";
            PYR[1, 3] = "FC Barcelona";
            PYR[2, 3] = "Sampdoria";
            PYR[3, 3] = "Maradona";
            PYR[4, 3] = "21";
            PYR[5, 3] = "Natación";

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
