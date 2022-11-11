
namespace heteshet
{
	partial class Form1
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
			this.dgwPortfolio = new System.Windows.Forms.DataGridView();
			this.dgwTick = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgwPortfolio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgwTick)).BeginInit();
			this.SuspendLayout();
			// 
			// dgwPortfolio
			// 
			this.dgwPortfolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwPortfolio.Location = new System.Drawing.Point(12, 12);
			this.dgwPortfolio.Name = "dgwPortfolio";
			this.dgwPortfolio.Size = new System.Drawing.Size(369, 302);
			this.dgwPortfolio.TabIndex = 0;
			// 
			// dgwTick
			// 
			this.dgwTick.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwTick.Location = new System.Drawing.Point(387, 12);
			this.dgwTick.Name = "dgwTick";
			this.dgwTick.Size = new System.Drawing.Size(369, 302);
			this.dgwTick.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgwTick);
			this.Controls.Add(this.dgwPortfolio);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgwPortfolio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgwTick)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwPortfolio;
		private System.Windows.Forms.DataGridView dgwTick;
	}
}

