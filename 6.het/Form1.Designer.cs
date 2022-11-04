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
			this.button1 = new System.Windows.Forms.Button();
			this.btPresent = new System.Windows.Forms.Button();
			this.btBoxColor = new System.Windows.Forms.Button();
			this.btRibbonColor = new System.Windows.Forms.Button();
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
			this.btCar.Location = new System.Drawing.Point(10, 12);
			this.btCar.Name = "btCar";
			this.btCar.Size = new System.Drawing.Size(75, 23);
			this.btCar.TabIndex = 1;
			this.btCar.Text = "CAR";
			this.btCar.UseVisualStyleBackColor = true;
			this.btCar.Click += new System.EventHandler(this.btCar_Click);
			// 
			// btBall
			// 
			this.btBall.Location = new System.Drawing.Point(101, 12);
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
			this.label1.Location = new System.Drawing.Point(12, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Coming next:";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Location = new System.Drawing.Point(319, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Color";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btPresent
			// 
			this.btPresent.Location = new System.Drawing.Point(194, 12);
			this.btPresent.Name = "btPresent";
			this.btPresent.Size = new System.Drawing.Size(83, 23);
			this.btPresent.TabIndex = 5;
			this.btPresent.Text = "PRESENT";
			this.btPresent.UseVisualStyleBackColor = true;
			this.btPresent.Click += new System.EventHandler(this.btPresent_Click);
			// 
			// btBoxColor
			// 
			this.btBoxColor.Location = new System.Drawing.Point(194, 44);
			this.btBoxColor.Name = "btBoxColor";
			this.btBoxColor.Size = new System.Drawing.Size(117, 23);
			this.btBoxColor.TabIndex = 6;
			this.btBoxColor.Text = "BOX COLOR";
			this.btBoxColor.UseVisualStyleBackColor = true;
			// 
			// btRibbonColor
			// 
			this.btRibbonColor.Location = new System.Drawing.Point(194, 73);
			this.btRibbonColor.Name = "btRibbonColor";
			this.btRibbonColor.Size = new System.Drawing.Size(117, 23);
			this.btRibbonColor.TabIndex = 7;
			this.btRibbonColor.Text = "RIBBON COLOR";
			this.btRibbonColor.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(803, 447);
			this.Controls.Add(this.btRibbonColor);
			this.Controls.Add(this.btBoxColor);
			this.Controls.Add(this.btPresent);
			this.Controls.Add(this.button1);
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
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btPresent;
		private System.Windows.Forms.Button btBoxColor;
		private System.Windows.Forms.Button btRibbonColor;
	}
}

