using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindruner2
{
    class preguntasdeportes
    {
        private string[,] PYR = new string[20, 5];


        #region Metodos

        public string Preguntas(string NumerodePregunta)
        {
            PYR[0, 0] = "¿Que equipo tiene su estadio en el barrio de Nueva Italia en Córdoba?";
            PYR[1, 0] = "¿A qué equipo le pertenece el mundialmente famoso Estadio Santiago Bernabéu?";
            PYR[2, 0] = "¿A que equipo italiano se lo conoce como La Veccia Signora?";
            PYR[3, 0] = "¿En que país se disputaron por primera vez los juegos panamericanos?";
            PYR[4, 0] = "¿Cuantos partidos de Copa del Mundo jugó Diego Armando Maradona?";
            PYR[5, 0] = "¿En que deporte se ha destacado Shaquille O' Neal?";
            PYR[6, 0] = "¿Cuántas finales del mundo jugó la Selección Argentina de fútbol?";
            PYR[7, 0] = "¿Cuál es el estilo de natación más rápido?";
            PYR[8, 0] = "¿Donde se jugó la copa del mundo de 2018?";
            PYR[9, 0] = "¿Cuál es el estadio de fútbol con mayor capacidad en América?";
            PYR[10, 0] = "¿Cuánto dura un partido de fútbol?";
            PYR[11, 0] = "¿Cuál es el país de origen del futbolista Lionel Messi?";
            PYR[12, 0] = "¿A qué jugador de fútbol le apodan 'El Apache'?";
            PYR[13, 0] = "¿A qué jugador de fútbol le apodan 'CR7'?";
            PYR[14, 0] = "¿En qué club de Italia jugó Diego Maradona?";
            PYR[15, 0] = "¿De qué colores es la camiseta de River Plate?";
            PYR[16, 0] = "¿Cómo se llamaba la mascota del mundial Rusia 2018?";
            PYR[17, 0] = "Si jugas en la NFL,¿qué deporte practicas?";
            PYR[18, 0] = "¿Que equipo mandó a River al descenso en el 2011?";
            PYR[19, 0] = "¿Qué deporte practica Rafael Nadal a nivel profesional?";


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
            PYR[6, 1] = " Cinco ";
            PYR[7, 1] = " Crol";
            PYR[8, 1] = " Qatar";
            PYR[9, 1] = " Estadio Azteca (Mexico)";
            PYR[10, 1] = "90 minutos";
            PYR[11, 1] = "España";
            PYR[12, 1] = "Messi";
            PYR[13, 1] = "Cristiano Ronaldo";
            PYR[14, 1] = "Napoli";
            PYR[15, 1] = "Verde y amarillo";
            PYR[16, 1] = "Zabivaka";
            PYR[17, 1] = "Futbol Americano";
            PYR[18, 1] = "Boca Juniors";
            PYR[19, 1] = "Golf";


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
            PYR[6, 2] = "Seis";
            PYR[7, 2] = "Espalda";
            PYR[8, 2] = "Brasil";
            PYR[9, 2] = "Estadio Maracaná (Brasil)";
            PYR[10, 2] = "75 minutos";
            PYR[11, 2] = "Argentina";
            PYR[12, 2] = "Cristiano Ronaldo";
            PYR[13, 2] = "Ronaldinho";
            PYR[14, 2] = "Juventus";
            PYR[15, 2] = "Rojo y blanco";
            PYR[16, 2] = "Zakumi";
            PYR[17, 2] = "Basquet";
            PYR[18, 2] = "Belgrano";
            PYR[19, 2] = "Natación";


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
            PYR[6, 3] = "Cuatro";
            PYR[7, 3] = "Pecho";
            PYR[8, 3] = "Rusia";
            PYR[9, 3] = "Estadio Monumentar (Argentina)";
            PYR[10, 3] = "30 minutos";
            PYR[11, 3] = "Chile";
            PYR[12, 3] = "Carlos Tevez";
            PYR[13, 3] = "Lionel Messi";
            PYR[14, 3] = "Roma";
            PYR[15, 3] = "Azul y amarillo";
            PYR[16, 3] = "Vladimir";
            PYR[17, 3] = "Volleyball";
            PYR[18, 3] = "Talleres";
            PYR[19, 3] = "Tenis";

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
            PYR[6, 4] = "3";
            PYR[7, 4] = "1";
            PYR[8, 4] = "3";
            PYR[9, 4] = "1";
            PYR[10, 4] ="1";
            PYR[11, 4] = "2";
            PYR[12, 4] = "3";
            PYR[13, 4] = "1";
            PYR[14, 4] = "1";
            PYR[15, 4] = "2";
            PYR[16, 4] = "1";
            PYR[17, 4] = "1";
            PYR[18, 4] = "2";
            PYR[19, 4] = "3";

            string resultado = PYR[Convert.ToInt32(NumerodePregunta) - 1, 4];
            return resultado;
        }
        #endregion
    }


}
