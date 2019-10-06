using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindruner2
{
    class preguntasgeografia
    {
        public string[,] PYR = new string[6, 5];
        private string pregunta;
        public string PreguntasYRespuestas(string NumerodePregunta)
        {
            PYR[0, 0] =
            PYR[0, 1] =
            PYR[0, 2] =
            PYR[0, 3] =
            PYR[0, 4] =

            PYR[1, 0] =
            PYR[1, 1] =
            PYR[1, 2] =
            PYR[1, 3] =
            PYR[1, 4] =

            PYR[2, 0] =
            PYR[2, 1] =
            PYR[2, 2] =
            PYR[2, 3] =
            PYR[2, 4] =

            PYR[3, 0] =
            PYR[3, 1] =
            PYR[3, 2] =
            PYR[3, 3] =
            PYR[3, 4] =

            PYR[4, 0] =
            PYR[4, 1] =
            PYR[4, 2] =
            PYR[4, 3] =
            PYR[4, 4] =

            PYR[5, 0] =
            PYR[5, 1] =
            PYR[5, 2] =
            PYR[5, 3] =
            PYR[5, 4] =

            pregunta = "";
            pregunta = PYR[Convert.ToInt32(NumerodePregunta) - 1, 0];

            return pregunta;

        }
    }
}