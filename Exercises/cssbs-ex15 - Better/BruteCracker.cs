using System.Text;
using System.Collections.Generic;

namespace cssbs_ex15
{
    internal class BruteCracker
    {
        private List<int> pass;
        private string encrypted;

        public BruteCracker(string pass, string encrypted)
        {
            var pTemp = new List<int>();
            foreach (var ch in pass)
                pTemp.Add(ch);
            this.pass = pTemp;
            this.encrypted = encrypted;
        }
        public string Crack()
        {
            var cracker = new List<int>();
            var builder = new StringBuilder();
            for (int i = 1; i <= 26; i++)
            {
                foreach (char ch in encrypted)
                    cracker.Add(ch - i);
                if (pass == cracker)
                    break;
                else cracker.Clear();
            }
            foreach (int n in pass)
                builder.Append((char)n);
            return builder.ToString();
        }
    }
}