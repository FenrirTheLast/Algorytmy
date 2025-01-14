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
            cmbChoroby.Items.Add("Udar mózgu");
            cmbChoroby.Items.Add("Padaczka objawowa");
            cmbChoroby.Items.Add("Napady ogniskowe");
            cmbChoroby.Items.Add("Zespó³ Westa");
            cmbChoroby.Items.Add("Omdlenia");
            cmbChoroby.Items.Add("Zaburzenia snu");
            cmbChoroby.Items.Add("Alzheimer");
            cmbChoroby.Items.Add("Stwardnienie Rozsiane");
            cmbChoroby.Items.Add("Zapalenie mózgu");
            cmbChoroby.Items.Add("Zapalenie rdzenia krêgowego");
            cmbChoroby.Items.Add("Têtniak mózgu");
            cmbChoroby.Items.Add("Migrena");
            cmbChoroby.Items.Add("Ból g³owy");
            cmbChoroby.Items.Add("Glejak");
            cmbChoroby.Items.Add("Kamica nerkowa");
            cmbChoroby.Items.Add("Torbielowatoœæ nerek");
            cmbChoroby.Items.Add("Nefropatia cukrzycowa");
            cmbChoroby.Items.Add("Cystynuria");
            cmbChoroby.Items.Add("Ostra niewydolnoœæ nerek");
            cmbChoroby.Items.Add("Przewlek³a choroba nerek");
            cmbChoroby.Items.Add("Infekcje uk³adu moczowego");
            cmbChoroby.Items.Add("Zaburzenia lêkowe");
            cmbChoroby.Items.Add("Zaburzenia nastroju");
            cmbChoroby.Items.Add("Zaburzenia od¿ywiania");
            cmbChoroby.Items.Add("Zaburzenia osobowoœci");
            cmbChoroby.Items.Add("Zaburzenia psychosomatyczne");
            cmbChoroby.Items.Add("Zaburzenia zwi¹zane z uzale¿nieniami");
            cmbChoroby.Items.Add("Zaburzenia poznawcze");
            cmbChoroby.Items.Add("Problemy zwi¹zane z ¿yciem zawodowym");
            cmbChoroby.Items.Add("Nadciœnienie têtnicze pierwotne");
            cmbChoroby.Items.Add("Nadciœnienie têtnicze wtórne");
            cmbChoroby.Items.Add("Nadciœnienie têtnicze w ci¹¿y");
            cmbChoroby.Items.Add("Nadciœnienie zwi¹zane z chorobami metabolicznymi");
            cmbChoroby.Items.Add("Niewydolnoœæ serca");
            cmbChoroby.Items.Add("Choroba wieñcowa");
            cmbChoroby.Items.Add("Krótkowzrocznoœæ");
            cmbChoroby.Items.Add("Nadwzrocznoœæ");
            cmbChoroby.Items.Add("Astygmatyzm");
            cmbChoroby.Items.Add("Zapalenie spojówek");
            cmbChoroby.Items.Add("Zespó³ suchego oka");
            cmbChoroby.Items.Add("Zapalenie rogówki");
            cmbChoroby.Items.Add("Sto¿ek rogówki");
            cmbChoroby.Items.Add("Dystrofie rogówki");
            cmbChoroby.Items.Add("Owrzodzenie rogówki");
            cmbChoroby.Items.Add("Zaæma");
            cmbChoroby.Items.Add("Zapalenie twardówki");
            cmbChoroby.Items.Add("Wrodzone wady soczewki");
            cmbChoroby.Items.Add("Mêty w ciele szklistym");
            cmbChoroby.Items.Add("Jaskra");
            cmbChoroby.Items.Add("Przeziêbienie");
            cmbChoroby.Items.Add("Grypa");
            cmbChoroby.Items.Add("Zapalenie oskrzeli");
            cmbChoroby.Items.Add("Zespó³ jelita dra¿liwego");
            cmbChoroby.Items.Add("Przewlek³a niewydolnoœæ serca");
            cmbChoroby.Items.Add("Zaparcia");
            cmbChoroby.Items.Add("Ospa wietrzna");
            cmbChoroby.Items.Add("£uszczyca");
            cmbChoroby.Items.Add("Rwa kulszowa");
            cmbChoroby.Items.Add("Alergie sezonowe i ca³oroczne");
            cmbChoroby.Items.Add("Choroby tarczycy");
            cmbChoroby.Items.Add("Zapalenia miêœni");
            cmbChoroby.Items.Add("Narkolepsja");
            cmbChoroby.Items.Add("Parasomnie");
            cmbChoroby.Items.Add("Neuralgia nerwu trójdzielnego");
            cmbChoroby.Items.Add("Zapalenie opon mózgowo-rdzeniowych");
            cmbChoroby.Items.Add("Sarkoidoza uk³adu nerwowego");
            cmbChoroby.Items.Add("Neurofibromatoza");
            cmbChoroby.Items.Add("Stwardnienie guzowate");
            cmbChoroby.SelectedIndex = 0;

            lekarze.Add(new Lekarz("Dr. Siwek", "Epileptolog"));
            lekarze.Add(new Lekarz("Dr. Chocho³", "Neurolog"));
            lekarze.Add(new Lekarz("Prof. Mycko", "prof. dr hab. n. med"));
            lekarze.Add(new Lekarz("Dr. Beata Moczulska", "Hipertensjolog"));
            lekarze.Add(new Lekarz("Dr. Kamila Czarnacka", "Nefrolog"));
            lekarze.Add(new Lekarz("Dr. Teodor Maczyñski", "Okulista"));
            lekarze.Add(new Lekarz("Lek. Ma³gorzata Konrad", "Lekarz rodzinny"));
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
                "zespó³ westa" => "Epileptolog",
                "padaczka pourazowa" => "Epileptolog",
                "zespó³ dravet" => "Epileptolog",
                "omdlenia" => "Epileptolog",
                "zaburzenia snu" => "Epileptolog",
                "parkinson" => "Neurolog",
                "alzheimer" => "Neurolog",
                "stwardnienie rozsiane" => "Neurolog",
                "zapalenie mózgu" => "Neurolog",
                "zapalenie rdzenia krêgowego" => "Neurolog",
                "têtniak mózgu" => "Neurolog",
                "migrena" => "Neurolog",
                "ból g³owy" => "Neurolog",
                "glejak" => "prof. dr hab. n. med",
                "udar mózgu" => "prof. dr hab. n. med",
                "kamica nerkowa" => "Nefrolog",
                "torbielowatoœæ nerek" => "Nefrolog",
                "nefropatia cukrzycowa" => "Nefrolog",
                "cystynuria" => "Nefrolog",
                "ostra niewydolnoœæ nerek" => "Nefrolog",
                "przewlek³a choroba nerek" => "Nefrolog",
                "infekcje uk³adu moczowego" => "Nefrolog",
                "depresja" => "Psycholog",
                "zaburzenia lêkowe" => "Psycholog",
                "zaburzenia nastroju" => "Psycholog",
                "zaburzenia od¿ywiania" => "Psycholog",
                "zaburzenia osobowoœci" => "Psycholog",
                "zaburzenia psychosomatyczne" => "Psycholog",
                "zaburzenia zwi¹zane z uzale¿nieniami" => "Psycholog",
                "zaburzenia poznawcze" => "Psycholog",
                "problemy zwi¹zane z ¿yciem zawodowym" => "Psycholog",
                "nadciœnienie têtnicze pierwotne" => "Hipertensjolog",
                "nadciœnienie têtnicze wtórne" => "Hipertensjolog",
                "nadciœnienie têtnicze w ci¹¿y" => "Hipertensjolog",
                "nadciœnienie zwi¹zane z chorobami metabolicznymi" => "Hipertensjolog",
                "niewydolnoœæ serca" => "Hipertensjolog",
                "choroba wieñcowa" => "Hipertensjolog",
                "krótkowzrocznoœæ" => "Okulista",
                "nadwzrocznoœæ" => "Okulista",
                "astygmatyzm" => "Okulista",
                "zapalenie spojówek" => "Okulista",
                "zespó³ suchego oka" => "Okulista",
                "zapalenie rogówki" => "Okulista",
                "sto¿ek rogówki" => "Okulista",
                "dystrofie rogówki" => "Okulista",
                "owrzodzenie rogówki" => "Okulista",
                "zaæma" => "Okulista",
                "zapalenie twardówki" => "Okulista",
                "wrodzone wady soczewki" => "Okulista",
                "mêty w ciele szklistym" => "Okulista",
                "jaskra" => "Okulista",
                "przeziêbienie" => "Lekarz rodzinny",
                "grypa" => "Lekarz rodzinny",
                "zapalenie oskrzeli" => "Lekarz rodzinny",
                "zespó³ jelita dra¿liwego" => "Lekarz rodzinny",
                "przewlek³a niewydolnoœæ serca" => "Lekarz rodzinny",
                "zaparcia" => "Lekarz rodzinny",
                "ospa wietrzna" => "Lekarz rodzinny",
                "³uszczyca" => "Lekarz rodzinny",
                "rwa kulszowa" => "Lekarz rodzinny",
                "alergie sezonowe i ca³oroczne" => "Lekarz rodzinny",
                "choroby tarczycy" => "prof. dr hab. n. med",
                "zapalenia miêœn" => "prof. dr hab. n. med",
                "narkolepsja" => "prof. dr hab. n. med",
                "parasomnie" => "prof. dr hab. n. med",
                "neuralgia nerwu trójdzielnego" => "prof. dr hab. n. med",
                "zapalenie opon mózgowo-rdzeniowych" => "prof. dr hab. n. med",
                "sarkoidoza uk³adu nerwowego" => "prof. dr hab. n. med",
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
                lstLekarzePacjenci.Items.Add("Brak przypisanych pacjentów.");
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
                    MessageBox.Show("Nie uzupe³niono danych pacjenta! Proszê uzupe³niæ dane!");
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
