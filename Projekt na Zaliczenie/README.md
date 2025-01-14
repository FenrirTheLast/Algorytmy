# Projekt na zaliczenie przedmiotu Algorytmy i Struktury Danych

Nazwa Projektu: Pacjenci - Lekarze

Autor Projektu: Damian Wilk (175217)

## Opis Projektu

Wykorzystane struktury danych:

1. Lista jednokierunkowa (List<T> w C#):

- W programie użyto dynamicznej listy (List<T>) do przechowywania danych o
pacjentach oraz lekarzach.
- Każdy pacjent oraz lekarz jest obiektem odpowiednio klasy Pacjent lub 
Lekarz.
- Klasa Pacjent przechowuje następujące informacje:
- Imię (string) – imię pacjenta.
- Nazwisko (string) – nazwisko pacjenta.
- Choroba (string) – schorzenie, które ma pacjent.
- Klasa Lekarz zawiera:
- Imię (string) – imię lekarza.
- Specjalizacja (string) – specjalizacja lekarza.
- Pacjenci (List<Pacjent>) – lista pacjentów przypisanych do danego lekarza.

2. Sortowanie bąbelkowe:

Do sortowania pacjentów według nazwiska wykorzystano algorytm sortowania 
bąbelkowego, który iteracyjnie
porównuje i zamienia sąsiadujące elementy w liście, aż wszystkie elementy 
znajdą się w poprawnej kolejności alfabetycznej.

## Działanie programu

Dodawanie pacjentów:
- Użytkownik wprowadza imię, nazwisko oraz chorobę pacjenta.
- Chorobę można wybrać z listy predefiniowanych schorzeń (ComboBox), takich 
jak "Padaczka", "Parkinson", czy "Udar mózgu".
- Po dodaniu pacjent zostaje zapisany w liście pacjentów, a jego dane są 
natychmiast wyświetlane w widoku listy (ListBox).

Wyświetlanie lekarzy i przypisywanie pacjentów:
- Każdy lekarz w programie ma określoną specjalizację, np. "Epileptolog" 
czy "Neurolog".
- Program przypisuje pacjentów do lekarzy na podstawie ich choroby. 
- Przypisanie odbywa się automatycznie po wybraniu opcji przypisania.
- Użytkownik może również wyświetlić listę lekarzy wraz z przypisanymi 
pacjentami. Wyświetlani są tylko lekarze, którzy mają przypisanych pacjentów.

Sortowanie pacjentów:
- Użytkownik może posortować pacjentów według nazwiska w porządku alfabetycznym.
- Po sortowaniu pacjenci są automatycznie wyświetlani w posortowanej kolejności 
w ListBox.

Opcja wyszukiwania i filtrowania:
- Program pozwala na wyszukiwanie lekarzy lub pacjentów na podstawie danych 
takich jak nazwisko, schorzenie czy specjalizacja.
- Wyniki wyszukiwania są wyświetlane w odpowiednim widoku.

Eksport danych:
- Program umożliwia eksport listy pacjentów lub lekarzy wraz z ich przypisanymi 
pacjentami do pliku tekstowego (TXT).

Środkowanie okna aplikacji:
- Po uruchomieniu aplikacja otwiera się automatycznie na środku ekranu, zapewniając 
lepszą prezentację wizualną.

## Cechy programu:

1. Dynamiczne zarządzanie danymi:
- Możliwość dodawania, przypisywania, sortowania oraz filtrowania pacjentów i lekarzy.
2. Automatyczne przypisywanie pacjentów:
- Przypisanie do odpowiedniego lekarza na podstawie schorzenia pacjenta.
3. Przejrzysta prezentacja danych:
- Dane są wyświetlane w ListBox, a użytkownik może przeglądać lekarzy i ich pacjentów.
4. Modularność:
- Wykorzystanie klas Pacjent i Lekarz pozwala na rozbudowę programu w przyszłości.
