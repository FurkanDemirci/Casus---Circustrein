using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Tests
{
	[TestClass()]
	public class TrainTests
	{
		private Animal animal;
		private List<Animal> animals;

		private enum Size
		{
			Small = 1,
			Medium = 3,
			Big = 5
		}

		private enum Type
		{
			Herbivore = 0,
			Carnivore = 1
		}

		[TestInitialize]
		public void TestInitialize()
		{
			animals = new List<Animal>();
		}

		[TestMethod()]
		public void AddOneAnimal()
		{
			var train = new Train();
			animal = new Animal((int) Size.Small, (int) Type.Herbivore);
			train.AddAnimal(animal);

			Assert.AreEqual(1, train.Wagons.Count);
		}

		[TestMethod()]
		public void AddMoreAnimals()
		{
			var train = new Train();
			animals.Add(animal = new Animal((int)Size.Big, (int)Type.Herbivore));
			animals.Add(animal = new Animal((int)Size.Medium, (int)Type.Herbivore));
			animals.Add(animal = new Animal((int)Size.Small, (int)Type.Herbivore));
			animals.Add(animal = new Animal((int)Size.Big, (int)Type.Carnivore));
			animals.Add(animal = new Animal((int)Size.Medium, (int)Type.Carnivore));
			animals.Add(animal = new Animal((int)Size.Small, (int)Type.Carnivore));

			foreach (var animal in animals)
			{
				train.AddAnimal(animal);
			}
			Assert.AreEqual(4, train.Wagons.Count);
		}
	}
}