using System;
using System.Collections.Immutable;
using System.Linq;

namespace irgendwas
{
    internal class Program
    {
        static List<int> participantsCourse1 = new List<int>();
        static List<int> participantsCourse2 = new List<int>();
        static List<int> participantsCourse3 = new List<int>();
        static List<int> participantsCourse4 = new List<int>();
        static List<int> participantsCourse5 = new List<int>();
        static List<string> namen = new List<string>();
        static int course1TakingPlace = 0;
        static int course2TakingPlace = 0;
        static int course3TakingPlace = 0;
        static int course4TakingPlace = 0;
        static int course5TakingPlace = 0;
        static string pfad = "";
        static List<int> auswahlderkurse = new List<int>();
        static int registeredFavourites = 0;
        static int Course1FirstPriority = 0;
        static int Course2FirstPriority = 0;
        static int Course3FirstPriority = 0;
        static int Course4FirstPriority = 0;
        static int Course5FirstPriority = 0;
        static int Course1SecondPriority = 0;
        static int Course2SecondPriority = 0;
        static int Course3SecondPriority = 0;
        static int Course4SecondPriority = 0;
        static int Course5SecondPriority = 0;
        static int Course1ThirdPriority = 0;
        static int Course2ThirdPriority = 0;
        static int Course3ThirdPriority = 0;
        static int Course4ThirdPriority = 0;
        static int Course5ThirdPriority = 0;
        static int[] sortieren = new int[5];
        static int[] keinSortieren = new int[5];
        static List<int> endAuswahl = new List<int>();
        static void Main(string[] args)
        {
            AskForUserInformation();

            EnoughUsers();
            Rating();

            SpeichernPfad();
            Schreiben(pfad);
            Schreiben("");

            for (int i = 0; i < registeredFavourites / 3; i++)
            {
                Schreiben(namen[i]);
                for (int b = 0; b < 3; b++) { Schreiben("Kurs " + (b + 1) + ": " + auswahlderkurse[(i * 3) + b]); }
                Schreiben("");
            }
            
            int coursesTakingPlace = Convert.ToInt32((registeredFavourites / 3) / 4);
            if (coursesTakingPlace > 5) { coursesTakingPlace = 5; }
            for (int i = 0; i < coursesTakingPlace; i++)
            {
                for (int b = 0; b < 5; b++)
                {
                    if (sortieren[i] == keinSortieren[b])
                    {
                        endAuswahl.Add(b + 1);
                        keinSortieren[b] = -1;
                        break;
                    }
                }
            }

            allocateFirstPriority();
            allocateSecondPriority();
            allocateThirdPriority();

            allocateUsersToCourses();

            moveUsersCourse1();
            moveUsersCourse2();
            moveUsersCourse3();
            moveUsersCourse4();
            moveUsersCourse5();

            Tie();

            for (int i = 0; i < sortieren.Length; i++)
            {
                Console.WriteLine(sortieren[i]);
            }
            Console.Clear();
            EndresultateAnzeigen();
        }
        static void AskForUserInformation()
        {
            while (true)
            {
                Console.WriteLine("Wählen Sie zwischen Ihren Kursen aus.");
                Console.WriteLine("[1] - Volleyball");
                Console.WriteLine("[2] - Fusball");
                Console.WriteLine("[3] - Tischtennis");
                Console.WriteLine("[4] - Golf");
                Console.WriteLine("[5] - Schwimmen");
                Console.WriteLine("");
                int e1 = 0;
                int e2 = 0;
                int e3 = 0;
                Console.Write("Benutzer " + (registeredFavourites / 3 + 1) + ": Bitte geben Sie Ihren Namen ein: ");
                Console.WriteLine("");
                namen.Add(Console.ReadLine());

                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        Console.Write(namen[registeredFavourites / 3] + " > Kurs " + (i + 1) + " auswählen: ");
                        int eingabe = Convert.ToInt32(Console.ReadLine());
                        if (eingabe >= 1 && eingabe <= 5)
                        {
                            switch (i)
                            {
                                case 0:
                                    e1 = eingabe; break;
                                case 1:
                                    e2 = eingabe;
                                    if (e2 == e1) { throw new Exception(); }
                                    break;
                                case 2:
                                    e3 = eingabe;
                                    if (e3 == e1 || e3 == e2) { throw new Exception(); }
                                    break;
                                default: break;
                            }
                        }
                        else { throw new Exception(); }
                        if (i == 0)
                        {
                            switch (eingabe)
                            {
                                case 1:
                                    if (Course1FirstPriority < 5) { Course1FirstPriority++; }
                                    break;
                                case 2:
                                    if (Course2FirstPriority < 5) { Course2FirstPriority++; }
                                    break;
                                case 3:
                                    if (Course3FirstPriority < 5) { Course3FirstPriority++; }
                                    break;
                                case 4:
                                    if (Course4FirstPriority < 5) { Course4FirstPriority++; }
                                    break;
                                case 5:
                                    if (Course5FirstPriority < 5) { Course5FirstPriority++; }
                                    break;
                                default: break;
                            }
                        }
                        if (i == 1)
                        {
                            switch (eingabe)
                            {
                                case 1:
                                    if (Course1SecondPriority < 5) { Course1SecondPriority++; }
                                    break;
                                case 2:
                                    if (Course2SecondPriority < 5) { Course2SecondPriority++; }
                                    break;
                                case 3:
                                    if (Course3SecondPriority < 5) { Course3SecondPriority++; }
                                    break;
                                case 4:
                                    if (Course4SecondPriority < 5) { Course4SecondPriority++; }
                                    break;
                                case 5:
                                    if (Course5SecondPriority < 5) { Course5SecondPriority++; }
                                    break;
                                default: break;
                            }
                        }
                        if (i == 2)
                        {
                            switch (eingabe)
                            {
                                case 1:
                                    if (Course1ThirdPriority < 5) { Course1ThirdPriority++; }
                                    break;
                                case 2:
                                    if (Course2ThirdPriority < 5) { Course2ThirdPriority++; }
                                    break;
                                case 3:
                                    if (Course3ThirdPriority < 5) { Course3ThirdPriority++; }
                                    break;
                                case 4:
                                    if (Course4ThirdPriority < 5) { Course4ThirdPriority++; }
                                    break;
                                case 5:
                                    if (Course5ThirdPriority < 5) { Course5ThirdPriority++; }
                                    break;
                                default: break;
                            }
                        }
                        auswahlderkurse.Add(eingabe);
                        registeredFavourites++;
                    }
                    catch
                    {
                        i--;
                        Console.WriteLine("Falsche Eingabe");
                    }
                }
                if (registeredFavourites / 3 >= 100) { Console.WriteLine("Teilnehmerlimit (100) erreicht."); break; }
                Console.WriteLine("");
                Console.Write("Möchten Sie einen weiteren Benutzer hinzufügen? [y/n] ");
                if (Console.ReadLine() == "y") { }
                else { break; }
                Console.WriteLine("");
            }
        }
        static void EnoughUsers()
        {
            if (registeredFavourites / 3 < 4)
            {
                Console.WriteLine("");
                Console.WriteLine("Es haben sich zu wenig Teilnehmer angemeldet.");
                Console.WriteLine("Um einen Kurs stattfinden zu lassen sind mindestens 4 Anmeldungen erforderlich.");
                System.Environment.Exit(1);
            }
        }
        
        static void Rating()
        {
            for (int i = 0; i < sortieren.Length; i++) { sortieren[i] = 0; }
            for (int i = 0; i < keinSortieren.Length; i++) { keinSortieren[i] = 0; }
            if (Course1FirstPriority + Course1SecondPriority + Course1ThirdPriority >= 4) { sortieren[0] = (Course1FirstPriority * 3 + Course1SecondPriority * 2 + Course1ThirdPriority); keinSortieren[0] = (Course1FirstPriority * 3 + Course1SecondPriority * 2 + Course1ThirdPriority); }
            if (Course2FirstPriority + Course2SecondPriority + Course2ThirdPriority >= 4) { sortieren[1] = (Course2FirstPriority * 3 + Course2SecondPriority * 2 + Course2ThirdPriority); keinSortieren[1] = (Course2FirstPriority * 3 + Course2SecondPriority * 2 + Course2ThirdPriority); }
            if (Course3FirstPriority + Course3SecondPriority + Course3ThirdPriority >= 4) { sortieren[2] = (Course3FirstPriority * 3 + Course3SecondPriority * 2 + Course3ThirdPriority); keinSortieren[2] = (Course3FirstPriority * 3 + Course3SecondPriority * 2 + Course3ThirdPriority); }
            if (Course4FirstPriority + Course4SecondPriority + Course4ThirdPriority >= 4) { sortieren[3] = (Course4FirstPriority * 3 + Course4SecondPriority * 2 + Course4ThirdPriority); keinSortieren[3] = (Course4FirstPriority * 3 + Course4SecondPriority * 2 + Course4ThirdPriority); }
            if (Course5FirstPriority + Course5SecondPriority + Course5ThirdPriority >= 4) { sortieren[4] = (Course5FirstPriority * 3 + Course5SecondPriority * 2 + Course5ThirdPriority); keinSortieren[4] = (Course5FirstPriority * 3 + Course5SecondPriority * 2 + Course5ThirdPriority); }

            Array.Sort(sortieren);
            Array.Reverse(sortieren);
        }
        
        static void allocateFirstPriority()
        {
            for (int i = 0; i < coursesTakingPlace; i++)
            {
                int sprung = 0;
                for (int b = 0; b < (registeredFavourites / 3); b++)
                {
                    if (auswahlderkurse[sprung] == endAuswahl[i])
                    {
                        switch (endAuswahl[i])
                        {
                            case 1:
                                participantsCourse1.Add(b);
                                course1TakingPlace = 1; break;
                            case 2:
                                participantsCourse2.Add(b);
                                course2TakingPlace = 1; break;
                            case 3:
                                participantsCourse3.Add(b);
                                course3TakingPlace = 1; break;
                            case 4:
                                participantsCourse4.Add(b);
                                course4TakingPlace = 1; break;
                            case 5:
                                participantsCourse5.Add(b);
                                course5TakingPlace = 1; break;
                            default: break;
                        }
                        auswahlderkurse[sprung] = -1;
                        auswahlderkurse[sprung + 1] = -1;
                        auswahlderkurse[sprung + 2] = -1;
                    }
                    sprung = sprung + 3;
                }
            }
        }
        static void allocateSecondPriority()
        {
            for (int i = 0; i < coursesTakingPlace; i++) //So oft wie es Kurse hat
            {
                int sprung = 1;
                for (int b = 0; b < (registeredFavourites / 3); b++) //So oft wie es Benutzer hat
                {
                    if (auswahlderkurse[sprung] == endAuswahl[i]) //Wenn die Erstwahl des Teilnehmers = einer der stattfindenden Kurse ist
                    {
                        switch (endAuswahl[i])
                        {
                            case 1:
                                participantsCourse1.Add(b);
                                course1TakingPlace = 1; break;
                            case 2:
                                participantsCourse2.Add(b);
                                course2TakingPlace = 1; break;
                            case 3:
                                participantsCourse3.Add(b);
                                course3TakingPlace = 1; break;
                            case 4:
                                participantsCourse4.Add(b);
                                course4TakingPlace = 1; break;
                            case 5:
                                participantsCourse5.Add(b);
                                course5TakingPlace = 1; break;
                            default: break;
                        }
                        auswahlderkurse[sprung - 1] = -1;
                        auswahlderkurse[sprung] = -1;
                        auswahlderkurse[sprung + 1] = -1;
                    }
                    sprung = sprung + 3;
                }
            }
        }
        static void allocateThirdPriority()
        {
            for (int i = 0; i < coursesTakingPlace; i++) //So oft wie es Kurse hat
            {
                int sprung = 2;
                for (int b = 0; b < (registeredFavourites / 3); b++) //So oft wie es Benutzer hat
                {
                    if (auswahlderkurse[sprung] == endAuswahl[i]) //Wenn die Erstwahl des Teilnehmers = einer der stattfindenden Kurse ist
                    {
                        switch (endAuswahl[i])
                        {
                            case 1:
                                participantsCourse1.Add(b);
                                course1TakingPlace = 1; break;
                            case 2:
                                participantsCourse2.Add(b);
                                course2TakingPlace = 1; break;
                            case 3:
                                participantsCourse3.Add(b);
                                course3TakingPlace = 1; break;
                            case 4:
                                participantsCourse4.Add(b);
                                course4TakingPlace = 1; break;
                            case 5:
                                participantsCourse5.Add(b);
                                course5TakingPlace = 1; break;
                            default: break;
                        }
                        auswahlderkurse[sprung - 2] = -1;
                        auswahlderkurse[sprung - 1] = -1;
                        auswahlderkurse[sprung] = -1;
                    }
                    sprung = sprung + 3;
                }
            }
        }
        static int coursesTakingPlace = 0;

        static void allocateUsersToCourses()
        {
            for (int i = 0; i < coursesTakingPlace; i++)
            {
                int sprung = 2;
                for (int b = 0; b < (registeredFavourites / 3); b++)
                {
                    if (auswahlderkurse[sprung] == endAuswahl[i])
                    {
                        switch (endAuswahl[i])
                        {
                            case 1:
                                participantsCourse1.Add(b);
                                course1TakingPlace = 1; break;
                            case 2:
                                participantsCourse2.Add(b);
                                course2TakingPlace = 1; break;
                            case 3:
                                participantsCourse3.Add(b);
                                course3TakingPlace = 1; break;
                            case 4:
                                participantsCourse4.Add(b);
                                course4TakingPlace = 1; break;
                            case 5:
                                participantsCourse5.Add(b);
                                course5TakingPlace = 1; break;
                            default: break;
                        }
                        auswahlderkurse[sprung - 2] = -1;
                        auswahlderkurse[sprung - 1] = -1;
                        auswahlderkurse[sprung] = -1;
                    }
                    sprung = sprung + 3;
                }
            }
        }

        static void moveUsersCourse1()
        {
            if (course1TakingPlace == 1)
            {
                if (participantsCourse1.Count < 4)
                {
                    course1TakingPlace = 0;
                    for (int i = 0; i < participantsCourse1.Count; i++)
                    {
                        switch (BerechneKleinstenKurs())
                        {
                            case 2:
                                participantsCourse2.Add(participantsCourse1[i]); break;
                            case 3:
                                participantsCourse3.Add(participantsCourse1[i]); break;
                            case 4:
                                participantsCourse4.Add(participantsCourse1[i]); break;
                            case 5:
                                participantsCourse5.Add(participantsCourse1[i]); break;
                        }
                    }
                    participantsCourse1.Clear();
                }
            }
        }
        static void moveUsersCourse2()
        {
            if (course2TakingPlace == 1)
            {
                if (participantsCourse2.Count < 4)
                {
                    course2TakingPlace = 0;
                    for (int i = 0; i < participantsCourse2.Count; i++)
                    {
                        switch (BerechneKleinstenKurs())
                        {
                            case 1:
                                participantsCourse1.Add(participantsCourse2[i]); break;
                            case 3:
                                participantsCourse3.Add(participantsCourse2[i]); break;
                            case 4:
                                participantsCourse4.Add(participantsCourse2[i]); break;
                            case 5:
                                participantsCourse5.Add(participantsCourse2[i]); break;
                        }
                    }
                    participantsCourse2.Clear();
                }
            }
        }
        static void moveUsersCourse3()
        {
            if (course3TakingPlace == 1)
            {
                if (participantsCourse3.Count < 4)
                {
                    course3TakingPlace = 0;
                    for (int i = 0; i < participantsCourse3.Count; i++)
                    {
                        switch (BerechneKleinstenKurs())
                        {
                            case 1:
                                participantsCourse1.Add(participantsCourse3[i]); break;
                            case 2:
                                participantsCourse2.Add(participantsCourse3[i]); break;
                            case 4:
                                participantsCourse4.Add(participantsCourse3[i]); break;
                            case 5:
                                participantsCourse5.Add(participantsCourse3[i]); break;
                        }
                    }
                    participantsCourse3.Clear();
                }
            }
        }
        static void moveUsersCourse4()
        {
            if (course4TakingPlace == 1)
            {
                if (participantsCourse4.Count < 4)
                {
                    course4TakingPlace = 0;
                    for (int i = 0; i < participantsCourse4.Count; i++)
                    {
                        switch (BerechneKleinstenKurs())
                        {
                            case 1:
                                participantsCourse1.Add(participantsCourse4[i]); break;
                            case 2:
                                participantsCourse2.Add(participantsCourse4[i]); break;
                            case 3:
                                participantsCourse3.Add(participantsCourse4[i]); break;
                            case 5:
                                participantsCourse5.Add(participantsCourse4[i]); break;
                        }
                    }
                    participantsCourse4.Clear();
                }
            }
        }
        static void moveUsersCourse5()
        {
            if (course5TakingPlace == 1)
            {
                if (participantsCourse5.Count < 4)
                {
                    course5TakingPlace = 0;
                    for (int i = 0; i < participantsCourse5.Count; i++)
                    {
                        switch (BerechneKleinstenKurs())
                        {
                            case 1:
                                participantsCourse1.Add(participantsCourse5[i]); break;
                            case 2:
                                participantsCourse2.Add(participantsCourse5[i]); break;
                            case 3:
                                participantsCourse3.Add(participantsCourse5[i]); break;
                            case 4:
                                participantsCourse4.Add(participantsCourse5[i]); break;
                        }
                    }
                    participantsCourse5.Clear();
                }
            }
        }

        static void Tie()
        {
            if (participantsCourse1.Count == 0 && participantsCourse2.Count == 0 && participantsCourse3.Count == 0 && participantsCourse4.Count == 0 && participantsCourse5.Count == 0)
            {
                Random random = new System.Random();
                int rndzahl = random.Next(0, 5);
                Console.WriteLine("Random");
                Console.ReadLine();
                for (int i = 0; i < (registeredFavourites / 3); i++)
                {
                    switch (rndzahl)
                    {
                        case 0:
                            participantsCourse1.Add(i); break;
                        case 1:
                            participantsCourse2.Add(i); break;
                        case 2:
                            participantsCourse3.Add(i); break;
                        case 3:
                            participantsCourse4.Add(i); break;
                        case 4:
                            participantsCourse5.Add(i); break;
                        default: break;
                    }
                }
            }
        }
        
        static void EndresultateAnzeigen()
        {
            //DATEI ERSTELLEN - WAS?
            Console.WriteLine("ZUTEILUNG ABGESCHLOSSEN - AUSWERTUNG: ");
            Console.WriteLine("");
            if (participantsCourse1.Count >= 1)
            {
                Console.WriteLine("TEILNEHMENDE KURS 1");
                Schreiben("TEILNEHMENDE KURS 1");
                for (int i = 0; i < participantsCourse1.Count; i++)
                {
                    Console.Write(namen[participantsCourse1[i]] + ", ");
                    Schreiben(namen[participantsCourse1[i]]);
                }
                Console.WriteLine("");
            }
            if (participantsCourse2.Count >= 1)
            {
                Console.WriteLine("TEILNEHMENDE KURS 2");
                Schreiben("TEILNEHMENDE KURS 2");
                for (int i = 0; i < participantsCourse2.Count; i++)
                {
                    Console.Write(namen[participantsCourse2[i]] + ", ");
                    Schreiben(namen[participantsCourse2[i]]);
                }
                Console.WriteLine("");
            }
            if (participantsCourse3.Count >= 1)
            {
                Console.WriteLine("TEILNEHMENDE KURS 3");
                Schreiben("TEILNEHMENDE KURS 3");
                for (int i = 0; i < participantsCourse3.Count; i++)
                {
                    Console.Write(namen[participantsCourse3[i]] + ", ");
                    Schreiben(namen[participantsCourse3[i]]);
                }
                Console.WriteLine("");
            }
            if (participantsCourse4.Count >= 1)
            {
                Console.WriteLine("TEILNEHMENDE KURS 4");
                Schreiben("TEILNEHMENDE KURS 4");
                for (int i = 0; i < participantsCourse4.Count; i++)
                {
                    Console.Write(namen[participantsCourse4[i]] + ", ");
                    Schreiben(namen[participantsCourse4[i]]);
                }
                Console.WriteLine("");
            }
            if (participantsCourse5.Count >= 1)
            {
                Console.WriteLine("TEILNEHMENDE KURS 5");
                Schreiben("TEILNEHMENDE KURS 5");
                for (int i = 0; i < participantsCourse5.Count; i++)
                {
                    Console.Write(namen[participantsCourse5[i]] + ", ");
                    Schreiben(namen[participantsCourse5[i]]);
                }
            }
        }
        static string SpeichernPfad()
        {
            while (true)
            {
                try
                {
                    Console.Write("Dateispeicherort der Ausgabe: ");
                    pfad = Console.ReadLine();
                    if (File.Exists(pfad))
                    {
                        Console.Write("Datei überschreiben? [y/n] ");
                        if (Console.ReadLine() == "y") { }
                        else { throw new Exception(); }
                    }
                    try
                    {
                        using (StreamWriter sw = File.CreateText(pfad)) { }
                        if (Directory.Exists(@pfad) || File.Exists(@pfad))
                        { Console.WriteLine("Path is valid."); break; }
                        else { throw new Exception(); }
                    }
                    catch { Console.WriteLine("Ungültiger Dateipfad"); }
                }
                catch { Console.Write("Erneute Eingabe: "); }
            }
            Console.ReadLine();
            return pfad;
        }
        static void Schreiben(string eingabe)
        {
            using (StreamWriter sw = File.AppendText(pfad)) { sw.WriteLine(eingabe); }
        }
        static int BerechneKleinstenKurs()
        {
            int[] amWenigsten = new int[5];
            int[] amWenigstenNS = new int[5];
            if(course1TakingPlace == 1) { amWenigsten[0] = participantsCourse1.Count; amWenigstenNS[0] = participantsCourse1.Count; }
            else { amWenigsten[0] = 9999999; }
            if(course2TakingPlace == 1) { amWenigsten[1] = participantsCourse2.Count; amWenigstenNS[1] = participantsCourse2.Count; }
            else { amWenigsten[1] = 9999999; }
            if (course3TakingPlace == 1) { amWenigsten[2] = participantsCourse3.Count; amWenigstenNS[2] = participantsCourse3.Count; }
            else { amWenigsten[2] = 9999999; }
            if (course4TakingPlace == 1) { amWenigsten[3] = participantsCourse4.Count; amWenigstenNS[3] = participantsCourse4.Count; }
            else { amWenigsten[3] = 9999999; }
            if (course5TakingPlace == 1) { amWenigsten[4] = participantsCourse5.Count; amWenigstenNS[4] = participantsCourse5.Count; }
            else { amWenigsten[4] = 9999999; }

            Array.Sort(amWenigsten); //z.B.: -1,  -1,  -1,  4,  5
                                     //z.B.: 0,   1,   0,   4,  3

            int kleinsterKurs = 0;

            for (int i = 0; i < amWenigsten.Length; i++) { if (amWenigsten[0] == amWenigstenNS[i]) { kleinsterKurs = i; } }
            Console.WriteLine("Am kleinsten (NEU) ist: " + kleinsterKurs+1);
            return kleinsterKurs+1;
        }
    }
}