using System;

namespace Calculadora
{
    class Calcular
    {
        private int n1;
        private int n2;
        public void setN1(int n1)
        {
            this.n1 = n1;
        }
        public void setN2(int n2)
        {
            this.n2 = n2;
        }
        public int getN1()
        {
            return this.n1;
        }
        public int getN2()
        {
            return this.n2;
        }

        public int somar()
        {
            return this.n1 + this.n2;
        }

        public int subtrair()
        {
            return this.n1 - this.n2;
        }

        public int multiplicar()
        {
            return this.n1 * this.n2;
        }

        public double dividir()
        {
            return (double)this.n1 / this.n2;
        }
    }

}