namespace Circustrein
{
	partial class Trein
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbAnimal = new System.Windows.Forms.ListBox();
			this.lbWagon = new System.Windows.Forms.ListBox();
			this.cbSize = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnHerbivoor = new System.Windows.Forms.Button();
			this.btnCarnivoor = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbAnimal
			// 
			this.lbAnimal.FormattingEnabled = true;
			this.lbAnimal.Location = new System.Drawing.Point(534, 25);
			this.lbAnimal.Name = "lbAnimal";
			this.lbAnimal.Size = new System.Drawing.Size(227, 186);
			this.lbAnimal.TabIndex = 0;
			// 
			// lbWagon
			// 
			this.lbWagon.FormattingEnabled = true;
			this.lbWagon.Location = new System.Drawing.Point(301, 25);
			this.lbWagon.Name = "lbWagon";
			this.lbWagon.Size = new System.Drawing.Size(227, 186);
			this.lbWagon.TabIndex = 1;
			// 
			// cbSize
			// 
			this.cbSize.FormattingEnabled = true;
			this.cbSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Big"});
			this.cbSize.Location = new System.Drawing.Point(15, 25);
			this.cbSize.Name = "cbSize";
			this.cbSize.Size = new System.Drawing.Size(121, 21);
			this.cbSize.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Size";
			// 
			// btnHerbivoor
			// 
			this.btnHerbivoor.Location = new System.Drawing.Point(15, 77);
			this.btnHerbivoor.Name = "btnHerbivoor";
			this.btnHerbivoor.Size = new System.Drawing.Size(121, 23);
			this.btnHerbivoor.TabIndex = 4;
			this.btnHerbivoor.Text = "Add herbivoor";
			this.btnHerbivoor.UseVisualStyleBackColor = true;
			// 
			// btnCarnivoor
			// 
			this.btnCarnivoor.Location = new System.Drawing.Point(15, 106);
			this.btnCarnivoor.Name = "btnCarnivoor";
			this.btnCarnivoor.Size = new System.Drawing.Size(121, 23);
			this.btnCarnivoor.TabIndex = 5;
			this.btnCarnivoor.Text = "Add carnivoor";
			this.btnCarnivoor.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(298, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Wagon";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(531, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Animals";
			// 
			// Trein
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 224);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCarnivoor);
			this.Controls.Add(this.btnHerbivoor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbSize);
			this.Controls.Add(this.lbWagon);
			this.Controls.Add(this.lbAnimal);
			this.Name = "Trein";
			this.Text = "Trein";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbAnimal;
		private System.Windows.Forms.ListBox lbWagon;
		private System.Windows.Forms.ComboBox cbSize;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnHerbivoor;
		private System.Windows.Forms.Button btnCarnivoor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}

