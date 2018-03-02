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
			this.gbSize = new System.Windows.Forms.GroupBox();
			this.gbType = new System.Windows.Forms.GroupBox();
			this.rbSizeSmall = new System.Windows.Forms.RadioButton();
			this.rbSizeMedium = new System.Windows.Forms.RadioButton();
			this.rbSizeBig = new System.Windows.Forms.RadioButton();
			this.rbTypeHerbi = new System.Windows.Forms.RadioButton();
			this.rbTypeCarni = new System.Windows.Forms.RadioButton();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lblAantal = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.gbSize.SuspendLayout();
			this.gbType.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbSize
			// 
			this.gbSize.Controls.Add(this.rbSizeBig);
			this.gbSize.Controls.Add(this.rbSizeMedium);
			this.gbSize.Controls.Add(this.rbSizeSmall);
			this.gbSize.Location = new System.Drawing.Point(12, 12);
			this.gbSize.Name = "gbSize";
			this.gbSize.Size = new System.Drawing.Size(83, 88);
			this.gbSize.TabIndex = 8;
			this.gbSize.TabStop = false;
			this.gbSize.Text = "Size";
			// 
			// gbType
			// 
			this.gbType.Controls.Add(this.rbTypeCarni);
			this.gbType.Controls.Add(this.rbTypeHerbi);
			this.gbType.Location = new System.Drawing.Point(101, 12);
			this.gbType.Name = "gbType";
			this.gbType.Size = new System.Drawing.Size(83, 88);
			this.gbType.TabIndex = 9;
			this.gbType.TabStop = false;
			this.gbType.Text = "Type";
			// 
			// rbSizeSmall
			// 
			this.rbSizeSmall.AutoSize = true;
			this.rbSizeSmall.Location = new System.Drawing.Point(6, 19);
			this.rbSizeSmall.Name = "rbSizeSmall";
			this.rbSizeSmall.Size = new System.Drawing.Size(50, 17);
			this.rbSizeSmall.TabIndex = 0;
			this.rbSizeSmall.TabStop = true;
			this.rbSizeSmall.Text = "Small";
			this.rbSizeSmall.UseVisualStyleBackColor = true;
			// 
			// rbSizeMedium
			// 
			this.rbSizeMedium.AutoSize = true;
			this.rbSizeMedium.Location = new System.Drawing.Point(6, 42);
			this.rbSizeMedium.Name = "rbSizeMedium";
			this.rbSizeMedium.Size = new System.Drawing.Size(62, 17);
			this.rbSizeMedium.TabIndex = 1;
			this.rbSizeMedium.TabStop = true;
			this.rbSizeMedium.Text = "Medium";
			this.rbSizeMedium.UseVisualStyleBackColor = true;
			// 
			// rbSizeBig
			// 
			this.rbSizeBig.AutoSize = true;
			this.rbSizeBig.Location = new System.Drawing.Point(6, 65);
			this.rbSizeBig.Name = "rbSizeBig";
			this.rbSizeBig.Size = new System.Drawing.Size(40, 17);
			this.rbSizeBig.TabIndex = 2;
			this.rbSizeBig.TabStop = true;
			this.rbSizeBig.Text = "Big";
			this.rbSizeBig.UseVisualStyleBackColor = true;
			// 
			// rbTypeHerbi
			// 
			this.rbTypeHerbi.AutoSize = true;
			this.rbTypeHerbi.Location = new System.Drawing.Point(6, 19);
			this.rbTypeHerbi.Name = "rbTypeHerbi";
			this.rbTypeHerbi.Size = new System.Drawing.Size(71, 17);
			this.rbTypeHerbi.TabIndex = 3;
			this.rbTypeHerbi.TabStop = true;
			this.rbTypeHerbi.Text = "Herbivore";
			this.rbTypeHerbi.UseVisualStyleBackColor = true;
			// 
			// rbTypeCarni
			// 
			this.rbTypeCarni.AutoSize = true;
			this.rbTypeCarni.Location = new System.Drawing.Point(6, 42);
			this.rbTypeCarni.Name = "rbTypeCarni";
			this.rbTypeCarni.Size = new System.Drawing.Size(70, 17);
			this.rbTypeCarni.TabIndex = 4;
			this.rbTypeCarni.TabStop = true;
			this.rbTypeCarni.Text = "Carnivore";
			this.rbTypeCarni.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 106);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(83, 23);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Add animal";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lblAantal
			// 
			this.lblAantal.AutoSize = true;
			this.lblAantal.Location = new System.Drawing.Point(162, 111);
			this.lblAantal.Name = "lblAantal";
			this.lblAantal.Size = new System.Drawing.Size(16, 13);
			this.lblAantal.TabIndex = 11;
			this.lblAantal.Text = "...";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(104, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Wagons:";
			// 
			// Trein
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(198, 137);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblAantal);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.gbType);
			this.Controls.Add(this.gbSize);
			this.Name = "Trein";
			this.Text = "Trein";
			this.gbSize.ResumeLayout(false);
			this.gbSize.PerformLayout();
			this.gbType.ResumeLayout(false);
			this.gbType.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox gbSize;
		private System.Windows.Forms.RadioButton rbSizeBig;
		private System.Windows.Forms.RadioButton rbSizeMedium;
		private System.Windows.Forms.RadioButton rbSizeSmall;
		private System.Windows.Forms.GroupBox gbType;
		private System.Windows.Forms.RadioButton rbTypeCarni;
		private System.Windows.Forms.RadioButton rbTypeHerbi;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lblAantal;
		private System.Windows.Forms.Label label1;
	}
}

