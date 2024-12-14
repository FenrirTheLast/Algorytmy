using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace KoloSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int[] GenerujLosoweLiczby(int size, int minValue, int maxValue)
        {
            Random randowm = new Random();
            int[] array = new int[size];
            for(int i = 0; i < size; i++)
            {
                array[i] = randowm.Next(minValue, maxValue + 1);
            }
            return array;
        }

        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        static void InsertionSort(int[] array)
        {
            int n = array.Length;
            for(int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;

                while(j >=0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j+1] = key;
            }
        }

        static void MergeSort(int[] array, int left, int right)
        {
            if(left< right)
            {
                int middle = (left + right) / 2;
                MergeSort(array, left, middle);
                MergeSort(array, middle+1, right);

                Merge(array, left, middle, right);
            }
        }

        static void Merge(int[] array, int left, int middle, int rigth)
        {
            int n1 = middle - left + 1;
            int n2 = rigth - middle;
            int[] LeftArray = new int[n1];
            int[] RightArray = new int[n2];

            for(int i = 0; i < n1; i++)
                LeftArray[i] = array[left + i];
            for (int j = 0; j < n2; j++)
                RightArray[j] = array[middle + 1 + j];

            int i1 = 0, j1 = 0;
            int k = left;

            while(i1 < n1 && j1 < n2)
            {
                if (LeftArray[i1] <= RightArray[j1])
                {
                    array[k] = LeftArray[i1];
                    i1++;
                }
                else
                {
                    array[k] = RightArray[j1];
                    j1++;
                }
                k++;
            }
            while(i1 < n1)
            {
                array[k] = LeftArray[i1];
                i1++;
                k++;
            }
            while(j1 < n2)
            {
                array[k] = RightArray[j1];
                j1++;
                k++;
            }
        }

        static void QuickSort(int[] array, int low, int high)
        {
            if(low< high)
            {
                int pi = Partition(array, low, high);
                QuickSort(array, low, pi-1);
                QuickSort(array, pi + 1, high);
            }
        }

        static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);
            for(int j = low; j < high;j++)
            {
                if (array[j]<= pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            int temp1= array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }
        
        static void CountingSort(int[] array)
        {
            int max = array.Max();
            int[] count = new int[max +1];
            for(int i = 0; i < array.Length; i++)
                count[array[i]]++;

            int index = 0;
            for(int i = 0; i < count.Length; i++)
            {
                while (count[i] > 0)
                {
                    array[index++] = i;
                    count[i]--;
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e) // Sortowanie B¹belkowe
        {
            int[] array = GenerujLosoweLiczby(10, 1, 100);
            txtArray.Text = string.Join(", ",array);

            BubbleSort(array);
            lblResult.Text ="Po Sortowaniu B¹belkowym: "+ string.Join(", ",array);
        }

        private void button2_Click(object sender, EventArgs e) // Sortowanie Przez Wstawianie
        {
            int[] array = GenerujLosoweLiczby(10, 1, 100);
            txtArray.Text = string.Join(", ",array);

            InsertionSort(array);
            lblResult.Text = "Po Sortowaniu Przez Wstawianie: " + string.Join(", ", array);
        }

        private void button3_Click(object sender, EventArgs e) // Sortowanie Przez Scalanie
        {
            int[] array = GenerujLosoweLiczby(10,1,100);
            txtArray.Text = string.Join(", ",array);

            MergeSort(array, 0, array.Length - 1);
            lblResult.Text = "Po Sortowaniu Przez Scalanie: " + string.Join(", ", array);
        }

        private void button4_Click(object sender, EventArgs e) // Szybkie Sortowanie
        {
            int[] array = GenerujLosoweLiczby(10, 1, 100);
            txtArray.Text = string.Join(", ", array);

            QuickSort(array, 0, array.Length - 1);
            lblResult.Text = "Po Szybkim Sortowaniu: " + string.Join(", ", array);
        }

        private void button5_Click(object sender, EventArgs e) // Sortowanie Przez Zlicznie
        {
            int[] array = GenerujLosoweLiczby(10, 1, 100);
            txtArray.Text = string.Join(", ", array);

            CountingSort(array);
            lblResult.Text = "Po Sortowaniu Przez Zliczanie: " + string.Join("; ", array);
        }
    }
}
