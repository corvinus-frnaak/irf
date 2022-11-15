namespace _6_het_gyak
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
			this.label1 = new System.Windows.Forms.Label();
			this.btCar = new System.Windows.Forms.Button();
			this.btBall = new System.Windows.Forms.Button();
			this.btBallColor = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Location = new System.Drawing.Point(12, 225);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(776, 139);
			this.mainPanel.TabIndex = 0;
			// 
			// createTimer
			// 
			this.createTimer.Enabled = true;
			this.createTimer.Interval = 3000;
			this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
			// 
			// conveyorTimer
			// 
			this.conveyorTimer.Enabled = true;
			this.conveyorTimer.Interval = 10;
			this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 103);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Coming next";
			// 
			// btCar
			// 
			this.btCar.Location = new System.Drawing.Point(49, 39);
			this.btCar.Name = "btCar";
			this.btCar.Size = new System.Drawing.Size(77, 31);
			this.btCar.TabIndex = 2;
			this.btCar.Text = "CAR";
			this.btCar.UseVisualStyleBackColor = true;
			this.btCar.Click += new System.EventHandler(this.btCar_Click);
			// 
			// btBall
			// 
			this.btBall.Location = new System.Drawing.Point(148, 39);
			this.btBall.Name = "btBall";
			this.btBall.Size = new System.Drawing.Size(77, 31);
			this.btBall.TabIndex = 3;
			this.btBall.Text = "BALL";
			this.btBall.UseVisualStyleBackColor = true;
			this.btBall.Click += new System.EventHandler(this.btBall_Click);
			// 
			// btBallColor
			// 
			this.btBallColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btBallColor.Location = new System.Drawing.Point(241, 39);
			this.btBallColor.Name = "btBallColor";
			this.btBallColor.Size = new System.Drawing.Size(77, 31);
			this.btBallColor.TabIndex = 4;
			this.btBallColor.UseVisualStyleBackColor = false;
			this.btBallColor.Click += new System.EventHandler(this.btBallColor_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btBallColor);
			this.Controls.Add(this.btBall);
			this.Controls.Add(this.btCar);
			this.Controls.Add(this.label1);
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btCar;
		private System.Windows.Forms.Button btBall;
		private System.Windows.Forms.Button btBallColor;
	}
}

