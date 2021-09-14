using System;
using System.Collections.Generic;
using System.Text;

namespace BikeConfigurator
{
    class Bike
    {
        private String model;
        private int viteze;
        private String customer;
        private String culoare;
        
        public Bike(String model, int viteze, String customer, String culoare)
        {
            this.model    = model;
            this.viteze   = viteze;
            this.customer = customer;
            this.culoare  = culoare;
        }

        public Bike()
        {

        }

        public void setModel(String model)
        {
            this.model = model;
        }

        public String getModel()
        {
            return this.model;
        }

        public void setViteze(int viteze)
        {
            this.viteze = viteze;

        }
        public int getViteze()
        {
            return this.viteze;
        }

        public void setCustomer(String customer)
        {
            this.customer = customer;

        }
        public String getCustomer()
        {
            return this.customer;
        }

        public void setCuloare(String culoare)
        {
            this.culoare = culoare;
        }

        public String getCuloare()
        {
            return this.culoare;
        }

        public String Descriere()
        {

            string descriere = "";
            descriere +=  model + ",";
            descriere +=  viteze   + ",";
            descriere +=  customer + ",";
            descriere +=  culoare  + ".";

            return descriere;
        }
        public string Display
        {
            get
            {
                return string.Format($"{model},{viteze},{customer},{culoare}");
            }
        }
     
    }
}
