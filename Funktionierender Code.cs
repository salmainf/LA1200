namespace testbackup
{
    internal class Program
    {
        static List<int> teilnehmerKurs1 = new List<int>();
        static List<int> teilnehmerKurs2 = new List<int>();
        static List<int> teilnehmerKurs3 = new List<int>();
        static List<int> teilnehmerKurs4 = new List<int>();
        static List<int> teilnehmerKurs5 = new List<int>();
        static List<string> namen = new List<string>();
        static int findet1statt = 0;
        static int findet2statt = 0;
        static int findet3statt = 0;
        static int findet4statt = 0;
        static int findet5statt = 0;
        static string pfad = "";

        static void Main(string[] args)
        {
            List<int> auswahlderkurse = new List<int>();
            int durchlauf = 0;
            int wahl1 = 0;
            int wahl2 = 0;
            int wahl3 = 0;
            int wahl4 = 0;
            int wahl5 = 0;
            int wahl1_2 = 0;
            int wahl2_2 = 0;
            int wahl3_2 = 0;
            int wahl4_2 = 0;
            int wahl5_2 = 0;
            int wahl1_3 = 0;
            int wahl2_3 = 0;
            int wahl3_3 = 0;
            int wahl4_3 = 0;
            int wahl5_3 = 0;

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
                Console.Write("Benutzer " + (durchlauf / 3 + 1) + ": Bitte geben Sie Ihren Namen ein: ");
                Console.WriteLine("");
                namen.Add(Console.ReadLine());
                //Fragen Kursen
                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        Console.Write(namen[durchlauf / 3] + " > Kurs " + (i + 1) + " auswählen: ");
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
                                    if (wahl1 < 5) { wahl1++; }
                                    break;
                                case 2:
                                    if (wahl2 < 5) { wahl2++; }
                                    break;
                                case 3:
                                    if (wahl3 < 5) { wahl3++; }
                                    break;
                                case 4:
                                    if (wahl4 < 5) { wahl4++; }
                                    break;
                                case 5:
                                    if (wahl5 < 5) { wahl5++; }
                                    break;
                                default: break;
                            }
                        }
                        if (i == 1)
                        {
                            switch (eingabe)
                            {
                                case 1:
                                    if (wahl1_2 < 5) { wahl1_2++; }
                                    break;
                                case 2:
                                    if (wahl2_2 < 5) { wahl2_2++; }
                                    break;
                                case 3:
                                    if (wahl3_2 < 5) { wahl3_2++; }
                                    break;
                                case 4:
                                    if (wahl4_2 < 5) { wahl4_2++; }
                                    break;
                                case 5:
                                    if (wahl5_2 < 5) { wahl5_2++; }
                                    break;
                                default: break;
                            }
                        }
                        if (i == 2)
                        {
                            switch (eingabe)
                            {
                                case 1:
                                    if (wahl1_3 < 5) { wahl1_3++; }
                                    break;
                                case 2:
                                    if (wahl2_3 < 5) { wahl2_3++; }
                                    break;
                                case 3:
                                    if (wahl3_3 < 5) { wahl3_3++; }
                                    break;
                                case 4:
                                    if (wahl4_3 < 5) { wahl4_3++; }
                                    break;
                                case 5:
                                    if (wahl5_3 < 5) { wahl5_3++; }
                                    break;
                                default: break;
                            }
                        }
                        auswahlderkurse.Add(eingabe);
                        durchlauf++;
                    }
                    catch
                    {
                        i--;
                        Console.WriteLine("Falsche Eingabe");
                    }
                }
                if (durchlauf / 3 >= 100) { Console.WriteLine("Teilnehmerlimit (100) erreicht."); break; }
                Console.WriteLine("");
                Console.Write("Möchten Sie einen weiteren Benutzer hinzufügen? [y/n] ");
                if (Console.ReadLine() == "y") { }
                else { break; }
                Console.WriteLine("");
            }
            //WENN SICH ZU WENIG LEUTE ANGEMELDET HABEN DANN KANN GAR KEIN KURS STATTFINDEN: FEHLER
            if (durchlauf / 3 < 4)
            {
                Console.WriteLine("");
                Console.WriteLine("Es haben sich zu wenig Teilnehmer angemeldet.");
                Console.WriteLine("Um einen Kurs stattfinden zu lassen sind mindestens 4 Anmeldungen erforderlich.");
                System.Environment.Exit(1);
            }
            int[] sortieren = new int[5];
            for (int i = 0; i < sortieren.Length; i++) { sortieren[i] = 0; }

            //DATEI ERSTELLEN - WO?
            SpeichernPfad();
            Schreiben(pfad);
            Schreiben("");

            for (int i = 0; i < durchlauf / 3; i++)
            {
                Schreiben(namen[i]);
                for (int b = 0; b < 3; b++) { Schreiben("Kurs " + (b + 1) + ": " + auswahlderkurse[(i * 3) + b]); }
                Schreiben("");
            }

            int[] keinSortieren = new int[5];
            for (int i = 0; i < keinSortieren.Length; i++) { keinSortieren[i] = 0; }
            if (wahl1 + wahl1_2 + wahl1_3 >= 4) { sortieren[0] = (wahl1 * 3 + wahl1_2 * 2 + wahl1_3); keinSortieren[0] = (wahl1 * 3 + wahl1_2 * 2 + wahl1_3); }
            if (wahl2 + wahl2_2 + wahl2_3 >= 4) { sortieren[1] = (wahl2 * 3 + wahl2_2 * 2 + wahl2_3); keinSortieren[1] = (wahl2 * 3 + wahl2_2 * 2 + wahl2_3); }
            if (wahl3 + wahl3_2 + wahl3_3 >= 4) { sortieren[2] = (wahl3 * 3 + wahl3_2 * 2 + wahl3_3); keinSortieren[2] = (wahl3 * 3 + wahl3_2 * 2 + wahl3_3); }
            if (wahl4 + wahl4_2 + wahl4_3 >= 4) { sortieren[3] = (wahl4 * 3 + wahl4_2 * 2 + wahl4_3); keinSortieren[3] = (wahl4 * 3 + wahl4_2 * 2 + wahl4_3); }
            if (wahl5 + wahl5_2 + wahl5_3 >= 4) { sortieren[4] = (wahl5 * 3 + wahl5_2 * 2 + wahl5_3); keinSortieren[4] = (wahl5 * 3 + wahl5_2 * 2 + wahl5_3); }

            Array.Sort(sortieren);
            Array.Reverse(sortieren);

            int[] endAuswahl = new int[(durchlauf / 3)];

            int stattfindendeKurse = Convert.ToInt32((durchlauf / 3) / 4);
            if (stattfindendeKurse > 5) { stattfindendeKurse = 5; }
            for (int i = 0; i < stattfindendeKurse; i++)
            {
                for (int b = 0; b < 5; b++)
                {
                    if (sortieren[i] == keinSortieren[b])
                    {
                        //Speichere Kurs in Variable
                        endAuswahl[i] = b + 1;
                        keinSortieren[b] = -1;
                        break;
                    }
                }
            }

            //ZUTEILUNG NACH ERSTER PRIORITÄT //NACH ZUTEILUNG MÜSSEN DIE TEILNEHMER AUS DER LISTE GELÖSCHT WERDEN, UM NICHT AUCH BEI IHRER 2.&3. WAHL ZUGETEILT ZU WERDEN
            for (int i = 0; i < stattfindendeKurse; i++) //So oft wie es Kurse hat
            {
                int sprung = 0;
                for (int b = 0; b < (durchlauf / 3); b++) //So oft wie es Benutzer hat
                {
                    if (auswahlderkurse[sprung] == endAuswahl[i]) //Wenn die Erstwahl des Teilnehmers = einer der stattfindenden Kurse ist
                    {
                        switch (endAuswahl[i])
                        {
                            case 1:
                                teilnehmerKurs1.Add(b);
                                findet1statt = 1; break;
                            case 2:
                                teilnehmerKurs2.Add(b);
                                findet2statt = 1; break;
                            case 3:
                                teilnehmerKurs3.Add(b);
                                findet3statt = 1; break;
                            case 4:
                                teilnehmerKurs4.Add(b);
                                findet4statt = 1; break;
                            case 5:
                                teilnehmerKurs5.Add(b);
                                findet5statt = 1; break;
                            default: break;
                        }
                        auswahlderkurse[sprung] = -1;
                        auswahlderkurse[sprung + 1] = -1;
                        auswahlderkurse[sprung + 2] = -1;
                    }
                    sprung = sprung + 3;
                }
            }
            //ZUTEILUNG NACH ZWEITER PRIORITÄT //NACH ZUTEILUNG MÜSSEN DIE TEILNEHMER AUS DER LISTE GELÖSCHT WERDEN, UM NICHT AUCH BEI IHRER 2.&3. WAHL ZUGETEILT ZU WERDEN
            for (int i = 0; i < stattfindendeKurse; i++) //So oft wie es Kurse hat
            {
                int sprung = 1;
                for (int b = 0; b < (durchlauf / 3); b++) //So oft wie es Benutzer hat
                {
                    if (auswahlderkurse[sprung] == endAuswahl[i]) //Wenn die Erstwahl des Teilnehmers = einer der stattfindenden Kurse ist
                    {
                        switch (endAuswahl[i])
                        {
                            case 1:
                                teilnehmerKurs1.Add(b);
                                findet1statt = 1; break;
                            case 2:
                                teilnehmerKurs2.Add(b);
                                findet2statt = 1; break;
                            case 3:
                                teilnehmerKurs3.Add(b);
                                findet3statt = 1; break;
                            case 4:
                                teilnehmerKurs4.Add(b);
                                findet4statt = 1; break;
                            case 5:
                                teilnehmerKurs5.Add(b);
                                findet5statt = 1; break;
                            default: break;
                        }
                        auswahlderkurse[sprung - 1] = -1;
                        auswahlderkurse[sprung] = -1;
                        auswahlderkurse[sprung + 1] = -1;
                    }
                    sprung = sprung + 3;
                }
            }
            //ZUTEILUNG NACH DRITTER PRIORITÄT //NACH ZUTEILUNG MÜSSEN DIE TEILNEHMER AUS DER LISTE GELÖSCHT WERDEN, UM NICHT AUCH BEI IHRER 2.&3. WAHL ZUGETEILT ZU WERDEN
            for (int i = 0; i < stattfindendeKurse; i++) //So oft wie es Kurse hat
            {
                int sprung = 2;
                for (int b = 0; b < (durchlauf / 3); b++) //So oft wie es Benutzer hat
                {
                    if (auswahlderkurse[sprung] == endAuswahl[i]) //Wenn die Erstwahl des Teilnehmers = einer der stattfindenden Kurse ist
                    {
                        switch (endAuswahl[i])
                        {
                            case 1:
                                teilnehmerKurs1.Add(b);
                                findet1statt = 1; break;
                            case 2:
                                teilnehmerKurs2.Add(b);
                                findet2statt = 1; break;
                            case 3:
                                teilnehmerKurs3.Add(b);
                                findet3statt = 1; break;
                            case 4:
                                teilnehmerKurs4.Add(b);
                                findet4statt = 1; break;
                            case 5:
                                teilnehmerKurs5.Add(b);
                                findet5statt = 1; break;
                            default: break;
                        }
                        auswahlderkurse[sprung - 2] = -1;
                        auswahlderkurse[sprung - 1] = -1;
                        auswahlderkurse[sprung] = -1;
                    }
                    sprung = sprung + 3;
                }
            }

            //ÜBERPRÜFEN OB JEDER KURS DIE MINDESTTEILNEHMER ANZAHL ERREICHT HAT
            //WENN JA = NICHTS MACHEN
            //WENN NEIN = ALLE TEILNEHMER AUS DEM KURS IN DEN KURS MIT DEN WENIGSTEN TEILNEHMERN REINTUN
            if (findet1statt == 1) //WENN DER KURS STATTFINDET
            {
                if (teilnehmerKurs1.Count < 4) //WENN DER KURS WENIGER ALS 4 TEILNEHMER HAT //DANN TEILE IN DEN KURS MIT DEN WENIGSTEN TEINEHMERN ZU
                {
                    findet1statt = 0;
                    for (int i = 0; i < teilnehmerKurs1.Count; i++)
                    {
                        switch (BerechneKleinstenKurs())
                        {
                            case 2:
                                teilnehmerKurs2.Add(teilnehmerKurs1[i]); break;
                            case 3:
                                teilnehmerKurs3.Add(teilnehmerKurs1[i]); break;
                            case 4:
                                teilnehmerKurs4.Add(teilnehmerKurs1[i]); break;
                            case 5:
                                teilnehmerKurs5.Add(teilnehmerKurs1[i]); break;
                        }
                    }
                    teilnehmerKurs1.Clear();
                }
            }
            if (findet2statt == 1) //WENN DER KURS STATTFINDET
            {
                if (teilnehmerKurs2.Count < 4) //WENN DER KURS WENIGER ALS 4 TEILNEHMER HAT //DANN TEILE IN DEN KURS MIT DEN WENIGSTEN TEINEHMERN ZU
                {
                    findet2statt = 0;
                    for (int i = 0; i < teilnehmerKurs2.Count; i++)
                    {
                        switch (BerechneKleinstenKurs())
                        {
                            case 1:
                                teilnehmerKurs1.Add(teilnehmerKurs2[i]); break;
                            case 3:
                                teilnehmerKurs3.Add(teilnehmerKurs2[i]); break;
                            case 4:
                                teilnehmerKurs4.Add(teilnehmerKurs2[i]); break;
                            case 5:
                                teilnehmerKurs5.Add(teilnehmerKurs2[i]); break;
                        }
                    }
                    teilnehmerKurs2.Clear();
                }
            }
            if (findet3statt == 1) //WENN DER KURS STATTFINDET
            {
                if (teilnehmerKurs3.Count < 4) //WENN DER KURS WENIGER ALS 4 TEILNEHMER HAT //DANN TEILE IN DEN KURS MIT DEN WENIGSTEN TEINEHMERN ZU
                {
                    findet3statt = 0;
                    for (int i = 0; i < teilnehmerKurs3.Count; i++)
                    {
                        switch (BerechneKleinstenKurs())
                        {
                            case 1:
                                teilnehmerKurs1.Add(teilnehmerKurs3[i]); break;
                            case 2:
                                teilnehmerKurs2.Add(teilnehmerKurs3[i]); break;
                            case 4:
                                teilnehmerKurs4.Add(teilnehmerKurs3[i]); break;
                            case 5:
                                teilnehmerKurs5.Add(teilnehmerKurs3[i]); break;
                        }
                    }
                    teilnehmerKurs3.Clear();
                }
            }
            if (findet4statt == 1) //WENN DER KURS STATTFINDET
            {
                if (teilnehmerKurs4.Count < 4) //WENN DER KURS WENIGER ALS 4 TEILNEHMER HAT //DANN TEILE IN DEN KURS MIT DEN WENIGSTEN TEINEHMERN ZU
                {
                    findet4statt = 0;
                    for (int i = 0; i < teilnehmerKurs4.Count; i++)
                    {
                        switch (BerechneKleinstenKurs())
                        {
                            case 1:
                                teilnehmerKurs1.Add(teilnehmerKurs4[i]); break;
                            case 2:
                                teilnehmerKurs2.Add(teilnehmerKurs4[i]); break;
                            case 3:
                                teilnehmerKurs3.Add(teilnehmerKurs4[i]); break;
                            case 5:
                                teilnehmerKurs5.Add(teilnehmerKurs4[i]); break;
                        }
                    }
                    teilnehmerKurs4.Clear();
                }
            }
            if (findet5statt == 1) //WENN DER KURS STATTFINDET
            {
                if (teilnehmerKurs5.Count < 4) //WENN DER KURS WENIGER ALS 4 TEILNEHMER HAT //DANN TEILE IN DEN KURS MIT DEN WENIGSTEN TEINEHMERN ZU
                {
                    findet5statt = 0;
                    for (int i = 0; i < teilnehmerKurs5.Count; i++)
                    {
                        switch (BerechneKleinstenKurs())
                        {
                            case 1:
                                teilnehmerKurs1.Add(teilnehmerKurs5[i]); break;
                            case 2:
                                teilnehmerKurs2.Add(teilnehmerKurs5[i]); break;
                            case 3:
                                teilnehmerKurs3.Add(teilnehmerKurs5[i]); break;
                            case 4:
                                teilnehmerKurs4.Add(teilnehmerKurs5[i]); break;
                        }
                    }
                    teilnehmerKurs5.Clear();
                }
            }

            //WENN JEDER KURS GLEICH BELIEBT IST (DAS PROGRAMM ALSO KEINE ENTSCHEIDUNG TREFFEN KANN) WIRD EIN KURS ZUFÄLLIG AUSGEWÄHLT, WELCHER ANSCHLIESSEND STATTFINDET
            if (teilnehmerKurs1.Count == 0 && teilnehmerKurs2.Count == 0 && teilnehmerKurs3.Count == 0 && teilnehmerKurs4.Count == 0 && teilnehmerKurs5.Count == 0)
            {
                Console.WriteLine("ZUFALL");
                Random random = new System.Random();
                int rndzahl = random.Next(0, 5);
                for (int i = 0; i < (durchlauf / 3); i++)
                {
                    switch (rndzahl)
                    {
                        case 0:
                            teilnehmerKurs1.Add(i); break;
                        case 1:
                            teilnehmerKurs2.Add(i); break;
                        case 2:
                            teilnehmerKurs3.Add(i); break;
                        case 3:
                            teilnehmerKurs4.Add(i); break;
                        case 4:
                            teilnehmerKurs5.Add(i); break;
                        default: break;
                    }
                }

            }
            Console.Clear();
            EndresultateAnzeigen();

        }
        static void EndresultateAnzeigen()
        {
            //DATEI ERSTELLEN - WAS?
            Console.WriteLine("ZUTEILUNG ABGESCHLOSSEN - AUSWERTUNG: ");
            Console.WriteLine("");
            if (teilnehmerKurs1.Count >= 1)
            {
                Console.WriteLine("TEILNEHMENDE KURS 1");
                Schreiben("TEILNEHMENDE KURS 1");
                for (int i = 0; i < teilnehmerKurs1.Count; i++)
                {
                    Console.Write(namen[teilnehmerKurs1[i]] + ", ");
                    Schreiben(namen[teilnehmerKurs1[i]]);
                }
                Console.WriteLine("");
            }
            if (teilnehmerKurs2.Count >= 1)
            {
                Console.WriteLine("TEILNEHMENDE KURS 2");
                Schreiben("TEILNEHMENDE KURS 2");
                for (int i = 0; i < teilnehmerKurs2.Count; i++)
                {
                    Console.Write(namen[teilnehmerKurs2[i]] + ", ");
                    Schreiben(namen[teilnehmerKurs2[i]]);
                }
                Console.WriteLine("");
            }
            if (teilnehmerKurs3.Count >= 1)
            {
                Console.WriteLine("TEILNEHMENDE KURS 3");
                Schreiben("TEILNEHMENDE KURS 3");
                for (int i = 0; i < teilnehmerKurs3.Count; i++)
                {
                    Console.Write(namen[teilnehmerKurs3[i]] + ", ");
                    Schreiben(namen[teilnehmerKurs3[i]]);
                }
                Console.WriteLine("");
            }
            if (teilnehmerKurs4.Count >= 1)
            {
                Console.WriteLine("TEILNEHMENDE KURS 4");
                Schreiben("TEILNEHMENDE KURS 4");
                for (int i = 0; i < teilnehmerKurs4.Count; i++)
                {
                    Console.Write(namen[teilnehmerKurs4[i]] + ", ");
                    Schreiben(namen[teilnehmerKurs4[i]]);
                }
                Console.WriteLine("");
            }
            if (teilnehmerKurs5.Count >= 1)
            {
                Console.WriteLine("TEILNEHMENDE KURS 5");
                Schreiben("TEILNEHMENDE KURS 5");
                for (int i = 0; i < teilnehmerKurs5.Count; i++)
                {
                    Console.Write(namen[teilnehmerKurs5[i]] + ", ");
                    Schreiben(namen[teilnehmerKurs5[i]]);
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
            if (findet1statt == 1) { amWenigsten[0] = teilnehmerKurs1.Count; amWenigstenNS[0] = teilnehmerKurs1.Count; }
            else { amWenigsten[0] = 9999999; }
            if (findet2statt == 1) { amWenigsten[1] = teilnehmerKurs2.Count; amWenigstenNS[1] = teilnehmerKurs2.Count; }
            else { amWenigsten[1] = 9999999; }
            if (findet3statt == 1) { amWenigsten[2] = teilnehmerKurs3.Count; amWenigstenNS[2] = teilnehmerKurs3.Count; }
            else { amWenigsten[2] = 9999999; }
            if (findet4statt == 1) { amWenigsten[3] = teilnehmerKurs4.Count; amWenigstenNS[3] = teilnehmerKurs4.Count; }
            else { amWenigsten[3] = 9999999; }
            if (findet5statt == 1) { amWenigsten[4] = teilnehmerKurs5.Count; amWenigstenNS[4] = teilnehmerKurs5.Count; }
            else { amWenigsten[4] = 9999999; }

            Array.Sort(amWenigsten); //z.B.: -1,  -1,  -1,  4,  5
                                     //z.B.: 0,   1,   0,   4,  3

            int kleinsterKurs = 0;

            //WELCHER IST DER KLEINSTE KURS?                    //IST DER KURS MIT DEN WENIGSTEN TEILNEHMERN = KURS NR.[i] <-- (0-4)
            for (int i = 0; i < amWenigsten.Length; i++) { if (amWenigsten[0] == amWenigstenNS[i]) { kleinsterKurs = i; } }
            Console.WriteLine("Am kleinsten (NEU) ist: " + kleinsterKurs + 1);
            return kleinsterKurs + 1;
        }
    }
}
