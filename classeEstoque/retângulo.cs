using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeEstoque
{
    internal class Retangulo //classe
    {
        public double Altura = 30;
        public double Largura = 40;
    
        public double Area()    //metodo
        {
            return Altura * Largura;
        }
        public double Perimetro()           //metodo

        {
            return 2 * (Altura + Largura);
        }


    } 
}
