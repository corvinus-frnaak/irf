
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
			this.btSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgwPortfolio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgwTick)).BeginInit();
			this.SuspendLayout();
			// 
			// dgwPortfolio
			// 
			this.dgwPortfolio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgwPortfolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwPortfolio.Location = new System.Drawing.Point(12, 12);
			this.dgwPortfolio.Name = "dgwPortfolio";
			this.dgwPortfolio.Size = new System.Drawing.Size(369, 291);
			this.dgwPortfolio.TabIndex = 0;
			// 
			// dgwTick
			// 
			this.dgwTick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgwTick.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwTick.Location = new System.Drawing.Point(387, 12);
			this.dgwTick.Name = "dgwTick";
			this.dgwTick.Size = new System.Drawing.Size(369, 291);
			this.dgwTick.TabIndex = 1;
			// 
			// btSave
			// 
			this.btSave.Location = new System.Drawing.Point(12, 331);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(118, 42);
			this.btSave.TabIndex = 2;
			this.btSave.Text = "Mentés";
			this.btSave.UseVisualStyleBackColor = true;
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 439);
			this.Controls.Add(this.btSave);
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
		private System.Windows.Forms.Button btSave;
	}
}

