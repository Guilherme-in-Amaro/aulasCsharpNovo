using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace classeEstoque
{
    internal class ContaCorrente //classe
    {
        public double Numero;
        public string Titular;          //Atributos
        public double Saldo;

        public double Deposito(double valorDeposito)
        {

            Saldo = Saldo + valorDeposito;
            return Saldo;
        }

        public double Saque(double valorSaque)
        {
            Saldo = Saldo - valorSaque;
            return Saldo;
        }

        
    
    
    
    
    
    }



}
