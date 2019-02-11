using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choi_PE8
{
    class Program
    {
        static void Main(string[] args)
        {   // only declares
            Car myCar;
            // only init
            myCar = new Car(2018, "Kia", "Optima");
            myCar.Year = 2018;
            //myCar.year = 2018;
            //myCar.make = "Kia";
            //myCar.model = "Optima";

            Car yourCar = new Car();

            //myCar.year = 2019;
            //int myMoney = 1000000;

            //Console.WriteLine(myCar.make);
            //Console.WriteLine(myMoney / myCar.make);

            if(myCar.CheckGas() > 0)
            {
                myCar.Drive();
            }
            
        }
    }
}
