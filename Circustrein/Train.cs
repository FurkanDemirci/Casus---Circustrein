using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
	public class Train
	{
		public List<Wagon> Wagons { get; set; }

		public Train()
		{
			Wagons = new List<Wagon>();
		}

		// Adding animal on train
		public void AddAnimal(Animal animal)
		{
			var newWagon = true;
			foreach (var wagon in Wagons)
			{
				// When CheckEligibility is true continue with the code, add animal, add size and break.
				if (!wagon.CheckEligibility(animal)) continue;
				wagon.Animals.Add(animal);
				wagon.WagonSize = wagon.WagonSize + animal.AnimalSize;
				// Set newWagon to false so it doesn't create a new wagon.
				newWagon = false;
				break;
			}

			// When there is no eligible wagon create new wagon with the animal.
			if (newWagon)
			{
				var wagon = new Wagon(animal);
				Wagons.Add(wagon);
			}
		}
	}
}
