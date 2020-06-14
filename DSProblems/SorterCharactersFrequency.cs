using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSProblems
{
    public class SorterCharactersFrequency
    {
        Dictionary<char, int> map = new Dictionary<char, int>();

        public SorterCharactersFrequency()
        {
        }

        public string FrequencySort(string s)
        {
            char[] chararray = s.ToCharArray();
            StringBuilder sb = new StringBuilder();


            foreach (var character in chararray)
            {
                if (map.ContainsKey(character))
                {
                    int value = map[character];
                    map[character] = ++value;
                }
                else
                    map[character] = 1;
            }

            var sortedMap = map.OrderByDescending(c => c.Value);

            foreach (var item in sortedMap)
            {
                var count = item.Value;
                do
                {
                    sb.Append(item.Key);
                    count--;
                } while (count > 0);
            }

            return sb.ToString();
        }
    }
}
