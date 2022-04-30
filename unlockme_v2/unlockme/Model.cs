using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Data.SqlClient;
using System.Net;

namespace unlockme
{
    public class Model
    {
        public Model() { }
        public void CheckIfPatternFileExists()
        {
            /* Sprawdzenie, czy istnieje plik ze wzorem. Jeśli nie,
             * tworzymy plik o wzorze: 00,01,02,10,11 */

            if (!File.Exists("Current Pattern.xml"))
            {

                string defaultFileSize = "3x3";

                List<Field> defaultFileList = new List<Field> {

                    new Field { X = 0, Y = 0},
                    new Field { X = 0, Y = 1},
                    new Field { X = 0, Y = 2},
                    new Field { X = 1, Y = 0},
                    new Field { X = 1, Y = 1},

                };

                ChangePassword(defaultFileList, defaultFileSize);

            }
        }


        public bool ComparePatterns(List<Field> fieldList)
        {

            CheckIfPatternFileExists();

            /* Deserializacja danych z pliku, w którym mamy
             * zapisany obecny wzór blokady */

            StreamReader r = new StreamReader("Current Pattern.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(CurrentLockPattern));
            CurrentLockPattern pattern = (CurrentLockPattern)serializer.Deserialize(r);
            r.Close();

            /* Funkcja zwróci false jeśli wzory są różnych długości */


            if (fieldList.Count != pattern.Pattern.Count)
            {
                SendDataToServer("Sprawdzenie hasła (źle)");
                return false;
            }


            /* Funkcja zwróci false jeśli wzory są tej samej długości, ale ich
             * kolejne elementy nie będą się zgadzać */


            else
            {
                for (int i = 0; i < fieldList.Count; i++)
                {
                    if ((fieldList[i].X != pattern.Pattern[i].X) || (fieldList[i].Y != pattern.Pattern[i].Y))
                    {
                        SendDataToServer("Sprawdzenie hasła (źle)");
                        return false;
                    }
                }

                /* Funkcja zwróci true, jeśli przejdzie przez pętlę */

                SendDataToServer("Sprawdzenie hasła (dobrze)");
                return true;
            }
        }

        public bool ChangePasswordCompare(List<Field> fieldList1, List<Field> fieldList2)
        {
            if (fieldList1.Count != fieldList2.Count)
                return false;

            /* Funkcja zwróci false jeśli wzory są tej samej długości, ale ich
             * kolejne elementy nie będą się zgadzać */

            else
            {
                for (int i = 0; i < fieldList1.Count; i++)
                {
                    if ((fieldList1[i].X != fieldList2[i].X) || (fieldList1[i].Y != fieldList2[i].Y))
                        return false;
                }

                /* Funkcja zwróci true, jeśli przejdzie przez pętlę */

                return true;
            }
        }

        public void ChangePassword(List<Field> list, string size)
        {

            /* Serializacja obiektu, który przechowuje wielkość
             * planszy i wzór */

            CurrentLockPattern pattern = new CurrentLockPattern();
            pattern.Pattern = list;
            pattern.FieldSize = size;

            StreamWriter wr = new StreamWriter("Current Pattern.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(CurrentLockPattern));

            serializer.Serialize(wr, pattern);

            SendDataToServer("Zmiana hasła");

            wr.Flush();
            wr.Close();
        }

        public string CheckPatternSize()
        {

            CheckIfPatternFileExists();

            /* Deserializacja i sprawdzenie, czy mamy wyświetlić
             * panel 3x3 czy 4x4 */

            StreamReader r = new StreamReader("Current Pattern.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(CurrentLockPattern));
            CurrentLockPattern pattern = (CurrentLockPattern)serializer.Deserialize(r);
            r.Close();

            return pattern.FieldSize;
        }


        public bool StartsInCorner(List<Field> pattern, int size)
        {
            bool startsInCorner = false;
            if (size == 3)
            {
                if (
                    (pattern[0].X == 0 && pattern[0].Y == 0) ||
                    (pattern[0].X == 0 && pattern[0].Y == 2) ||
                    (pattern[0].X == 2 && pattern[0].Y == 0) ||
                    (pattern[0].X == 2 && pattern[0].Y == 2)
                    ) startsInCorner = true;

            }
            else if (size == 4)
            {
                if (
                    (pattern[0].X == 0 && pattern[0].Y == 0) ||
                    (pattern[0].X == 0 && pattern[0].Y == 3) ||
                    (pattern[0].X == 3 && pattern[0].Y == 0) ||
                    (pattern[0].X == 3 && pattern[0].Y == 3)
                    ) startsInCorner = true;
            }

            return startsInCorner;
        }
        public bool IsContinuous(List<Field> pattern)
        {
            if (pattern.Count <= 1) return true;
            bool isContinuous = false;
            for (int i = pattern.Count - 1; i >= 0; i--)
            {
                if (i > 0)
                {
                    if (
                        (pattern[i].X - pattern[i - 1].X == 0 && pattern[i].Y - pattern[i - 1].Y == 1) ||
                        (pattern[i].X - pattern[i - 1].X == 0 && pattern[i].Y - pattern[i - 1].Y == -1) ||
                        (pattern[i].X - pattern[i - 1].X == 1 && pattern[i].Y - pattern[i - 1].Y == 0) ||
                        (pattern[i].X - pattern[i - 1].X == -1 && pattern[i].Y - pattern[i - 1].Y == 0)
                        ) isContinuous = true;
                }
            }

            return isContinuous;
        }
        public bool CheckForM(List<Field> pattern)
        {
            bool letter = false;
            if (pattern[0].X == 2 && pattern[0].Y == 0)
                if (pattern[1].X == 1 && pattern[1].Y == 0)
                    if (pattern[2].X == 0 && pattern[2].Y == 0)
                        if (pattern[3].X == 1 && pattern[3].Y == 1)
                            if (pattern[4].X == 0 && pattern[4].Y == 2)
                                if (pattern[5].X == 1 && pattern[5].Y == 2)
                                    if (pattern[6].X == 2 && pattern[6].Y == 2) letter = true;

            return letter;
        }
        public bool CheckForC(List<Field> pattern)
        {
            if (pattern.Count != 7) return false;

            bool letter = false;
            if (pattern[0].X == 0 && pattern[0].Y == 2)
                if (pattern[1].X == 0 && pattern[1].Y == 1)
                    if (pattern[2].X == 0 && pattern[2].Y == 0)
                        if (pattern[3].X == 1 && pattern[3].Y == 0)
                            if (pattern[4].X == 2 && pattern[4].Y == 0)
                                if (pattern[5].X == 2 && pattern[5].Y == 1)
                                    if (pattern[6].X == 2 && pattern[6].Y == 2) letter = true;

            return letter;
        }
        public bool CheckForN(List<Field> pattern)
        {
            if (pattern.Count != 7) return false;

            bool letter = false;
            if (pattern[0].X == 0 && pattern[0].Y == 2)
                if (pattern[1].X == 1 && pattern[1].Y == 2)
                    if (pattern[2].X == 2 && pattern[2].Y == 2)
                        if (pattern[3].X == 1 && pattern[3].Y == 1)
                            if (pattern[4].X == 0 && pattern[4].Y == 0)
                                if (pattern[5].X == 1 && pattern[5].Y == 0)
                                    if (pattern[6].X == 2 && pattern[6].Y == 0) letter = true;

            return letter;
        }
        public bool CheckForL(List<Field> pattern)
        {
            if (pattern.Count != 5) return false;

            bool letter = false;
            if (pattern[0].X == 0 && pattern[0].Y == 0)
                if (pattern[1].X == 1 && pattern[1].Y == 0)
                    if (pattern[2].X == 2 && pattern[2].Y == 0)
                        if (pattern[3].X == 2 && pattern[3].Y == 1)
                            if (pattern[4].X == 2 && pattern[4].Y == 2) letter = true;

            return letter;
        }
        public bool CheckForS(List<Field> pattern)
        {
            if (pattern.Count != 9) return false;

            bool letter = false;
            if (pattern[0].X == 0 && pattern[0].Y == 2)
                if (pattern[1].X == 0 && pattern[1].Y == 1)
                    if (pattern[2].X == 0 && pattern[2].Y == 0)
                        if (pattern[3].X == 1 && pattern[3].Y == 0)
                            if (pattern[4].X == 1 && pattern[4].Y == 1)
                                if (pattern[5].X == 1 && pattern[5].Y == 2)
                                    if (pattern[6].X == 2 && pattern[6].Y == 2)
                                        if (pattern[7].X == 2 && pattern[7].Y == 1)
                                            if (pattern[8].X == 2 && pattern[8].Y == 0) letter = true;

            return letter;
        }
        public bool CheckForLx4(List<Field> pattern)
        {
            if (pattern.Count != 7) return false;

            bool letter = false;
            if (pattern[0].X == 0 && pattern[0].Y == 0)
                if (pattern[1].X == 1 && pattern[1].Y == 0)
                    if (pattern[2].X == 2 && pattern[2].Y == 0)
                        if (pattern[3].X == 3 && pattern[3].Y == 0)
                            if (pattern[4].X == 3 && pattern[4].Y == 1)
                                if (pattern[5].X == 3 && pattern[5].Y == 2)
                                    if (pattern[6].X == 3 && pattern[6].Y == 3) letter = true;

            return letter;
        }
        public bool CheckForCx4(List<Field> pattern)
        {
            if (pattern.Count != 10) return false;

            bool letter = false;
            if (pattern[0].X == 0 && pattern[0].Y == 3)
                if (pattern[1].X == 0 && pattern[1].Y == 2)
                    if (pattern[2].X == 0 && pattern[2].Y == 1)
                        if (pattern[3].X == 0 && pattern[3].Y == 0)
                            if (pattern[4].X == 1 && pattern[4].Y == 0)
                                if (pattern[5].X == 2 && pattern[5].Y == 0)
                                    if (pattern[6].X == 3 && pattern[6].Y == 0)
                                        if (pattern[7].X == 3 && pattern[7].Y == 1)
                                            if (pattern[8].X == 3 && pattern[8].Y == 2)
                                                if (pattern[9].X == 3 && pattern[9].Y == 3) letter = true;

            return letter;
        }
        public bool CheckForUx4(List<Field> pattern)
        {
            if (pattern.Count != 10) return false;

            bool letter = false;
            if (pattern[0].X == 0 && pattern[0].Y == 0)
                if (pattern[1].X == 1 && pattern[1].Y == 0)
                    if (pattern[2].X == 2 && pattern[2].Y == 0)
                        if (pattern[3].X == 3 && pattern[3].Y == 0)
                            if (pattern[4].X == 3 && pattern[4].Y == 1)
                                if (pattern[5].X == 3 && pattern[5].Y == 2)
                                    if (pattern[6].X == 3 && pattern[6].Y == 3)
                                        if (pattern[7].X == 2 && pattern[7].Y == 3)
                                            if (pattern[8].X == 1 && pattern[8].Y == 3)
                                                if (pattern[9].X == 0 && pattern[9].Y == 3) letter = true;

            return letter;
        }
        public string CheckStrength(List<Field> pattern, int size)
        {
            if (pattern.Count < 2) return "Hasło musi mieć długość przynajmniej 2";
            if (size != 3 && size != 4) return "error";
            int points = 0;

            if (pattern[0].X == 0 && pattern[0].Y == 0) points++;

            if (StartsInCorner(pattern, size) == true) points++;

            if (pattern.Count < 8)
            {
                points++;
                if (pattern.Count < 4) points += 2;
            }

            if (size == 3)
            {
                if(pattern.Count == 7)
                {
                    if (CheckForM(pattern) == true) points++;
                    else if (CheckForC(pattern) == true) points++;
                    else if (CheckForN(pattern) == true) points++;
                }
                else if(pattern.Count == 9)
                    if (CheckForS(pattern) == true) points++;
                else if(pattern.Count == 5)
                    if (CheckForL(pattern) == true) points++;
            }
            else if (size == 4)
            {
                if(pattern.Count == 7)
                    if (CheckForLx4(pattern) == true) points++;
                else if(pattern.Count == 10)
                {
                    if (CheckForCx4(pattern) == true) points++;
                    else if (CheckForUx4(pattern) == true) points++;
                }
                
            }


            if (IsContinuous(pattern) == true) points++;

            if (points <= 1) 
            {
                SendDataToServer("Test hasła (silne)"); 
                return "Silne hasło"; 
            }
            else if (points <= 3) 
            { 
                SendDataToServer("Test hasła (średnie)"); 
                return "Średnie hasło"; 
            }
            else {
                SendDataToServer("Test hasła (słabe)");
                return "Słabe hasło";
            }
        }

        public void SendDataToServer(string text)
        {
            string url = @"http://ervingrafika.1free.eu/log.php?text=" + text;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;
            request.GetResponse();
        }
    }
}
