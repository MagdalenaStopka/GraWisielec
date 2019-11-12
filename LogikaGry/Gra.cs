using System;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace LogikaGry
{
    public class Gra
    {

         public string plik = @"D:\Temp\wisielec.txt";
        
        public const char SymbolPusty = '*';
        // zmienne stanu gry
        private string wylosowaneSlowo;

        private StringBuilder aktualnywzorzec;
        public StanSzubienicy StanGry { get; private set; }
        // readonly - zmienna może być zmieniona tylko w konstruktorze


        private List<string> slownik = new List<string>
        {
            "alkohol", "Warszawa", "brzeczeszczykiwicz", "kurczaczki", "krowa", "programowanie", "koszula"

        };


        private string losuj()

        {

            Random random = new Random(((int)DateTime.Now.Ticks));
            return slownik[(new Random()).Next(slownik.Count)].ToUpper();
        }

        private void zaladujPlikDoSlownika()
        {
            List<string> temp = new List<string>();

            using (TextReader tr = new StreamReader(plik))
            {
                string linia;
                while ((linia = tr.ReadLine()) != null)
                {
                    // logika dodawania do listy
                    string s = linia.Trim().ToUpper();
                    temp.Add(linia.Trim().ToUpper());
                }
            }

           
                if (temp.Count > 0)
                {
                    slownik = temp;
                }
                //catch (Exception)
           // {
                // nic sie nie dzieje
            //}
        
        }

    
        public Gra()
        {
            zaladujPlikDoSlownika();
            // docelowo pobieramy z dysku i losujemy
            //jeżeli jest plik wisielec.txt na dysku, to wczytaj go i zainicjuj slownik
            wylosowaneSlowo = losuj();// tworzy obiekt ktory zawsze ma duze litery niezaleznie od tego, co napiszemy
            StanGry = StanSzubienicy.Podstawa; //

            aktualnywzorzec = new StringBuilder();
            for (int i = 0; i < wylosowaneSlowo.Length; i++)
                aktualnywzorzec.Append(SymbolPusty);  // dokleja gwiazki 



        }
        public int LiczbaRuchow => LiczbaRuchowNietrafionych + LiczbaRuchowTrafionych;

        // int stan gry + liczba unikalnych liter + aktualny wzorzec bez symbolu pustego


        public int LiczbaRuchowNietrafionych => (int)StanGry; // => jet rownowazne get, set trzeba samemu napisać

        public int LiczbaRuchowTrafionych //=> throw new NotImplementedException();
        {
            get
            {
                //var zbiorLiter = new HashSet<char>(wylosowaneSlowo);
                //foreach (var c in wylosowaneSlowo)
                // zbiorLiter.Add(c);

                var zbiorLiter = new HashSet<char>(aktualnywzorzec.ToString());
                int ile = 0;
                /*
                if (zbiorLiter.Contains(SymbolPusty))
                    ile = zbiorLiter.Count - 1;
                else
                    ile = zbiorLiter.Count; */
                return (zbiorLiter.Contains(SymbolPusty)) ? ile = zbiorLiter.Count - 1 : ile = zbiorLiter.Count;


            }
        }

        public string AktualnyWzorzec => aktualnywzorzec.ToString();


        public bool CzyJest(char litera)
        {
            litera = char.ToUpper(litera);
            if (wylosowaneSlowo.Contains(litera.ToString()))
            {   // odslaniam litere we wzorcu

                for (int i = 0; i < wylosowaneSlowo.Length; i++)
                {
                    if (wylosowaneSlowo[i] == litera)
                        aktualnywzorzec[i] = litera;
                }
                return true;
            }
            // czy litera jest w napisie
            // jezeli tak

            else
            {
                //jezeli nie
                if (StanGry < StanSzubienicy.PrawaNoga)

                    StanGry++;

                return false;
            }
        }

        public string Poddaj()
        {
            StanGry = StanSzubienicy.PrawaNoga;
            return wylosowaneSlowo;
        }
    }
}
