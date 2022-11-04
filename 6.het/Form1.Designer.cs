namespace _6.het
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
			this.components = new System.ComponentModel.Container();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.createTimer = new System.Windows.Forms.Timer(this.components);
			this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
			this.btCar = new System.Windows.Forms.Button();
			this.btBall = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Location = new System.Drawing.Point(12, 193);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(787, 245);
			this.mainPanel.TabIndex = 0;
			// 
			// createTimer
			// 
			this.createTimer.Enabled = true;
			this.createTimer.Interval = 3000;
			this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick_1);
			// 
			// conveyorTimer
			// 
			this.conveyorTimer.Enabled = true;
			this.conveyorTimer.Interval = 10;
			this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick_1);
			// 
			// btCar
			// 
			this.btCar.Location = new System.Drawing.Point(57, 63);
			this.btCar.Name = "btCar";
			this.btCar.Size = new System.Drawing.Size(75, 23);
			this.btCar.TabIndex = 1;
			this.btCar.Text = "CAR";
			this.btCar.UseVisualStyleBackColor = true;
			this.btCar.Click += new System.EventHandler(this.btCar_Click);
			// 
			// btBall
			// 
			this.btBall.Location = new System.Drawing.Point(148, 63);
			this.btBall.Name = "btBall";
			this.btBall.Size = new System.Drawing.Size(75, 23);
			this.btBall.TabIndex = 2;
			this.btBall.Text = "BALL";
			this.btBall.UseVisualStyleBackColor = true;
			this.btBall.Click += new System.EventHandler(this.btBall_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 121);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Coming next:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btBall);
			this.Controls.Add(this.btCar);
			this.Controls.Add(this.mainPanel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Timer createTimer;
		private System.Windows.Forms.Timer conveyorTimer;
		private System.Windows.Forms.Button btCar;
		private System.Windows.Forms.Button btBall;
		private System.Windows.Forms.Label label1;
	}
}

