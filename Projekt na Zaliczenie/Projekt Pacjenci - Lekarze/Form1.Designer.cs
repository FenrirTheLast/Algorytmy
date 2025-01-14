namespace Projekt_Pacjenci___Lekarze
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
            button5 = new Button();
            button6 = new Button();
            txtImiePacjenta = new TextBox();
            txtNazwiskoPacjenta = new TextBox();
            lstPacjenci = new ListBox();
            lstLekarzePacjenci = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbChoroby = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(10, 103);
            button1.Name = "button1";
            button1.Size = new Size(117, 38);
            button1.TabIndex = 0;
            button1.Text = "Dodaj Pacjenta";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(226, 10);
            button2.Name = "button2";
            button2.Size = new Size(113, 47);
            button2.TabIndex = 1;
            button2.Text = "Pokaż Pacjentów";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(363, 10);
            button3.Name = "button3";
            button3.Size = new Size(113, 47);
            button3.TabIndex = 2;
            button3.Text = "Sortuj Pacjentów według Nazwiska";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.IndianRed;
            button5.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(10, 247);
            button5.Name = "button5";
            button5.Size = new Size(117, 69);
            button5.TabIndex = 11;
            button5.Text = "Przypisz Pacjentów do Lekarzy";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.IndianRed;
            button6.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(10, 338);
            button6.Name = "button6";
            button6.Size = new Size(117, 91);
            button6.TabIndex = 12;
            button6.Text = "Pokaż Lekarzy i przypisanych do nich Pacjentów";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // txtImiePacjenta
            // 
            txtImiePacjenta.ForeColor = SystemColors.WindowText;
            txtImiePacjenta.Location = new Point(79, 10);
            txtImiePacjenta.Name = "txtImiePacjenta";
            txtImiePacjenta.Size = new Size(125, 23);
            txtImiePacjenta.TabIndex = 4;
            // 
            // txtNazwiskoPacjenta
            // 
            txtNazwiskoPacjenta.ForeColor = SystemColors.WindowText;
            txtNazwiskoPacjenta.Location = new Point(79, 39);
            txtNazwiskoPacjenta.Name = "txtNazwiskoPacjenta";
            txtNazwiskoPacjenta.Size = new Size(125, 23);
            txtNazwiskoPacjenta.TabIndex = 5;
            // 
            // lstPacjenci
            // 
            lstPacjenci.ItemHeight = 15;
            lstPacjenci.Location = new Point(135, 103);
            lstPacjenci.Name = "lstPacjenci";
            lstPacjenci.Size = new Size(352, 379);
            lstPacjenci.TabIndex = 13;
            // 
            // lstLekarzePacjenci
            // 
            lstLekarzePacjenci.FormattingEnabled = true;
            lstLekarzePacjenci.ItemHeight = 15;
            lstLekarzePacjenci.Location = new Point(493, 10);
            lstLekarzePacjenci.Name = "lstLekarzePacjenci";
            lstLekarzePacjenci.Size = new Size(419, 469);
            lstLekarzePacjenci.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 14;
            label1.Text = "Imie:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 42);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 15;
            label2.Text = "Nazwisko:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 71);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 16;
            label3.Text = "Choroba: ";
            // 
            // cmbChoroby
            // 
            cmbChoroby.BackColor = SystemColors.Window;
            cmbChoroby.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbChoroby.FormattingEnabled = true;
            cmbChoroby.Location = new Point(79, 68);
            cmbChoroby.Name = "cmbChoroby";
            cmbChoroby.Size = new Size(397, 23);
            cmbChoroby.TabIndex = 20;
            // 
            // Form1
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(924, 504);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(lstLekarzePacjenci);
            Controls.Add(lstPacjenci);
            Controls.Add(txtNazwiskoPacjenta);
            Controls.Add(txtImiePacjenta);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbChoroby);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Program Pacjenci-Lekarze";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbChoroby;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtImiePacjenta;
        private TextBox txtNazwiskoPacjenta;
        private ListBox lstPacjenci;
        private ListBox lstLekarzePacjenci;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}