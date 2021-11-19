using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WFA_Contador
{
    class Contador
    {
        private int numero;

        public Contador()
        {
            this.numero = 0;
        }

        public Contador(int numero)
        {
            this.numero = numero;
        }

        public int getNumero()
        {
            return this.numero;
        }

        public void zerar()
        {
            this.numero = 0;
        }

        public void adicionar()
        {
            this.numero++;
        }

        public void subtrair()
        {
            this.numero--;
        }
    }
}
