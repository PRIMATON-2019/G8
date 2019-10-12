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
            PYR[0, 0] = "¿La Forma de alimentarse de los vegetales se llama?";
            PYR[1, 0] = "¿Qué significa que una planta sea vascular?";
            PYR[2, 0] = "¿Cuáles son las Partes de un Vegetal Cormófito?";
            PYR[3, 0] = "¿El nitrogeno, gas mas abundante de la atmosfera terrestre es importante en la agricultura, Porque?";
            PYR[4, 0] = "¿Cuál es la temporada de invierno en Argentina?";
            PYR[5, 0] = "¿Cuándo comienza el otoño en Argentina?";
            PYR[6, 0] = "¿Cuántas estaciones del año hay?";
            PYR[7, 0] = "¿En qué Capa atmosferica se ubican los Satelite?";
            PYR[8, 0] = "¿Comó es que se produce la lluvia?";
            PYR[9, 0] = "¿Qué canal de televisión transmiten información sobre la vida de los animales?";
            PYR[10, 0] = "¿Qué animal es adaptado al frío extremo?";
            PYR[11, 0] = "¿Qué es un fósil?";
            PYR[12, 0] = "¿Cómo se llama a la ciencia que estudia los fósiles?";
            PYR[13, 0] = "¿Cómo se llama al cambio orgánico que favorece la posibilidad de supervivencia y reproducción?";
            PYR[14, 0] = "¿Cómo están formados los seres unicelulares?";
            PYR[15, 0] = "¿Cómo están constituidos los seres pluricelulares?";
            PYR[16, 0] = "¿El orgánulo que obtiene energía que necesita la célula es: ?";
            PYR[17, 0] = "¿Quién hace posible la respiración, la audición, que el corazón bombee sangre al cuerpo y que el estomago digiera algún alimento?";
            PYR[18, 0] = "¿Cual es el órgano del sistema nervioso, que coordina algunos movimientos del cuerpo?";
            PYR[19, 0] = "¿Comó se le llama al sistema de glándulas de secreción interna?";

            string pregunta = PYR[Convert.ToInt32(NumerodePregunta) - 1, 0];

            return pregunta;

        }
        public string opc1(string NumerodePregunta)
        {
            PYR[0, 1] = "La Fotosintesis";
            PYR[1, 1] = "Que se mueve para los lados cuando hay viento";
            PYR[2, 1] = "Filoides, rizoides y cauloides";
            PYR[3, 1] = "Permite mayor retencion de agua";
            PYR[4, 1] = "21 de septiembre";
            PYR[5, 1] = "21 de Marzo";
            PYR[6, 1] = "3 Estaciones en el año";
            PYR[7, 1] = "Atmosfera";
            PYR[8, 1] = "Se inicia con la condensación del vapor de agua contenido en las nubes";
            PYR[9, 1] = "Cartoon Network";
            PYR[10, 1] = "León";
            PYR[11, 1] = "Es un resto de un ser vivo que se ha petrificado a través de los años";
            PYR[12, 1] = "Paleontología";
            PYR[13, 1] = "Adaptación";
            PYR[14, 1] = "Por una célula";
            PYR[15, 1] = "Por más de una célula";
            PYR[16, 1] = "La mitocondria";
            PYR[17, 1] = "El sistema nervioso";
            PYR[18, 1] = "El cerebro";
            PYR[19, 1] = "Sistema Endocrino";

            string opc1 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 1];
            return opc1;

        }
        public string opc2(string NumerodePregunta)
        {
            PYR[0, 2] = "Quimiosintesis";
            PYR[1, 2] = "Que pesa mucho en la Bascula";
            PYR[2, 2] = "Raiz, Tallo y flores";
            PYR[3, 2] = "Permite a los cultivos formar proteinas";
            PYR[4, 2] = "21 de diciembre";
            PYR[5, 2] = "21 de septiembre";
            PYR[6, 2] = "4 Estaciones del año";
            PYR[7, 2] = "Exosfera";
            PYR[8, 2] = "Por Causa de un Terremoto";
            PYR[9, 2] = "Tyc Sports";
            PYR[10, 2] = "Camello";
            PYR[11, 2] = "Son restos de pisadas de un ser vivo";
            PYR[12, 2] = "Astronomía";
            PYR[13, 2] = "Desadaptación";
            PYR[14, 2] = "Por un átomo";
            PYR[15, 2] = "Por una celula y un átomo";
            PYR[16, 2] = "Virus";
            PYR[17, 2] = "El sistema Endocrino";
            PYR[18, 2] = "Medula";
            PYR[19, 2] = "Sistema Nervioso";



            string opc2 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 2];
            return opc2;
        }
        public string opc3(string NumerodePregunta)
        {
            PYR[0, 3] = "Nutricion Heterotrofa";
            PYR[1, 3] = "Que tiene tejidos conductores de sustancia";
            PYR[2, 3] = "Raiz, tallo y hojas";
            PYR[3, 3] = "Permite la fotosintesis en las plantas";
            PYR[4, 3] = "21 de junio";
            PYR[5, 3] = "21 de junio";
            PYR[6, 3] = "5 Estaciones en el año";
            PYR[7, 3] = "Estratosfera";
            PYR[8, 3] = "cada un año";
            PYR[9, 3] = "Animal Planet";
            PYR[10, 3] = "Morsa";
            PYR[11, 3] = "Un fosil es un ser vivo";
            PYR[12, 3] = "Fisiología";
            PYR[13, 3] = "Perdida de noción";
            PYR[14, 3] = "Por Microparticulas";
            PYR[15, 3] = "Por una Molecula";
            PYR[16, 3] = "Bacterias";
            PYR[17, 3] = "El sistema Excretor";
            PYR[18, 3] = "Oido";
            PYR[19, 3] = "Sistema Circulatorio";

            string opc3 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 3];
            return opc3;
        }
        public string resultado(string NumerodePregunta)
        {
            PYR[0, 4] = "1";
            PYR[1, 4] = "3";
            PYR[2, 4] = "3";
            PYR[3, 4] = "2";
            PYR[4, 4] = "3";
            PYR[5, 4] = "1";
            PYR[6, 4] = "2";
            PYR[7, 4] = "2";
            PYR[8, 4] = "1";
            PYR[9, 4] = "3";
            PYR[10, 4] = "3";
            PYR[11, 4] = "1";
            PYR[12, 4] = "1";
            PYR[13, 4] = "1";
            PYR[14, 4] = "1";
            PYR[15, 4] = "1";
            PYR[16, 4] = "1";
            PYR[17, 4] = "1";
            PYR[18, 4] = "1";
            PYR[19, 4] = "1";
            string resultado = PYR[Convert.ToInt32(NumerodePregunta) - 1, 4];
            return resultado;
        }
        #endregion
    }
}

