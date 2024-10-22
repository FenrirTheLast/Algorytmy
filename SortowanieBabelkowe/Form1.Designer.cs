namespace SortowanieBabelkowe
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            labelWynik = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(13, 28);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 27);
            button1.TabIndex = 0;
            button1.Text = "Sortuj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelWynik
            // 
            labelWynik.AutoSize = true;
            labelWynik.Location = new Point(14, 58);
            labelWynik.Margin = new Padding(4, 0, 4, 0);
            labelWynik.Name = "labelWynik";
            labelWynik.Size = new Size(0, 15);
            labelWynik.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 355);
            Controls.Add(labelWynik);
            Controls.Add(button1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Sortowanie Bąbelkowe";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button button1; // Deklaracja przycisku
        private System.Windows.Forms.Label labelWynik; // Deklaracja etykiety
    }
}


