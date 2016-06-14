using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    interface airplane
    {
        int maxHeight { get; }  // maximale Flughöhe
        int maxSpeed { get; }  // maximale Geschwindigkeit
        string tag { get; }  // Bezeichnung
    }


    // Propellermaschine
    public class propAirliner
    {
        private int anzProp; // Anzahl der Propeller
        public int maxHeight { get; };
        public int maxSpeed { get; };
        public string tag { get; };

        public propAirliner(int height, int speed, string name)
        {
            maxHeight = height;
            maxSpeed = speed;
            tag = name;
        }

        public int getAnzProp()
        {
            return anzProp;
        }

        public void setAnzProp(int anz)
        {
            anzProp = anz;
        }

    }

    // Düsenjet
    public class jet
    {
        private int anzJetEngines; // Anzahl der JetEngines
        public int maxHeight { get; };
        public int maxSpeed { get; };
        public string tag { get; };

        public jet(int height, int speed, string name)
        {
            maxHeight = height;
            maxSpeed = speed;
            tag = name;
        }

        public int getAnzJetEngines()
        {
            return anzProp;
        }

        public void setJetEngines(int anz)
        {
            anzProp = anz;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var airplanes = new airplane[] {
                new propAirliner (2000, 150, "Starenflieger"),
                new jet (10000, 2500, "F-16 Fighting Falcon")
            };

            foreach (var airp in airplanes)
            {
                Console.WriteLine("Maximale Flughoehe: " + airp.maxHeight + "; Maximale Geschwindigkeit: " + airp.maxSpeed + " km/h; Bezeichnung: " airp.tag);
            }
        }
    }
}