using System;
using System.Windows.Forms;

namespace SortowanieBabelkowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] liczby = { 5, 23, 7, 12, 45, 89, 45 }; // Przyk³adowa tablica do posortowania
            SortujBabelkowo(liczby);
            labelWynik.Text = string.Join(", ", liczby); // Wyœwietl posortowan¹ tablicê
        }

        private void SortujBabelkowo(int[] tablica)
        {
            int n = tablica.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        // Zamieñ miejscami
                        int temp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = temp;
                    }
                }
            }
        }
    }
}

