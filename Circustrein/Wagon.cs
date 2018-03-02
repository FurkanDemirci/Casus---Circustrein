using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
	public class Wagon
	{
		public List<Animal> Animals { get; set; }
		public int WagonSize { get; set; }

		#region Docent Feedback
		/// Beter manier voor de wagon size als er later toevoegingen komt of je code complexer wordt.
		
		//public int WagonSizeAlt
		//{
		//	get
		//	{
		//		int sum = 0;
		//		foreach (Animal a in Animals)
		//		{
		//			sum += a.AnimalSize;
		//		}
		//
		//		return sum;
		//	}
		//}
		#endregion

		enum Type
		{
			Herbivoor = 0,
			Carnivoor = 1
		}

		public Wagon(Animal animal)
		{
			// When creating a new wagon there must always be an animal to add. Empty wagon is not possible!
			Animals = new List<Animal>();
			Animals.Add(animal);
			WagonSize = WagonSize + animal.AnimalSize;
		}

		// Checks if it's eligible to add the animal to this wagon.
		public bool CheckEligibility(Animal animal)
		{
			// When BOTH CheckSize and CheckCarnivore are true it return true. Only then it's possible to add the animal.
			return CheckSize(animal.AnimalSize) && CheckCarnivore(animal);
		}

		private bool CheckSize(int animalSize)
		{
			// When the size of the wagon is in between 10 or equal to 10 return true.
			return WagonSize + animalSize <= 10;
		}

		private bool CheckCarnivore(Animal animal)
		{
			if (animal.Type == (int) Type.Herbivoor)
			{
				// Checks if there is a carnivore with the same or greater size then the herbivore.
				var checkCarniSize = Animals.Find(x => (x.Type == (int) Type.Carnivoor) && (x.AnimalSize >= animal.AnimalSize));
				// if not return true.
				return checkCarniSize == null;
			}

			// Checks if there is a carnivore.
			var checkCarnivore = Animals.Find(x => x.Type == (int) Type.Carnivoor);
			// Checks if there is a animal smaller or with the same size.
			var checkSmallerAnimal = Animals.Find(x => x.AnimalSize <= animal.AnimalSize);
			// If there is no Carnivore and no smaller or same animal size then return true.
			return (checkCarnivore == null) && checkSmallerAnimal == null;
		}
	}
}
