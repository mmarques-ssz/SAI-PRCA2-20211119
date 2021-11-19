using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WFA_SomaPOO
{
    class Soma
    {
        private int num1;
        private int num2;
        private int resultado;

        public Soma()
        {
            this.num1 = 0;
            this.num2 = 0;
        }

        public Soma(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public void setNum1(int num1)
        {
            this.num1 = num1;
        }

        public void setNum2(int num2)
        {
            this.num2 = num2;
        }

        public int getNum1()
        {
            return this.num1;
        }

        public int getNum2()
        {
            return this.num2;
        }

        public int getResultado()
        {
            return this.resultado;
        }

        public void calcular()
        {
            this.resultado = this.num1 + this.num2;
        }

        public bool resultadoPar()
        {
            return (this.resultado % 2 == 0);
        }

        public bool resultadoNegativo()
        {
            return (resultado < 0);
        }

    }
}
