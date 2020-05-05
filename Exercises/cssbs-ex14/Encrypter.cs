using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace cssbs_ex14
{
    class Encrypter
    {
        public List<int> result { get; }
        public Encrypter(string input)
        {
            Console.Write("Please Enter a key word: ");
            var key = Console.ReadLine();
            string trimmed = Trim(input);
            key = Trim(key);
            result = Encrypt(trimmed, key);
        }
        public string Trim(string input)
        {
            var builder = new StringBuilder();
            foreach (var ch in input)
            {
                if (Regex.IsMatch(ch.ToString(), @"^[a-zA-Z]+$"))
                    builder.Append(ch);
            }
            return builder.ToString();
        }
        private List<int> Encrypt(string trimmed, string key)
        {
            int a= 0,i;
            var keyL = new List<int>();
            var encoded = new List<int>();
            key += trimmed;
            var keyArr = key.ToCharArray();
            for (i = 0; i < trimmed.Length; i++)
            {
                int ch = keyArr[i];
                if (ch < 97)
                    keyL.Add(ch - 64);
                else
                    keyL.Add(ch - 96);
            }
            foreach(var ch in trimmed)
            {
                int num = (int)ch + keyL[a];
                encoded.Add(num);
                a++;
            }
            return encoded;
        }
        public override string ToString()
        {
            var builder = new StringBuilder();
            foreach(int n in result)
            {
                if ((n >= 65 && n <= 90) || (n >= 97 && n <= 122))
                    builder.Append((char)n);
                else
                {
                    builder.Append((char)(n - 26));
                }
            }
            return builder.ToString();
        }
    }
}
