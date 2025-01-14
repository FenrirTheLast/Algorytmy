namespace Projekt_Pacjenci___Lekarze
{
    public partial class Form1 : Form
    {
        private List<Pacjent> pacjenci = new List<Pacjent>();
        private List<Lekarz> lekarze = new List<Lekarz>();
        public Form1()
        {
            InitializeComponent();
            cmbChoroby.Items.Add(" ");
            cmbChoroby.Items.Add("Depresja");
            cmbChoroby.Items.Add("Padaczka");
            cmbChoroby.Items.Add("Parkinson");
            cmbChoroby.Items.Add("Udar m�zgu");
            cmbChoroby.Items.Add("Padaczka objawowa");
            cmbChoroby.Items.Add("Napady ogniskowe");
            cmbChoroby.Items.Add("Zesp� Westa");
            cmbChoroby.Items.Add("Omdlenia");
            cmbChoroby.Items.Add("Zaburzenia snu");
            cmbChoroby.Items.Add("Alzheimer");
            cmbChoroby.Items.Add("Stwardnienie Rozsiane");
            cmbChoroby.Items.Add("Zapalenie m�zgu");
            cmbChoroby.Items.Add("Zapalenie rdzenia kr�gowego");
            cmbChoroby.Items.Add("T�tniak m�zgu");
            cmbChoroby.Items.Add("Migrena");
            cmbChoroby.Items.Add("B�l g�owy");
            cmbChoroby.Items.Add("Glejak");
            cmbChoroby.Items.Add("Kamica nerkowa");
            cmbChoroby.Items.Add("Torbielowato�� nerek");
            cmbChoroby.Items.Add("Nefropatia cukrzycowa");
            cmbChoroby.Items.Add("Cystynuria");
            cmbChoroby.Items.Add("Ostra niewydolno�� nerek");
            cmbChoroby.Items.Add("Przewlek�a choroba nerek");
            cmbChoroby.Items.Add("Infekcje uk�adu moczowego");
            cmbChoroby.Items.Add("Zaburzenia l�kowe");
            cmbChoroby.Items.Add("Zaburzenia nastroju");
            cmbChoroby.Items.Add("Zaburzenia od�ywiania");
            cmbChoroby.Items.Add("Zaburzenia osobowo�ci");
            cmbChoroby.Items.Add("Zaburzenia psychosomatyczne");
            cmbChoroby.Items.Add("Zaburzenia zwi�zane z uzale�nieniami");
            cmbChoroby.Items.Add("Zaburzenia poznawcze");
            cmbChoroby.Items.Add("Problemy zwi�zane z �yciem zawodowym");
            cmbChoroby.Items.Add("Nadci�nienie t�tnicze pierwotne");
            cmbChoroby.Items.Add("Nadci�nienie t�tnicze wt�rne");
            cmbChoroby.Items.Add("Nadci�nienie t�tnicze w ci��y");
            cmbChoroby.Items.Add("Nadci�nienie zwi�zane z chorobami metabolicznymi");
            cmbChoroby.Items.Add("Niewydolno�� serca");
            cmbChoroby.Items.Add("Choroba wie�cowa");
            cmbChoroby.Items.Add("Kr�tkowzroczno��");
            cmbChoroby.Items.Add("Nadwzroczno��");
            cmbChoroby.Items.Add("Astygmatyzm");
            cmbChoroby.Items.Add("Zapalenie spoj�wek");
            cmbChoroby.Items.Add("Zesp� suchego oka");
            cmbChoroby.Items.Add("Zapalenie rog�wki");
            cmbChoroby.Items.Add("Sto�ek rog�wki");
            cmbChoroby.Items.Add("Dystrofie rog�wki");
            cmbChoroby.Items.Add("Owrzodzenie rog�wki");
            cmbChoroby.Items.Add("Za�ma");
            cmbChoroby.Items.Add("Zapalenie tward�wki");
            cmbChoroby.Items.Add("Wrodzone wady soczewki");
            cmbChoroby.Items.Add("M�ty w ciele szklistym");
            cmbChoroby.Items.Add("Jaskra");
            cmbChoroby.Items.Add("Przezi�bienie");
            cmbChoroby.Items.Add("Grypa");
            cmbChoroby.Items.Add("Zapalenie oskrzeli");
            cmbChoroby.Items.Add("Zesp� jelita dra�liwego");
            cmbChoroby.Items.Add("Przewlek�a niewydolno�� serca");
            cmbChoroby.Items.Add("Zaparcia");
            cmbChoroby.Items.Add("Ospa wietrzna");
            cmbChoroby.Items.Add("�uszczyca");
            cmbChoroby.Items.Add("Rwa kulszowa");
            cmbChoroby.Items.Add("Alergie sezonowe i ca�oroczne");
            cmbChoroby.Items.Add("Choroby tarczycy");
            cmbChoroby.Items.Add("Zapalenia mi�ni");
            cmbChoroby.Items.Add("Narkolepsja");
            cmbChoroby.Items.Add("Parasomnie");
            cmbChoroby.Items.Add("Neuralgia nerwu tr�jdzielnego");
            cmbChoroby.Items.Add("Zapalenie opon m�zgowo-rdzeniowych");
            cmbChoroby.Items.Add("Sarkoidoza uk�adu nerwowego");
            cmbChoroby.Items.Add("Neurofibromatoza");
            cmbChoroby.Items.Add("Stwardnienie guzowate");
            cmbChoroby.SelectedIndex = 0;

            lekarze.Add(new Lekarz("Dr. Siwek", "Epileptolog"));
            lekarze.Add(new Lekarz("Dr. Chocho�", "Neurolog"));
            lekarze.Add(new Lekarz("Prof. Mycko", "prof. dr hab. n. med"));
            lekarze.Add(new Lekarz("Dr. Beata Moczulska", "Hipertensjolog"));
            lekarze.Add(new Lekarz("Dr. Kamila Czarnacka", "Nefrolog"));
            lekarze.Add(new Lekarz("Dr. Teodor Maczy�ski", "Okulista"));
            lekarze.Add(new Lekarz("Lek. Ma�gorzata Konrad", "Lekarz rodzinny"));
            lekarze.Add(new Lekarz("Mrg. Kamila Jezierska", "Psycholog"));

        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (var pacjent in pacjenci)
            {
                var lekarz = lekarze.Find(l => l.Specjalizacja.Equals(GetSpecializacjaDlaChoroby(pacjent.Choroba), StringComparison.OrdinalIgnoreCase));
                if (lekarz != null)
                {
                    lekarz.Pacjenci.Add(pacjent);
                }
            }
            MessageBox.Show("Pacjenci zostali przypisani do lekarzy.");
        }
        private string GetSpecializacjaDlaChoroby(string choroba)
        {
            return choroba.ToLower() switch
            {
                "padaczka" => "Epileptolog",
                "padaczka objawowa" => "Epileptolog",
                "napady ogniskowe" => "Epileptolog",
                "zesp� westa" => "Epileptolog",
                "padaczka pourazowa" => "Epileptolog",
                "zesp� dravet" => "Epileptolog",
                "omdlenia" => "Epileptolog",
                "zaburzenia snu" => "Epileptolog",
                "parkinson" => "Neurolog",
                "alzheimer" => "Neurolog",
                "stwardnienie rozsiane" => "Neurolog",
                "zapalenie m�zgu" => "Neurolog",
                "zapalenie rdzenia kr�gowego" => "Neurolog",
                "t�tniak m�zgu" => "Neurolog",
                "migrena" => "Neurolog",
                "b�l g�owy" => "Neurolog",
                "glejak" => "prof. dr hab. n. med",
                "udar m�zgu" => "prof. dr hab. n. med",
                "kamica nerkowa" => "Nefrolog",
                "torbielowato�� nerek" => "Nefrolog",
                "nefropatia cukrzycowa" => "Nefrolog",
                "cystynuria" => "Nefrolog",
                "ostra niewydolno�� nerek" => "Nefrolog",
                "przewlek�a choroba nerek" => "Nefrolog",
                "infekcje uk�adu moczowego" => "Nefrolog",
                "depresja" => "Psycholog",
                "zaburzenia l�kowe" => "Psycholog",
                "zaburzenia nastroju" => "Psycholog",
                "zaburzenia od�ywiania" => "Psycholog",
                "zaburzenia osobowo�ci" => "Psycholog",
                "zaburzenia psychosomatyczne" => "Psycholog",
                "zaburzenia zwi�zane z uzale�nieniami" => "Psycholog",
                "zaburzenia poznawcze" => "Psycholog",
                "problemy zwi�zane z �yciem zawodowym" => "Psycholog",
                "nadci�nienie t�tnicze pierwotne" => "Hipertensjolog",
                "nadci�nienie t�tnicze wt�rne" => "Hipertensjolog",
                "nadci�nienie t�tnicze w ci��y" => "Hipertensjolog",
                "nadci�nienie zwi�zane z chorobami metabolicznymi" => "Hipertensjolog",
                "niewydolno�� serca" => "Hipertensjolog",
                "choroba wie�cowa" => "Hipertensjolog",
                "kr�tkowzroczno��" => "Okulista",
                "nadwzroczno��" => "Okulista",
                "astygmatyzm" => "Okulista",
                "zapalenie spoj�wek" => "Okulista",
                "zesp� suchego oka" => "Okulista",
                "zapalenie rog�wki" => "Okulista",
                "sto�ek rog�wki" => "Okulista",
                "dystrofie rog�wki" => "Okulista",
                "owrzodzenie rog�wki" => "Okulista",
                "za�ma" => "Okulista",
                "zapalenie tward�wki" => "Okulista",
                "wrodzone wady soczewki" => "Okulista",
                "m�ty w ciele szklistym" => "Okulista",
                "jaskra" => "Okulista",
                "przezi�bienie" => "Lekarz rodzinny",
                "grypa" => "Lekarz rodzinny",
                "zapalenie oskrzeli" => "Lekarz rodzinny",
                "zesp� jelita dra�liwego" => "Lekarz rodzinny",
                "przewlek�a niewydolno�� serca" => "Lekarz rodzinny",
                "zaparcia" => "Lekarz rodzinny",
                "ospa wietrzna" => "Lekarz rodzinny",
                "�uszczyca" => "Lekarz rodzinny",
                "rwa kulszowa" => "Lekarz rodzinny",
                "alergie sezonowe i ca�oroczne" => "Lekarz rodzinny",
                "choroby tarczycy" => "prof. dr hab. n. med",
                "zapalenia mi�n" => "prof. dr hab. n. med",
                "narkolepsja" => "prof. dr hab. n. med",
                "parasomnie" => "prof. dr hab. n. med",
                "neuralgia nerwu tr�jdzielnego" => "prof. dr hab. n. med",
                "zapalenie opon m�zgowo-rdzeniowych" => "prof. dr hab. n. med",
                "sarkoidoza uk�adu nerwowego" => "prof. dr hab. n. med",
                "neurofibromatoza" => "prof. dr hab. n. med",
                "stwardnienie guzowate" => "prof. dr hab. n. med",
                _ => string.Empty
            };
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lstLekarzePacjenci.Items.Clear();
            foreach (var lekarz in lekarze)
            {
                if (lekarz.Pacjenci.Count > 0)
                {
                    lstLekarzePacjenci.Items.Add($"{lekarz.Imie} - {lekarz.Specjalizacja}:");
                    foreach (var pacjent in lekarz.Pacjenci)
                    {
                        lstLekarzePacjenci.Items.Add($" - Pacjent: {pacjent.Imie} {pacjent.Nazwisko}, Choroba: {pacjent.Choroba}");
                    }
                }
            }
            if (lstLekarzePacjenci.Items.Count == 0)
            {
                lstLekarzePacjenci.Items.Add("Brak przypisanych pacjent�w.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                string imie = txtImiePacjenta.Text;
                string nazwisko = txtNazwiskoPacjenta.Text;
                string choroba = cmbChoroby.SelectedItem.ToString();

                if (!string.IsNullOrWhiteSpace(imie) && !string.IsNullOrWhiteSpace(nazwisko) && !string.IsNullOrWhiteSpace(choroba))
                {
                    pacjenci.Add(new Pacjent(imie, nazwisko, choroba));
                    MessageBox.Show("Dodano pacjenta!");
                    txtImiePacjenta.Clear();
                    txtNazwiskoPacjenta.Clear();
                    cmbChoroby.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Nie uzupe�niono danych pacjenta! Prosz� uzupe�ni� dane!");
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                lstPacjenci.Items.Clear();
                foreach (var pacjent in pacjenci)
                {
                    lstPacjenci.Items.Add($"{pacjent.Nazwisko} {pacjent.Imie} - Choroba: {pacjent.Choroba}");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                for (int i = 0; i < pacjenci.Count - 1; i++)
                {
                    for (int j = 0; j < pacjenci.Count - i - 1; j++)
                    {
                        if (string.Compare(pacjenci[j].Nazwisko, pacjenci[j + 1].Nazwisko) > 0)
                        {
                            var temp = pacjenci[j];
                            pacjenci[j] = pacjenci[j + 1];
                            pacjenci[j + 1] = temp;
                        }
                    }
                }
                MessageBox.Show("Pacjenci posortowani.");
                lstPacjenci.Items.Clear(); 
                foreach (var pacjent in pacjenci)
                {
                    lstPacjenci.Items.Add($"{pacjent.Nazwisko} {pacjent.Imie} - Choroba: {pacjent.Choroba}");
                }
            }
        }

    }

    public class Pacjent
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Choroba { get; set; }

        public Pacjent(string imie, string nazwisko, string choroba)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Choroba = choroba;
        }
    }

    public class Lekarz
    {
        public string Imie { get; set; }
        public string Specjalizacja { get; set; }
        public List<Pacjent> Pacjenci { get; set; } = new List<Pacjent>();

        public Lekarz(string imie, string specjalizacja)
        {
            Imie = imie;
            Specjalizacja = specjalizacja;
        }
    }
}
