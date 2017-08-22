using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Calculadora
    {
        double _num1;
        double _num2;
        public Calculadora(double num1,double num2)
        {
            this._num1 = num1;
            this._num2 = num2;
        }
        public Calculadora()
        {

        }

        public int Sumar(int val1,int val2,int val3)
        {
            return val1 + val2 + val3;
        }
        public double Sumar(double val1,double val2)
        {
            return (val1+val2);
        }
        public double Sumar(double numero)
        {
            double resp = (numero+_num1+_num2);
            return resp;
        }
    }
}