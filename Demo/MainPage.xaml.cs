using Demo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Bier b1 = new Bier();
            b1.naam = "Augustijn";
            b1.brouwerij = "Bios";
            //b1.alcoholpercentage = 12.0;
            b1.SetAlcoholpercentage(12.0);
            //b1.kleur = "Amber";
            b1.Kleur = "Amber";

            //Debug.WriteLine($"{b1.naam} - {b1.brouwerij} - {b1.alcoholpercentage}");
            Debug.WriteLine($"{b1.naam} - {b1.brouwerij} - {b1.GetAlcoholpercentage()}");

            Bier b2 = new Bier("Jupiler", "AB Inbev", 5.2, "blond");
            Debug.WriteLine($"{b2.naam} - {b2.brouwerij} - {b2.GetAlcoholpercentage()}");

            Bier b3 = new Bier("Omer", "Vander Ghinste", 8, "blond");
            Debug.WriteLine($"{b3.naam} - {b3.brouwerij} - {b3.GetAlcoholpercentage()}");

            Debug.WriteLine($"We hebben nu {Bier.bierCount} bier(en)");

            //verschil berekenen tussen alcoholperc
            //double alcoholverschil = b1.Alcoholverschil(b2);
            //Debug.WriteLine($"Alcoholverschil tussen {b1.alcoholpercentage} en {b2.alcoholpercentage} = {alcoholverschil}");

            //maak gebruik van een static method
            double alcoholverschil = Bier.Alcoholverschil(b1, b2);
            Debug.WriteLine($"Alcoholverschil tussen {b1.GetAlcoholpercentage()} en {b2.GetAlcoholpercentage()} = {alcoholverschil}");

            Bier b4 = new Bier("Stella", "Inbev", -5.2, "Blond");
            Debug.WriteLine(b4.ToString());

            b4.SetAlcoholpercentage(-5);
            Debug.WriteLine(b4.ToString());

            Bier b5 = new Bier("Westmalle Tripel", "", 9, "");
            Debug.WriteLine(b5.ToString());

            b5.LocatieBrouwerij = "Westmalle";
            Debug.WriteLine(b5.ExtendName);


        }
    }
}
