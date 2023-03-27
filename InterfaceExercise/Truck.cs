using System;
namespace InterfaceExercise
{
	public class Truck : IVehichle, ICompany
	{
		public Truck()
		{
		}
		public bool OpenCargo { get; set; }
		public string HighGroundClear { get; set; }
        public int Wheels { get ; set ; }
        public bool Engine { get ; set ; }
        public bool Motor { get ; set ; }
        public bool Brakes { get ; set ; }
        public string Logo { get ; set ; }
        public object CorpName { get ; set ; }
        public int HowManyWheels { get ; set ; }

        public void Horn()
        {
            throw new NotImplementedException();
        }
    }
}

