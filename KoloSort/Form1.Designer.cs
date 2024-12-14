namespace KoloSort
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
            txtArray = new TextBox();
            lblResult = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(65, 28);
            button1.Name = "button1";
            button1.Size = new Size(650, 41);
            button1.TabIndex = 0;
            button1.Text = "Bąbelkowe";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(65, 75);
            button2.Name = "button2";
            button2.Size = new Size(650, 42);
            button2.TabIndex = 1;
            button2.Text = "Przez Wstawianie";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(65, 132);
            button3.Name = "button3";
            button3.Size = new Size(650, 52);
            button3.TabIndex = 2;
            button3.Text = "Przez Scalanie";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(65, 196);
            button4.Name = "button4";
            button4.Size = new Size(650, 67);
            button4.TabIndex = 3;
            button4.Text = "Szybkie Sortowanie";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(65, 283);
            button5.Name = "button5";
            button5.Size = new Size(650, 64);
            button5.TabIndex = 4;
            button5.Text = "Przez Zliczanie";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txtArray
            // 
            txtArray.Location = new Point(174, 353);
            txtArray.Name = "txtArray";
            txtArray.Size = new Size(411, 23);
            txtArray.TabIndex = 5;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(366, 395);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(txtArray);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox txtArray;
        private Label lblResult;
    }
}
