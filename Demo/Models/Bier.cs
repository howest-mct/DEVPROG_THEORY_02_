using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Models
{
    public class Bier
    {
        public string naam;
        public string brouwerij;
        private double alcoholpercentage;
        //public string kleur;

        //propfull tab tab
        private string kleur;

        public string Kleur
        {
            get { return kleur; }
            set {
                if (value == "")
                {
                    kleur = "Blond";
                }
                else
                {
                    kleur = value;
                }
                
            }
        }



        public static int bierCount;

        public string LocatieBrouwerij { get; set; }

        public string ExtendName
        {
            get { return this.naam + " - " + this.Kleur; }
        }


        //Voor aanmaak van een constructor kun je code-snippet ctor gebruiken
        public Bier()
        {
            //naam = null;
            //brouwerij = null;
            //alcoholpercentage = 0.0;
            //kleur = null;
            bierCount++;
        }

        public Bier(string naam) : this()
        {
            this.naam = naam;
            //bierCount++;
        }

        public Bier(string naam, string brouwerij, double alcoholperc, string kleur) : this()
        {
            this.naam = naam;
            this.brouwerij = brouwerij;
            this.alcoholpercentage = alcoholperc;
            this.Kleur = kleur;
            //bierCount++;
        }

        //public double Alcoholverschil(Bier someBeer)
        //{
        //    return Math.Abs(this.alcoholpercentage - someBeer.alcoholpercentage);
        //}

        public static double Alcoholverschil(Bier beer1, Bier beer2)
        {
            return Math.Abs(beer1.alcoholpercentage - beer2.alcoholpercentage);
        }

        public override string ToString()
        {
            return naam + " - " + brouwerij + " - " + alcoholpercentage + " - " + kleur; 
        }


        // dit gaan we vermijden, maak gebruik properties ivp methods
        public void SetAlcoholpercentage(double alcoholpercentage)
        {
            if (alcoholpercentage < 0)
            {
                this.alcoholpercentage = 0;
            }
            else
            {
                this.alcoholpercentage = alcoholpercentage;
            }
        }

        public double GetAlcoholpercentage() { return alcoholpercentage; }




    }
}
