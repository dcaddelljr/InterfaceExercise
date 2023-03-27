using System;
namespace InterfaceExercise
{
	public class Car : IVehichle, ICompany
	{
		public Car()
		{
		}
		public bool Trunk { get; set; }
		public string WheelBase { get; set; }
        public string Logo { get ; set ; }
        public object CorpName { get ; set ; }
        public int Wheels { get ; set ; }
        public bool Engine { get ; set ; }
        public bool Motor { get ; set ; }
        public bool Brakes { get ; set ; }
        public int HowManyWheels { get ; set ; }

        public void Horn()
        {
            Console.WriteLine("The car's horn goes beep.");
        }
    }
}

