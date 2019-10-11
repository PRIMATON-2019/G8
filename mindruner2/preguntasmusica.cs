using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindruner2
{
    public class Preguntasmusica
    {
        
                
            private string[,] PYR = new string[20, 5];


            #region Metodos

            public string Preguntas(string NumerodePregunta)
            {
                PYR[0, 0] = "¿Quién era ex cantante de ráfaga?";
                PYR[1, 0] = "¿Quién fue el interprete de la cancion 'Un Largo Camino al Cielo'?";
                PYR[2, 0] = "¿En qué fecha Falleció (El Potro) Rodrigo Bueno?";
                PYR[3, 0] = "¿Quién es el interprete de la cancion 'Ramito de Violetas'?";
                PYR[4, 0] = "¿Cúal de estos Temas interpreto J Balvin?";
                PYR[5, 0] = "¿Quién es conocido como 'El Rey del Reggaeton'?";
                PYR[6, 0] = "¿Quién compuso 'Las cuatro estaciones'?";
                PYR[7, 0] = "¿Cuál de estos instrumentos no pertenece a una orquesta sinfónica?";
                PYR[8, 0] = "¿Cómo se denomina al subgénero musical del rap que mezcla rap, hip hop y dubstep?";
                PYR[9, 0] = "¿A qué cantante se le conoce como El Sol de México?";
                PYR[10, 0] = "¿Cuántas cuerdas tiene un violín? ";
                PYR[11, 0] = "¿Cúal es el grupo en el cual ha participado el cantante Alejandro Ceberio?";
                PYR[12, 0] = "¿Cúal es su ciudad natal de el cantante Damian Cordoba?";
                PYR[13, 0] = "¿Quién es el cantante actual de el grupo 'La Barra'?";
                PYR[14, 0] = "¿Quién era el cantante de 'Soda Estereo'?";
                PYR[15, 0] = "¿Quién es el compositor de el tema 'Abrazame Muy Fuerte'?";
                PYR[16, 0] = "¿Romeo Santos con quién interpretó el tema 'Ella y Yo'? ";
                PYR[17, 0] = "¿Cuántas lineas y espacios tiene un pentagrama?";
                PYR[18, 0] = "¿En qué ciudad se originó el Jazz?";
                PYR[19, 0] = "¿Qué es el 'tempo'?";


            string pregunta = PYR[Convert.ToInt32(NumerodePregunta) - 1, 0];

                return pregunta;

            }
            public string opc1(string NumerodePregunta)
            {
                PYR[0, 1] = " El Dipy";
                PYR[1, 1] = " Walter Olmos";
                PYR[2, 1] = " 24 Junio 2000";
                PYR[3, 1] = " Damian Córdoba";
                PYR[4, 1] = " Sensacion del Bloque";
                PYR[5, 1] = " Maluma";
                PYR[6, 1] = " Beethoven";
                PYR[7, 1] = " Saxofón";
                PYR[8, 1] = " Trap";
                PYR[9, 1] = " Pedro Fernandez";
                PYR[10, 1] = "6";
                PYR[11, 1] = "Banda 21";
                PYR[12, 1] = "Córdoba";
                PYR[13, 1] = "Rubinho";
                PYR[14, 1] = "Charly Garcia";
                PYR[15, 1] = "Marcos Antonio Solís";
                PYR[16, 1] = "Tego Calderón";
                PYR[17, 1] = "5 Lineas y 5 Espacios";
                PYR[18, 1] = "Nueva Orleans";
                PYR[19, 1] = "Los espacios entre notas de una pieza musical ";


            string opc1 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 1];
                return opc1;

            }
            public string opc2(string NumerodePregunta)
            {
                PYR[0, 2] = "Rodrigo Tapari";
                PYR[1, 2] = "Ulises Bueno";
                PYR[2, 2] = "24 de Junio 2008";
                PYR[3, 2] = "Juan Carlos Jiménez Rufino";
                PYR[4, 2] = "Reggaeton";
                PYR[5, 2] = "Don Omar";
                PYR[6, 2] = "Mozart";
                PYR[7, 2] = "Piano";
                PYR[8, 2] = "Reggae";
                PYR[9, 2] = "Luis Miguel";
                PYR[10, 2] = "4";
                PYR[11, 2] = "La Konga";
                PYR[12, 2] = "Catamarca";
                PYR[13, 2] = "Javier Brizuela";
                PYR[14, 2] = "Andrés Calamaro";
                PYR[15, 2] = "Juan Gabriel";
                PYR[16, 2] = "Don Omar";
                PYR[17, 2] = "5 Lineas y 4 Espacios";
                PYR[18, 2] = "París";
                PYR[19, 2] = "El ritmo de una pieza musical";


            string opc2 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 2];
                return opc2;
            }
            public string opc3(string NumerodePregunta)
            {
                PYR[0, 3] = "Ariel Pucheta";
                PYR[1, 3] = "Rodrigo Bueno";
                PYR[2, 3] = "14 de Junio 2000";
                PYR[3, 3] = "Rubén Kesito Pavón";
                PYR[4, 3] = "Adictiva";
                PYR[5, 3] = "Daddy Yanke";
                PYR[6, 3] = "Vivaldi";
                PYR[7, 3] = "Arpa";
                PYR[8, 3] = "Reggaeton";
                PYR[9, 3] = "Vicente Fernández";
                PYR[10, 3] = "8";
                PYR[11, 3] = "Trulalá";
                PYR[12, 3] = "Rosario";
                PYR[13, 3] = "Lisandro Márquez";
                PYR[14, 3] = "Gustavo Cerati";
                PYR[15, 3] = "Prince Royce";
                PYR[16, 3] = "Tito El Bambino";
                PYR[17, 3] = "6 Lineas y 5 Espacios";
                PYR[18, 3] = "Nueva York";
                PYR[19, 3] = "La velocidad con que debe interpretarse una pieza musical";

            string opc3 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 3];
                return opc3;
            }
            public string resultado(string NumerodePregunta)
            {
                PYR[0, 4] = "2";
                PYR[1, 4] = "3";
                PYR[2, 4] = "1";
                PYR[3, 4] = "2";
                PYR[4, 4] = "2";
                PYR[5, 4] = "3";
                PYR[6, 4] = "3";
                PYR[7, 4] = "1";
                PYR[8, 4] = "1";
                PYR[9, 4] = "2";
                PYR[10, 4] = "2";
                PYR[11, 4] = "3";
                PYR[12, 4] = "2";
                PYR[13, 4] = "2";
                PYR[14, 4] = "3";
                PYR[15, 4] = "2";
                PYR[16, 4] = "2";
                PYR[17, 4] = "2";
                PYR[18, 4] = "1";
                PYR[19, 4] = "3";

            string resultado = PYR[Convert.ToInt32(NumerodePregunta) - 1, 4];
                return resultado;
            }
            #endregion
        
        }
    }