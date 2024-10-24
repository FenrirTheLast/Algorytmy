namespace Algorytmy_Sortowanie
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(80, 84);
            button1.Name = "button1";
            button1.Size = new Size(647, 53);
            button1.TabIndex = 0;
            button1.Text = "BĄBELKOWE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Coral;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(80, 143);
            button2.Name = "button2";
            button2.Size = new Size(647, 47);
            button2.TabIndex = 1;
            button2.Text = "WSTAWIANIE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.ForeColor = Color.Cornsilk;
            button3.Location = new Point(80, 196);
            button3.Name = "button3";
            button3.Size = new Size(647, 50);
            button3.TabIndex = 2;
            button3.Text = "SCALANIE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkCyan;
            button4.ForeColor = Color.Cornsilk;
            button4.Location = new Point(80, 252);
            button4.Name = "button4";
            button4.Size = new Size(647, 50);
            button4.TabIndex = 5;
            button4.Text = "SZYBKIE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkMagenta;
            button5.ForeColor = Color.Cornsilk;
            button5.Location = new Point(80, 308);
            button5.Name = "button5";
            button5.Size = new Size(647, 47);
            button5.TabIndex = 0;
            button5.Text = "ZLICZANIE";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Algorytmy Sortowanie";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
