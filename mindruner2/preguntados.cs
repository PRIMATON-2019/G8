using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindruner2
{
    public class preguntados
    {
        
        private string[,] PYR = new string[20, 5];

        
        #region Metodos

        public string Preguntas(string NumerodePregunta)
        {
            PYR[0, 0] = "¿En que ciudad europea está el Palacio de la UNESCO?";             
            PYR[1, 0] = "¿Quién Mató, según el historiador romano Marcelino, al invencible Atila?"; 
            PYR[2, 0] = "¿Cuántos eran los Caballeros de la Mesa Redonda?";
            PYR[3, 0] = "¿Qué país inventó los barriltes y los tallarines";
            PYR[4, 0] = "¿Dónde murió el General Jósé Gervasio Artigas?";
            PYR[5, 0] = "¿Qué ciudad uruguaya se lamó originariamente Pueblo Ituzaingó?";
            PYR[6, 0] =  "¿Cuál es el seudónimo del mexicano Doroteo Arango?";
            PYR[7, 0] =  "¿Que nombre es la W de George W. Bush?";
            PYR[8, 0] =  "¿Quienes dominaban Perú hasta la llegada de los españoles?";
            PYR[9, 0] =  "¿En qué país nació Sor Juana Inés de la Cruz?";
            PYR[10, 0] =  "¿En qué ciudad italiana nació Galileo Galilei?";
            PYR[11, 0] =  "¿En 1893 una país fue el primero en otorgar el voto femenino?";
            PYR[12, 0] =  "¿A qué oficio se dedicaba José el marido de la virgen María?";
            PYR[13, 0] =  "¿Qué nombre corresponde a la B del destacado polílitico socialista argentino Juan B. Justo?";
            PYR[14, 0] =  "¿En qué país nació la Madre Teresa de Calcuta?";
            PYR[15, 0] =  "¿A quién asesinó Mark David Chapman?";
            PYR[16, 0] =  "¿Quién dijo (Vine, ví, Vencí)";
            PYR[17, 0] =  "¿En qué país fue presidente Getúlio Vargas?";
            PYR[18, 0] =  "¿En qué cermenterio está enterrado el General Perón?";
            PYR[19, 0] =  "¿Cómo se llamaba la esposa de Luis XVI?";
                       
            string pregunta = PYR[Convert.ToInt32(NumerodePregunta) - 1, 0];
                 
            return pregunta;

        }
        public string opc1(string NumerodePregunta)
        {
            PYR[0, 1] = " En Ginebra";
            PYR[1, 1] = " Los Godos";
            PYR[2, 1] = " Veinte";
            PYR[3, 1] = " Los Chinos";
            PYR[4, 1] = " Argentina";
            PYR[5, 1] = " Maldonado";
            PYR[6, 1] =  "Zapata";
            PYR[7, 1] =  "Willian";
            PYR[8, 1] =  "Los Mayas";
            PYR[9, 1] =  "España";
            PYR[10, 1] =  "Pisa";
            PYR[11, 1] =  "Irlanda";
            PYR[12, 1] =  "Era Herrero";
            PYR[13, 1] =  "Bernardo";
            PYR[14, 1] =  "En Albania";
            PYR[15, 1] =  "A Martín Luther King";
            PYR[16, 1] =  "Napoléon";
            PYR[17, 1] =  "Bolivia";
            PYR[18, 1] =  "La Recoleta";
            PYR[19, 1] =  "Ana Bolena";
            string opc1 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 1];
            return opc1;

        }
        public string opc2(string NumerodePregunta)
        {
            PYR[0, 2] = "En París";
            PYR[1, 2] = "Los ostrogodos";
            PYR[2, 2] = "Doce";
            PYR[3, 2] = "Los Egipcios";
            PYR[4, 2] = "Uruguay";
            PYR[5, 2] = "Punta del Este";
            PYR[6, 2] =  "Pancho Villa";
            PYR[7, 2] =  "Walter";
            PYR[8, 2] =  "Los Incas";
            PYR[9, 2] =  "Chile";
            PYR[10, 2] =  "Roma";
            PYR[11, 2] =  "Francia";
            PYR[12, 2] =  "Era Carpintero";
            PYR[13, 2] =  "Bautista";
            PYR[14, 2] =  "En India";
            PYR[15, 2] =  "A.J.F. Kennedy";
            PYR[16, 2] =  "Julio César";
            PYR[17, 2] =  "Venezuela";
            PYR[18, 2] =  "Chacarita";
            PYR[19, 2] =  "Margarita de Navarra";


            string opc2 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 2];
            return opc2;
        }
        public string opc3(string NumerodePregunta)
        {
            PYR[0, 3] = "En Madrid";
            PYR[1, 3] = "Su última Esposa";
            PYR[2, 3] = "Diez";
            PYR[3, 3] = "Los griegos";
            PYR[4, 3] = "Paraguay";
            PYR[5, 3] = "Colonia";
            PYR[6, 3] =  "Cantinflas";
            PYR[7, 3] =  "Walker";
            PYR[8, 3] =  "Los Aztecas";
            PYR[9, 3] =  "Mexico";
            PYR[10, 3] =  "Florencia";
            PYR[11, 3] =  "Nueva Zelanda";
            PYR[12, 3] =  "Era pastor";
            PYR[13, 3] =  "Blas";
            PYR[14, 3] =  "En la ex Yugoslavia";
            PYR[15, 3] =  "A Jhon Lenon";
            PYR[16, 3] =  "Carlos V";
            PYR[17, 3] =  "Brasil";
            PYR[18, 3] =  "Olivos";
            PYR[19, 3] =  "María Antonieta";

            string opc3 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 3];
            return opc3;
        }
        public string resultado (string NumerodePregunta)
        {
            PYR[0, 4] = "2";
            PYR[1, 4] = "3";
            PYR[2, 4] = "2";
            PYR[3, 4] = "1";
            PYR[4, 4] = "3";
            PYR[5, 4] = "2";
            PYR[6, 4] =  "2";
            PYR[7, 4] =  "3";
            PYR[8, 4] =  "2";
            PYR[9, 4] =  "3";
            PYR[10, 4] =  "2";
            PYR[11, 4] =  "3";
            PYR[12, 4] =  "2";
            PYR[13, 4] =  "2";
            PYR[14, 4] =  "1";
            PYR[15, 4] =  "3";
            PYR[16, 4] =  "2";
            PYR[17, 4] =  "3";
            PYR[18, 4] =  "2";
            PYR[19, 4] =  "3";
            string resultado = PYR[Convert.ToInt32(NumerodePregunta) - 1, 4];
            return resultado;
        }
        #endregion
              
    }

}
