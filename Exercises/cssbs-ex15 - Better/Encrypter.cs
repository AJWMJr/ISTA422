using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace cssbs_ex15
{
    class Encrypter
    {
        public List<int> result { get; }
        public Encrypter(string input)
        {
            Console.Write("Please Enter a key word: ");
            var key = Console.ReadLine();
            string trimmed = Trim(input);
        l1:
            if (Regex.IsMatch(key, @"^[a-zA-Z]+$"))
                key = Trim(key);
            else
            {
                Console.WriteLine("Please enter a valid key");
                goto l1;
            }
            result = Encrypt(trimmed, key);
        }
        public string Trim(string input)
        {
            var builder = new StringBuilder();
            foreach (var ch in input)
            {
                if (ch >= 32)
                    builder.Append(ch);
            }
            return builder.ToString();
        }
        private List<int> Encrypt(string trimmed, string key)
        {
            int a = 0;
            var keyL = new List<int>();
            var encoded = new List<int>();
            var keyArr = key.ToCharArray();
            for (int i = 0; i < trimmed.Length; i++)
            {
                if (a >= keyArr.Length) a = 0;
                int ch = keyArr[a];
                if (ch < 97)
                    keyL.Add(ch - 64);
                else
                    keyL.Add(ch - 96);
                a++;
            }
            a = 0;
            foreach (var ch in trimmed)
            {
                if (a >= keyL.Count) a = 0;
                int num = ch + keyL[a];
                encoded.Add(num);
                a++;
            }
            return encoded;
        }
        public override string ToString()
        {
            var builder = new StringBuilder();
            foreach (int n in result)
            {
                if (n >= 32 && n <= 127)
                    builder.Append((char)n);
                else if (n >= 32 && n > 127)
                    builder.Append((char)(n - 26));
                else throw new Exception("check ToString in Encrypter");
            }
            return builder.ToString();
        }
    }
}
