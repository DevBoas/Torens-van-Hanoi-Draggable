using System.Windows.Forms;

namespace Torens_van_Hanoi_2
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
            this.Counter = new System.Windows.Forms.Label();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Ring_1 = new System.Windows.Forms.PictureBox();
            this.Ring_2 = new System.Windows.Forms.PictureBox();
            this.Ring_3 = new System.Windows.Forms.PictureBox();
            this.Ring_7 = new System.Windows.Forms.PictureBox();
            this.Ring_6 = new System.Windows.Forms.PictureBox();
            this.Ring_5 = new System.Windows.Forms.PictureBox();
            this.Ring_4 = new System.Windows.Forms.PictureBox();
            this.Ring_8 = new System.Windows.Forms.PictureBox();
            this.Pole_2 = new System.Windows.Forms.PictureBox();
            this.Pole_1 = new System.Windows.Forms.PictureBox();
            this.Pole_3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ring_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pole_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pole_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pole_3)).BeginInit();
            this.SuspendLayout();
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Counter.Location = new System.Drawing.Point(20, 24);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(86, 24);
            this.Counter.TabIndex = 11;
            this.Counter.Text = "Moves: 0";
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Location = new System.Drawing.Point(23, 51);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.Btn_Reset.TabIndex = 12;
            this.Btn_Reset.Text = "Reset";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Ring_1
            // 
            this.Ring_1.Image = global::Torens_van_Hanoi_2.Properties.Resources.Ring1;
            this.Ring_1.Location = new System.Drawing.Point(23, 85);
            this.Ring_1.Name = "Ring_1";
            this.Ring_1.Size = new System.Drawing.Size(20, 10);
            this.Ring_1.TabIndex = 8;
            this.Ring_1.TabStop = false;
            this.Ring_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseDown);
            this.Ring_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseMove);
            this.Ring_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseUp);
            // 
            // Ring_2
            // 
            this.Ring_2.Image = global::Torens_van_Hanoi_2.Properties.Resources.Ring2;
            this.Ring_2.Location = new System.Drawing.Point(23, 101);
            this.Ring_2.Name = "Ring_2";
            this.Ring_2.Size = new System.Drawing.Size(40, 10);
            this.Ring_2.TabIndex = 7;
            this.Ring_2.TabStop = false;
            this.Ring_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseDown);
            this.Ring_2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseMove);
            this.Ring_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseUp);
            // 
            // Ring_3
            // 
            this.Ring_3.Image = global::Torens_van_Hanoi_2.Properties.Resources.Ring3;
            this.Ring_3.Location = new System.Drawing.Point(23, 117);
            this.Ring_3.Name = "Ring_3";
            this.Ring_3.Size = new System.Drawing.Size(60, 10);
            this.Ring_3.TabIndex = 6;
            this.Ring_3.TabStop = false;
            this.Ring_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseDown);
            this.Ring_3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseMove);
            this.Ring_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseUp);
            // 
            // Ring_7
            // 
            this.Ring_7.Image = global::Torens_van_Hanoi_2.Properties.Resources.Ring7;
            this.Ring_7.Location = new System.Drawing.Point(23, 181);
            this.Ring_7.Name = "Ring_7";
            this.Ring_7.Size = new System.Drawing.Size(140, 10);
            this.Ring_7.TabIndex = 1;
            this.Ring_7.TabStop = false;
            this.Ring_7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseDown);
            this.Ring_7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseMove);
            this.Ring_7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseUp);
            // 
            // Ring_6
            // 
            this.Ring_6.Image = global::Torens_van_Hanoi_2.Properties.Resources.Ring6;
            this.Ring_6.Location = new System.Drawing.Point(23, 165);
            this.Ring_6.Name = "Ring_6";
            this.Ring_6.Size = new System.Drawing.Size(120, 10);
            this.Ring_6.TabIndex = 3;
            this.Ring_6.TabStop = false;
            this.Ring_6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseDown);
            this.Ring_6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseMove);
            this.Ring_6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseUp);
            // 
            // Ring_5
            // 
            this.Ring_5.Image = global::Torens_van_Hanoi_2.Properties.Resources.Ring5;
            this.Ring_5.Location = new System.Drawing.Point(23, 149);
            this.Ring_5.Name = "Ring_5";
            this.Ring_5.Size = new System.Drawing.Size(100, 10);
            this.Ring_5.TabIndex = 4;
            this.Ring_5.TabStop = false;
            this.Ring_5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseDown);
            this.Ring_5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseMove);
            this.Ring_5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseUp);
            // 
            // Ring_4
            // 
            this.Ring_4.Image = global::Torens_van_Hanoi_2.Properties.Resources.Ring4;
            this.Ring_4.Location = new System.Drawing.Point(23, 133);
            this.Ring_4.Name = "Ring_4";
            this.Ring_4.Size = new System.Drawing.Size(80, 10);
            this.Ring_4.TabIndex = 5;
            this.Ring_4.TabStop = false;
            this.Ring_4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseDown);
            this.Ring_4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseMove);
            this.Ring_4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseUp);
            // 
            // Ring_8
            // 
            this.Ring_8.Image = global::Torens_van_Hanoi_2.Properties.Resources.Ring8;
            this.Ring_8.Location = new System.Drawing.Point(23, 197);
            this.Ring_8.Name = "Ring_8";
            this.Ring_8.Size = new System.Drawing.Size(160, 10);
            this.Ring_8.TabIndex = 2;
            this.Ring_8.TabStop = false;
            this.Ring_8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseDown);
            this.Ring_8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseMove);
            this.Ring_8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Ring_MouseUp);
            // 
            // Pole_2
            // 
            this.Pole_2.Image = global::Torens_van_Hanoi_2.Properties.Resources.Pole;
            this.Pole_2.Location = new System.Drawing.Point(341, 181);
            this.Pole_2.Name = "Pole_2";
            this.Pole_2.Size = new System.Drawing.Size(10, 110);
            this.Pole_2.TabIndex = 9;
            this.Pole_2.TabStop = false;
            // 
            // Pole_1
            // 
            this.Pole_1.Image = global::Torens_van_Hanoi_2.Properties.Resources.Pole;
            this.Pole_1.Location = new System.Drawing.Point(91, 181);
            this.Pole_1.Name = "Pole_1";
            this.Pole_1.Size = new System.Drawing.Size(10, 110);
            this.Pole_1.TabIndex = 0;
            this.Pole_1.TabStop = false;
            // 
            // Pole_3
            // 
            this.Pole_3.Image = global::Torens_van_Hanoi_2.Properties.Resources.Pole;
            this.Pole_3.Location = new System.Drawing.Point(591, 181);
            this.Pole_3.Name = "Pole_3";
            this.Pole_3.Size = new System.Drawing.Size(10, 110);
            this.Pole_3.TabIndex = 10;
            this.Pole_3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 292);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.Ring_1);
            this.Controls.Add(this.Ring_2);
            this.Controls.Add(this.Ring_3);
            this.Controls.Add(this.Ring_7);
            this.Controls.Add(this.Ring_6);
            this.Controls.Add(this.Ring_5);
            this.Controls.Add(this.Ring_4);
            this.Controls.Add(this.Ring_8);
            this.Controls.Add(this.Pole_2);
            this.Controls.Add(this.Pole_1);
            this.Controls.Add(this.Pole_3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(758, 331);
            this.MinimumSize = new System.Drawing.Size(758, 331);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Torens van Hanoi 2";
            ((System.ComponentModel.ISupportInitialize)(this.Ring_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pole_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pole_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pole_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pole_1;
        private System.Windows.Forms.PictureBox Ring_7;
        private System.Windows.Forms.PictureBox Ring_8;
        private System.Windows.Forms.PictureBox Ring_6;
        private System.Windows.Forms.PictureBox Ring_5;
        private System.Windows.Forms.PictureBox Ring_4;
        private System.Windows.Forms.PictureBox Ring_3;
        private System.Windows.Forms.PictureBox Ring_2;
        private System.Windows.Forms.PictureBox Ring_1;
        private System.Windows.Forms.PictureBox Pole_2;
        private System.Windows.Forms.PictureBox Pole_3;
        private Label Counter;
        private Button Btn_Reset;
    }
}

