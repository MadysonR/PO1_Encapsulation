using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    public class Personnage
    {
        string nom;
        private int PointsDeVie;
        int PointsDePuissance;

        public string Nom { get => nom; set => nom = value; }
        public int PointsDevie
        { 
            get => PointsDeVie;
            set
            {
                if (value < 0)
                {
                    PointsDeVie = 0;
                }
                else
                {
                    PointsDeVie = value;
                }
            }

        }
        

        public int pointsDePuissance { get => pointsDePuissance; set => pointsDePuissance = value; }

        public bool EstEnVie
        {
            get
            {
                if (PointsDeVie > 0)
                {
                    return true;  
                }
                return false;
            }
        }
    }
}
