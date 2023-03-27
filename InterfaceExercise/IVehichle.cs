using System;
namespace InterfaceExercise
{
	public interface IVehichle
	{
		public int HowManyWheels { get; set; }
		public bool Engine { get; set; }
		public bool Motor { get; set; }
		public bool Brakes { get; set; }

		public void Horn();
    }
	
}

