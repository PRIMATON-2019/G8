using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindruner2
{
    public class Suma
    {

        public int contador1 ;
        public int contador2 ;
        public int contador3 ;
        public int contador4 ;


        public int SumaPuntaje1()
        {
            contador1 += 10;
            return  contador1;
        }
        public int SumaPuntaje2()
        {
            contador2 += 10;
            return contador2;
        }
        public int SumaPuntaje3()
        {
            contador3 += 10;
            return contador3;
        }
        public int SumaPuntaje4()
        {
            contador4 +=  10;
            return contador4;
        }
        public string VisualizarPuntaje1()
        {
            return Convert.ToString(contador1);
        }
        public string VisualizarPuntaje2()
        {
            return Convert.ToString(contador2);
        }
        public string VisualizarPuntaje3()
        {
            return Convert.ToString(contador3);
        }
        public string VisualizarPuntaje4()
        {
            return Convert.ToString(contador4);
        }
    }
}