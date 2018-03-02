using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein
{
	public partial class Trein : Form
	{
		private Train train;
		private Animal animal;

		public Trein()
		{
			InitializeComponent();
			train = new Train();

			rbSizeSmall.Checked = true;
			rbTypeHerbi.Checked = true;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var size = 0;
			var type = 0;

			if (rbSizeSmall.Checked)
			{
				size = 1;
			}
			else if (rbSizeMedium.Checked)
			{
				size = 3;
			}
			else
			{
				size = 5;
			}

			if (rbTypeHerbi.Checked)
			{
				type = 0;
			}
			else
			{
				type = 1;
			}

			// Create new Animal
			animal = new Animal(size, type);
			// Add Animal on train
			train.AddAnimal(animal);

			lblAantal.Text = train.Wagons.Count.ToString();
		}
	}
}
