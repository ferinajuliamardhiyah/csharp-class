using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace csharp_class {
    class Str {
        public static void lower (string text) {
            string hasil = text.ToLower ();
            Console.WriteLine (hasil);
        }

        public static void upper (string text) {
            string hasil = text.ToUpper ();
            Console.WriteLine (hasil);
        }

        public static void capitalize (string text) {
            string hasil = Regex.Replace (text.ToLower (), @"(^\w)|(\s\w)", m => m.Value.ToUpper ());
            Console.WriteLine (hasil);
        }

        public static void reverse (string text) {
            Array.Reverse (text.Split ());
            string hasil = String.Join ("", text);
            Console.WriteLine (hasil);
        }

        public static void contains (string text, string word) {
            string[] textSplit = text.Split (" ");

            if (textSplit.Contains (word)) {
                Console.WriteLine ("true");
            } else {
                Console.WriteLine ("false");
            }
        }

        public static void random (int num = 16) {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[num];
            var random = new Random ();

            for (int i = 0; i < stringChars.Length; i++) {
                stringChars[i] = chars[random.Next (chars.Length)];
            }

            var finalString = new String (stringChars);
            Console.WriteLine (finalString);
        }

        public static void slug (string text, string op = "-") {
            string[] textUbah = Regex.Replace (text.ToLower (), @"[^\w\s]", "").Split (" ");
            string hasil = String.Join (op, textUbah);
            Console.WriteLine (hasil);
        }

        public static void count (string text) {
            int hasil = text.Length;
            Console.WriteLine (hasil);
        }

        public static void countWords (string text) {
            string[] hasil = text.Split (" ");
            Console.WriteLine ($"{hasil.Length}");
        }

        public static void trim (string text, int num = 100, string op = "...") {
            string textUbah = text.Substring (0, num);
            Console.WriteLine (textUbah.Insert (textUbah.Length, op));
        }

        public static void trimWords (string text, int num = 30, string op = "...") {
            string[] textSplit = text.Split (" ");
            string hasil = String.Join (" ", textSplit.Take (num));
            Console.WriteLine (hasil.Insert (hasil.Length, op));
        }
    }
}