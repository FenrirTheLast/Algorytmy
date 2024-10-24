namespace Algorytmy_Sortowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Sortowanie b¹belkowe
        {
            int[] array_b = { 3, 2, 6, 4, 1, 0, 7, 9, 8, 5};

            MessageBox.Show("Przed sortowaniem: " + TableToString(array_b));
            for (int i = 0; i < array_b.Length; i++)
            {
                for (int j = 0; j < array_b.Length - 1; j++)
                {
                    int temp = 0;
                    if (array_b[j] > array_b[j + 1])
                    {
                        temp = array_b[j + 1];
                        array_b[j + 1] = array_b[j];
                        array_b[j] = temp;
                    }
                }

            }
            MessageBox.Show("Po sortowaniu: " + TableToString(array_b));
        }
        private string TableToString(int[] array)
        {
            string tablica = "";
            for (int i = 0; i < array.Length; i++)
            {
                tablica += array[i].ToString();
                if (i < array.Length - 1)
                {
                    tablica += " ";
                }
            }
            return tablica;
        }

        private void button2_Click(object sender, EventArgs e) // Sortowanie przez stawianie
        {
            int[] array_stw = {56, 36, 11, 20, 33, 76};
            int temp = 0;
            MessageBox.Show("Przed sortowaniem: " + TableToString(array_stw));
            for (int i = 1; i < array_stw.Length; i++)
            {
                int j = i - 1;
                temp = array_stw[i];
                while (j >= 0 && array_stw[j] > temp)
                {
                    array_stw[j + 1] = array_stw[j];
                    j--;
                }
                array_stw[j + 1] = temp;

            }
            MessageBox.Show("Po sortowaniu: " + TableToString(array_stw));
        }

        private void szybsort(int[] array, int p, int k)
        {
            if (p < k)
            {
                int punkt = dziel(array, p, k);
                szybsort(array, p, punkt - 1); // Rekurencja dla lewej czêœci tablicy
                szybsort(array, punkt + 1, k); // Rekurencja dla prawej czêœci tablicy
            }
        }
        private int dziel(int[] array, int p, int k) // Funkcja do dzielenia tablicy
        {
            int pkt = array[k];
            int i = p - 1;

            for (int j = p; j < k; j++)
            {
                if (array[j] <= pkt)
                {
                    i++;

                    int tempa = array[i];
                    array[i] = array[j];
                    array[j] = tempa;
                }
            }
            int temp = array[i + 1];
            array[i + 1] = array[k];
            array[k] = temp;
            return i + 1;
        }


        private void button4_Click(object sender, EventArgs e) // Sortowanie Szybkie
        {
            int[] array_q = { 0, 12, 3, 5, 6, 10, 1, 2 };
            MessageBox.Show("Przed sortowaniem: " + TableToString(array_q));
            szybsort(array_q, 0, array_q.Length - 1);
            MessageBox.Show("Po sortowaniem: " + TableToString(array_q));
        }

        private void button3_Click(object sender, EventArgs e) // Sortowanie przez scalanie
        {
            int[] array_m = { 23, 81, 45, 87, 69, 54, 1, 35, 65 };
            MessageBox.Show("Przed sortowaniem: " + TableToString(array_m));
            array_m = MergeSort(array_m); // Wywo³anie funkcji sortuj¹cej
            MessageBox.Show("Po sortowaniu: " + TableToString(array_m));
        }

        private int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;// Jeœli tablica ma 1 lub mniej elementów, jest ju¿ posortowana
            }

            int mid = array.Length / 2; // Znalezienie œrodka tablicy
            // Dzielenie tablicy na dwie po³owy
            int[] left = array.Take(mid).ToArray();
            int[] right = array.Skip(mid).ToArray();

            left = MergeSort(left);
            right = MergeSort(right);

            // £¹czenie posortowanych po³ówek
            return Merge(left, right);
        }

        private int[] Merge(int[] left, int[] right)
        {
            List<int> result = new List<int>(); // Lista do przechowywania wyników
            int i = 0, j = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }

            // Dodanie pozosta³ych elementów, jeœli któreœ z tablic siê skoñczy³y
            while (i < left.Length)
            {
                result.Add(left[i]);
                i++;
            }

            while (j < right.Length)
            {
                result.Add(right[j]);
                j++;
            }

            return result.ToArray(); // Zwrócenie wynikowej posortowanej tablicy

        }

        private void button5_Click(object sender, EventArgs e) // Sortowanie przez zliczanie
        {
            int[] array_zl = {0, 3, 56, 1, 12, 33};
            MessageBox.Show("Przed sortowaniem: " + TableToString(array_zl));

            int nw_nr = array_zl.Max(); // ZnajdŸ najwiêksz¹ liczbê w tablicy
            int[] licz_t = new int[nw_nr + 1]; // Tablica do zliczania wyst¹pieñ

            // Zliczanie wyst¹pieñ
            for (int i = 0; i < array_zl.Length; i++)
            {
                licz_t[array_zl[i]]++;
            }

            // Tworzenie posortowanej tablicy
            List<int> wynik = new List<int>();
            for (int i = 0; i < licz_t.Length; i++)
            {
                while (licz_t[i] > 0)
                {
                    wynik.Add(i);
                    licz_t[i]--;
                }
            }

            array_zl = wynik.ToArray(); // Przepisz posortowane elementy do tablicy

            MessageBox.Show("Po sortowaniu: " + TableToString(array_zl));
        }
        
    }
}


