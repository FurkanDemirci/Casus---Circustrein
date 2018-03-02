using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
	public class Animal
	{
		public int AnimalSize { get; }
		public int Type { get; }

		public Animal(int size, int type)
		{
			AnimalSize = size;
			Type = type;
		}
	}
}
