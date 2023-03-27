using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            Create 2 Interfaces called IVehicle & ICompany

            Create 3 classes called Car , Truck , &SUV

            In your IVehicle*/

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            /*In ICompany

            Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            /*In each of your car, truck, and suv classes

             Create 2 members that are specific to each class
              * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
              *
              * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
              * 
              /*

            Now, create objects of your 3 classes and give their members values;
            Creatively display and organize their values*/
            var vehicles = new List<IVehichle>();
            var car1 = new Car()
            {
                Trunk = true,
                WheelBase = "yes",
                Logo = "Blue Ford",
                CorpName = "Ford Motor",
                Wheels = 4,
                Engine = true,
                Motor = true,
                Brakes = true,
                HowManyWheels = 4
            };

            var truck1 = new Truck()
            {
                OpenCargo = true,
                HighGroundClear = "high",
                Wheels = 4,
                Engine = true,
                Motor = true,
                Brakes = true,
                Logo = "Ram head",
                CorpName = "Ram",
                HowManyWheels = 4,
            };

            var suv1 = new SUV()
            {
                ExtraSeating = "yes",
                RearHatch = true,
                Logo = "Oval with stars",
                CorpName = "Subaru",
                Wheels = 4,
                Engine = true,
                Motor = true,
                Brakes = true,
                HowManyWheels = 4,
            };

            vehicles.Add(car1);
            vehicles.Add(truck1);
            vehicles.Add(suv1);

            foreach(var veh in vehicles)
            {
                Console.WriteLine($"Does is have wheels? {veh.HowManyWheels}, " +
                    $"Is there an engine? {veh.HowManyWheels}, " +
                    $"Does it have brakes? {veh.Brakes}");
            }
        }
    }
}
