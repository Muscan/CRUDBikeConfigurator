using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BikeConfigurator
{
    class BikeController
    {
        private List<Bike> bikes;
        
        public BikeController()
        {
            bikes = new List<Bike>();
            ReadFromFile();
        }

        public void setBikeList(List<Bike> bikes)
        {
            this.bikes = bikes;
        }

        public List<Bike> getBikeList()
        {
            return this.bikes;
        }

        //citire fisier stream reader
        public void ReadFromFile()
        {
            StreamReader streamReader = new StreamReader(@"../../../Files/Bikes.txt");
            String readLines = "";
            readLines = streamReader.ReadLine();
            while (readLines != null)
            {//(String Model, int Viteze, String Customer, String Culoare)
                string[] splitInCuvinte = readLines.Split(',','.');
                
                string model = splitInCuvinte[0];
                int viteze = int.Parse(splitInCuvinte[1]);
                string customer = splitInCuvinte[2];
                string culoare = splitInCuvinte[3];
                Bike bike = new Bike(model, viteze, customer, culoare);
                bikes.Add(bike);
                readLines = streamReader.ReadLine();

            }
            streamReader.Close();

        }

        public void WriteToFile()
        {
            StreamWriter streamWriter = new StreamWriter(@"../../../Files/Bikes.txt");

            for (int i = 0; i < bikes.Count; i++)
            {
                
                streamWriter.WriteLine(bikes[i].Descriere());

            }
            streamWriter.Flush();
            streamWriter.Close();

        }

        public void Add(Bike bike)
        {
            bikes.Add(bike);
        }

        public int NrItems()
        {
            return bikes.Count;
        }
       

    }
}
