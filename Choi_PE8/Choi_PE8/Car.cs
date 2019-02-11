using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choi_PE8
{
    class Car
    {
        private int year;
        public string make;
        public string model;
        public float gasLevel;

        public int Year
        {
            get
            {
                return year;

            }
            //private set
            set
            {
                if(value > 2000 && value < 2019)
                {
                    year = value;
                }
            }
        }
        /*  both doing same work
        string make;

        public string Make
        {
            get; set;
        }

        string model;
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        */
        public Car()
        {
            Year = 2000;
            make = "Ford";
            model = "car";
            gasLevel = 20;
        }
        public Car(int year, string make, string model)
        {
            Year = year;
            this.make = make;
            this.model = model;
        }
        public void Drive()
        {
            Console.WriteLine("Lets Go!");
            gasLevel -= 1;
        }
        public float CheckGas()
        {
            return gasLevel;
        }
        public void FillUp(float amount)
        {
            gasLevel += amount;
        }
    }
}
