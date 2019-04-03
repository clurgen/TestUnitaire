using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_unitaire
{
    class Ean13
    {
        private int[] ean13;

        public Ean13(int[] ean13)
        {
            if (ean13.Length !=12)
            {
                throw new Exception("Le code Ean 13 ne contient pas 12 entiers");
            }
            this.ean13 = new int[13];
            for (int i = 0; i<12; i++) 
            {
                this.ean13[i] = ean13[i];
            }

            this.ean13 = new int[12];
            int k = 0;
            foreach (int i in ean13)
            {
                this.ean13[k] = i;
                k++;
            }

            for (int i = 0; i < 12; i++)
            {
                if (this.ean13[i] < 0 || this.ean13[i] > 9) 
                {
                    throw new Exception("Les élements du Gencode doivent être compris entre 0 et 9");
                }
            }
        }

        private int poids(int indiceDepart)
        {
            int poids = 0;
            for (int i = indiceDepart; i < 12; i = i + 2)
            {
                poids = poids + this.ean13[i];
            }
            return poids;
        }

        public int PoidsImpair()
        {
            return this.poids(0);
        }

        public int PoidsPair()
        {
            int poids = this.poids(1) * 3;
            return poids;
        }

        public int Reste()
        {
            int reste = this.PoidsImpair() + this.PoidsPair();
            reste = reste % 10;
            return reste;
        }

        public int Cle()
        {
            int cle = 0;
            if (this.Reste() == 0) 
            {
                cle = 0;
            }
            if (this.Reste() != 0 && this.Reste() < 10)
            {
                cle = 10 - this.Reste() ;
            }
            return cle;
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < 12; i++)
            {
                if (i % 4 == 0 && i !=0)
                {
                    s = s + "-";
                }
                s = s + ean13[i];

            }
            s = s + "-" + this.Cle();
            return s;
        }

    }
}
