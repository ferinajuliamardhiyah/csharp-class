using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace csharp_class {
    class Program {
        static void Main (string[] args) {
            Csv.CSVObject();
        }

        static void Palindrome (string kalimat) {
            string kalimatUbah = Regex.Replace (kalimat.ToLower (), @"[^\w\""\-]*", "");
            string[] kalimatBalik = kalimatUbah.Split ();
            Array.Reverse (kalimatBalik);
            string hasil = String.Join ("", kalimatBalik);
            if (kalimatUbah == hasil) {
                Console.WriteLine ("It is palindrome");
            } else {
                Console.WriteLine ("It is not palindrome");
            }
        }

        static void CombineList () {
            List<string> first = new List<string> { "Behind", "every", "great", "man" };
            List<string> second = new List<string> { "is", "a", "woman" };
            List<string> third = new List<string> { "rolling", "her", "eyes" };

            List<string> listBaru = first.Concat (second).Concat (third).ToList ();
            string hasil = String.Join (" ", listBaru);
            Console.WriteLine (hasil);
        }

        static void CensoringWords () {
            string[] word = { "dolor", "elit", "quis", "nisi", "fugiat", "proident", "laborum" };
            string paragraph = @"Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.
Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            string[] paragraphUbah = Regex.Replace (paragraph, "\n", " ").Split (" ");
            for (int i = 0; i < paragraphUbah.Length; i++) {
                for (int j = 0; j < word.Length; j++) {
                    if (paragraphUbah[i] == word[j]) {
                        List<char> Temp = new List<char> ();
                        for (int k = 0; k < word[j].Length; k++) {
                            Temp.Add ('*');
                        }

                        paragraphUbah[i] = String.Join ("", Temp);
                    }
                }
            }

            string hasil = String.Join (" ", paragraphUbah);
            Console.WriteLine (hasil);
        }

        static void CountWords () {
            string paragraph = @"Aku ingin begini
Aku ingin begitu
Ingin ini itu banyak sekali

Semua semua semua
Dapat dikabulkan
Dapat dikabulkan
Dengan kantong ajaib

Aku ingin terbang bebas
Di angkasa
Hei... baling baling bambu

La... la... la...
Aku sayang sekali
Doraemon

La... la... la...
Aku sayang sekali";

            string[] paragraphSplit = Regex.Replace (paragraph.ToLower (), @"[\n\.]", " ").Split (" ");
            string[] word = { "aku", "ingin", "dapat", "hei" };

            for (int i = 0; i < word.Length; i++) {
                int count = 0;
                for (int j = 0; j < paragraphSplit.Length; j++) {
                    if (paragraphSplit[j] == word[i]) {
                        count++;
                    }
                }
                Console.WriteLine ($"{word[i]}: {count}");
            }
        }

}

}