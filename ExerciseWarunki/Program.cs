using System;
using System.ComponentModel.Design;

namespace ExcerciseWarunki
{

    //Data structure declaration

    class Program
    {
        struct Data1
        {
            public string Name;
            public string Surname;
            public int Age;
            public char Sex;
            public int Pesel;
            public int WorkerNo;
        }

        public struct Data2
        {
            public string Name;
            public string Surname;
            public int Age;
            public char Sex;
            public int Pesel;
            public int TelNo;
            public string Email;
            public float Weight;
        }

        private static void Main(string[] args)
        {
            int nr_zadania = 0;
            bool parseresult;

            do
            {

                do
                {
                    Console.WriteLine("Podaj nr zadania które chcesz wykonać" +
                    "\n1. Porównanie 2 liczb" +
                    "\n2. Sprawdzenie parzystości" +
                    "\n3. Dodatnia czy ujemna" +
                    "\n4. Rok przestępny" +
                    "\n5. Wiek na posła, senatora i prezydenta" +
                    "\n6. Kategoria wzrostu" +
                    "\n7. Największa liczba" +
                    "\n8. Kryteria na studia" +
                    "\n9. Opisy temperatur" +
                    "\n10. Budowa trójkąta" +
                    "\n11. Opis oceny" +
                    "\n12. Dzień tygodnia" +
                    "\n13. Kalkulator" +
                    "\n14. Zakończ\n");
                    parseresult = Int32.TryParse(Console.ReadLine(), out nr_zadania);
                }
                while (!parseresult || nr_zadania > 14 && nr_zadania < 1);

                Console.WriteLine($"\nWybrałeś zadanie nr {nr_zadania}\n");

                switch (nr_zadania)
                {
                    case 1:
                        int a = 0;
                        int b = 0;

                        //a
                        Console.WriteLine("Podaj pierwsza liczbe");
                        Int32.TryParse(Console.ReadLine(), out a);
                        //b
                        Console.WriteLine("Podaj druga liczbe");
                        Int32.TryParse(Console.ReadLine(), out b);

                        //Display data
                        if (a == b)
                        {
                            Console.WriteLine($"Liczby : {a} i {b} są równe");
                        }
                        else
                        {
                            Console.WriteLine($"Liczby : {a} i {b} nie są równe");
                        }
                        break;
                    case 2:
                        int c = 0;

                        //c
                        Console.WriteLine("Podaj liczbe");
                        Int32.TryParse(Console.ReadLine(), out c);

                        //Display data
                        if (c % 2 == 1)
                        {
                            Console.WriteLine($"Liczba : {c} jest nieparzysta");
                        }
                        else
                        {
                            Console.WriteLine($"Liczba : {c} jest parzysta");
                        }
                        break;
                    case 3:
                        int d = 0;

                        //d
                        Console.WriteLine("Podaj liczbe");
                        Int32.TryParse(Console.ReadLine(), out d);

                        //Display data
                        if (d > 0)
                        {
                            Console.WriteLine($"Liczba : {d} jest dodatnia");
                        }
                        else if (d < 0)
                        {
                            Console.WriteLine($"Liczba : {d} jest ujemna");
                        }
                        else
                        { 
                            Console.WriteLine($"Liczba : {d} jest zerem");
                        }
                    break;
                    case 4:
                        int e = 0;
                        do
                        {
                            //a
                            Console.WriteLine("Podaj rok");
                            parseresult = Int32.TryParse(Console.ReadLine(), out e);
                        }
                        while (!parseresult);

                        //Display data
                        if (e % 4 == 0 && e % 100 != 0 || e % 400 == 0)
                        {
                            Console.WriteLine($"Rok : {e} jest rokiem przestępnym");
                        }
                        else
                        {
                            Console.WriteLine($"Rok : {e} nie jest rokiem przestępnym");
                        }
                    break;
                    case 5:
                        int f = 0;
                        do
                        {
                            //a
                            Console.WriteLine("Podaj wiek");
                            parseresult = Int32.TryParse(Console.ReadLine(), out f);
                        }
                        while (!parseresult);

                        //Display data
                        if (f < 21)
                        {
                            Console.WriteLine("Nie mozesz zostac posłem, premierem, senatorem ani prezydentem");
                        }
                        else if (f >= 21 && f < 30)
                        {
                            Console.WriteLine("Mozesz zostac posłem i premierem");
                        }
                        else if (f >= 30 && f < 35)
                        {
                            Console.WriteLine("Mozesz zostac posłem, premierem i senatorem");
                        }
                        else if (f >= 35)
                        {
                            Console.WriteLine("Mozesz zostac posłem, premierem, senatorem i prezydentem");
                        }
                        break;
                    case 6:
                        int g = 0;
                        do
                        {
                            //a
                            Console.WriteLine("Podaj wzrost");
                            parseresult = Int32.TryParse(Console.ReadLine(), out g);
                        }
                        while (!parseresult);

                        //Display data
                        string komunikat = g switch
                        {
                            int i when i < 151 => "Nie możesz wejść do Makro",
                            int i when i > 150 && i < 161 => "Noś kapelusz",
                            int i when i > 160 && i < 171 => "Noś kapelusz",
                            int i when i > 160 && i < 171 => "Noś kapelusz",
                            int i when i > 170 && i < 181 => "Średnia krajowa?",
                            int i when i > 180 && i < 191 => "Wysoki",
                            int i when i > 190 && i < 201 => "Bardzo wysoki",
                            int i when i > 200 && i < 211 => "Stoisz na bramce?",
                            int i when i > 210 && i < 221 => "Grasz w kosza?",
                            int i when i > 220 => "Nie możesz wejść do Makro",
                            _ => "Brak podanego wzrostu"
                        };
                        Console.WriteLine(komunikat);
                        break;
                    case 7:
                        int h = 0;
                        int j = 0;
                        int k = 0;
                        //1st number read
                        do
                        {
                            //a
                            Console.WriteLine("Podaj pierwsza liczbę");
                            parseresult = Int32.TryParse(Console.ReadLine(), out h);
                        }
                        while (!parseresult);

                        //2nd number read
                        do
                        {
                            //a
                            Console.WriteLine("Podaj drugą liczbę");
                            parseresult = Int32.TryParse(Console.ReadLine(), out j);
                        }
                        while (!parseresult);

                        //3rd number read
                        do
                        {
                            //a
                            Console.WriteLine("Podaj trzecią liczbę");
                            parseresult = Int32.TryParse(Console.ReadLine(), out k);
                        }
                        while (!parseresult);
                        //Maximum search
                        if (h >= j && h >= k)
                        {
                            Console.WriteLine($"Największa liczba to {h}");
                        }
                        else if (j >= h && j >= k)
                        {
                            Console.WriteLine($"Największa liczba to {j}");
                        }
                        else
                        {
                            Console.WriteLine($"Największa liczba to {k}");
                        }
                        break;
                    case 8:
                        int q = 0;
                        int r = 0;
                        int s = 0;
                        {
                            Console.WriteLine("Podaj ocene z matematyki 0-100");
                           parseresult = Int32.TryParse(Console.ReadLine(), out q);
                        }
                        while (!parseresult || q > 100 && q < 0) ;
                        {
                            Console.WriteLine("Podaj ocene z fizyki 0-100");
                            parseresult = Int32.TryParse(Console.ReadLine(), out r);
                        }
                        while (!parseresult || r > 100 && r < 0) ;
                        {
                            Console.WriteLine("Podaj ocene z chemii 0-100");
                            parseresult = Int32.TryParse(Console.ReadLine(), out s);
                        }
                        while (!parseresult || s > 100 && s < 0) ;

                        if (q > 75 || r > 55 || s > 45 || q + r + s > 180 || q + r > 150 || q + s > 150)
                        {
                            Console.WriteLine("Kandydat dopuszczony do rekrutacji\n");
                        }
                        else
                        {
                            Console.WriteLine("Kandydat niedopuszczony do rekrutacji\n");
                        }
                        break;
                    case 9:
                        int p = 0;
                        do
                        {
                            //a
                            Console.WriteLine("Podaj temperaturę");
                            parseresult = Int32.TryParse(Console.ReadLine(), out p);
                        }
                        while (!parseresult);

                        //Display data
                        string komunikat1 = p switch
                        {
                            int i when i < 0 => "Cholernie piździ",
                            int i when i > 0 && i < 11 => "Zimno",
                            int i when i > 10 && i < 21 => "Chłodno",
                            int i when i > 20 && i < 31 => "W sam raz",
                            int i when i > 170 && i < 181 => "Zaczyna być słabo, bo gorąco",
                            int i when i > 180 && i < 191 => "A weź wyprowadzam się na Alaskę",
                            _ => "Nie żyjesz"
                        };
                        Console.WriteLine($"{ komunikat1}\n");
                        break;
                    case 10:
                        int l = 0;
                        int m = 0;
                        int n = 0;
                        //1st number read
                        do
                        {
                            //a
                            Console.WriteLine("Podaj pierwsza liczbę");
                            parseresult = Int32.TryParse(Console.ReadLine(), out l);
                        }
                        while (!parseresult);

                        //2nd number read
                        do
                        {
                            //a
                            Console.WriteLine("Podaj drugą liczbę");
                            parseresult = Int32.TryParse(Console.ReadLine(), out m);
                        }
                        while (!parseresult);

                        //3rd number read
                        do
                        {
                            //a
                            Console.WriteLine("Podaj trzecią liczbę");
                            parseresult = Int32.TryParse(Console.ReadLine(), out n);
                        }
                        while (!parseresult);
                        //Traingle build check
                        if (l + m > n && l + n > m && m + n > l)
                        {
                            Console.WriteLine("3 odcinki mogą stworzyć trójkąt");
                        }
                        else
                        {
                            Console.WriteLine("3 odcinki nie mogą stworzyć trójkąta");
                        }
                        break;
                    case 11:
                        int ocena1 = 0;
                        string opis1 = "";
                        //Score read
                        do
                        {
                            Console.WriteLine("Podaj ocenę od 1 do 6");
                            parseresult = Int32.TryParse(Console.ReadLine(), out ocena1);
                        }
                        while (!parseresult || ocena1 < 1 || ocena1 > 6);


                        //Score description
                        switch (ocena1)
                        {
                            case 1:
                                opis1 = "Niedostateczny";
                                break;
                            case 2:
                                opis1 = "Dopuszczający";
                                break;
                            case 3:
                                opis1 = "Dostateczny";
                                break;
                            case 4:
                                opis1 = "Dobry";
                                break;
                            case 5:
                                opis1 = "Bardzo dobry";
                                break;
                            case 6:
                                opis1 = "Celujący";
                                break;
                        }
                        Console.WriteLine(opis1);
                        break;
                    case 12:
                        int ocena2 = 0;
                        string opis2 = "";
                        //Score read
                        do
                        {
                            Console.WriteLine("Podaj dzień tygodnia od 1 do 7");
                            parseresult = Int32.TryParse(Console.ReadLine(), out ocena2);
                        }
                        while (!parseresult || ocena2 < 1 || ocena2 > 7);


                        //Score description
                        switch (ocena2)
                        {
                            case 1:
                                opis2 = "poniedziałek";
                                break;
                            case 2:
                                opis2 = "wtorek";
                                break;
                            case 3:
                                opis2 = "środa";
                                break;
                            case 4:
                                opis2 = "czwartek";
                                break;
                            case 5:
                                opis2 = "piątek";
                                break;
                            case 6:
                                opis2 = "sobota";
                                break;
                            case 7:
                                opis2 = "sobota";
                                break;
                            default:
                                opis2 = "niepoprawne dane";
                                break;
                        }
                        Console.WriteLine(opis2);
                        break;
                    case 13:
                        float x = 0;
                        float y = 0;
                        float wynik = 0;
                        int wybor = 0;
                        //Operation choose
                        do
                        {
                            Console.WriteLine("Wybierz operację:\n" +
                                "1 - Dodawanie\n" +
                                "2 - Odejmowanie\n" +
                                "3 - Mnożenie\n" +
                                "4 - Dzielenie");
                            parseresult = Int32.TryParse(Console.ReadLine(), out wybor);
                        }
                        while (!parseresult || wybor < 1 || wybor > 4);
                        //Numbers read
                        do
                        {
                            Console.WriteLine("Podaj pierwsza liczbę");
                            parseresult = float.TryParse(Console.ReadLine(), out x);
                        }
                        while (!parseresult);

                        do
                        {
                            if (wybor == 4)
                            {
                                Console.WriteLine("Podaj druga liczbę różną od zera");
                            }
                            else
                            {
                                Console.WriteLine("Podaj druga liczbę");
                            }
                            parseresult = float.TryParse(Console.ReadLine(), out y);
                        }
                        while (!parseresult || (wybor == 4 && y == 0));

                        //Calculation
                        switch (wybor)
                        {
                            case 1:
                                wynik = x + y;
                                Console.WriteLine($"Wynik dodawania to:{wynik}");
                                break;
                            case 2:
                                wynik = x - y;
                                Console.WriteLine($"Wynik odejmowania to:{wynik}");
                                break;
                            case 3:
                                wynik = x * y;
                                Console.WriteLine($"Wynik mnożenia to:{wynik}");
                                break;
                            case 4:
                                wynik = x / y;
                                Console.WriteLine($"Wynik dzielenia to:{wynik}");
                                break;
                            default:
                                Console.WriteLine($"Niepoprawne dane");
                                break;
                        }
                        break;
                }
            } while (nr_zadania != 6);
        }
    }



}
