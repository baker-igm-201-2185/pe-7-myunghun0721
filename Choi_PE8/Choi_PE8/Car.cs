using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choi_PE8
{
    class Car
    {
        public int year;
        public string make;
        public string model;
        public float gasLevel;

        public Car()
        {
            year = 2000;
            make = "Ford";
            model = "car";
            gasLevel = 20;
        }
        public Car(int year, string make, string model)
        {
            if(year > 2000 && year < 2019)
            {
                this.year = year;
            }
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
