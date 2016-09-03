using System;
using System.Collections;
using System.Linq;

namespace My_Personal_Projects
{
    public class DesignerPDFViewer
    {
        public void Start()
        {
            var str = Console.ReadLine();
            var heights = str.Split(' ').Select(a => Convert.ToInt32(a)).ToArray();

            var word = Console.ReadLine();
            if (string.IsNullOrEmpty(word) || word.Length > 10)
            {
                Environment.Exit(-1);
            }

            word = word.ToLower();

            var hashTable = new Hashtable();
            char c = 'a';
            for (int i = 0; i < heights.Count(); i++)
            {
                int h = 1;
                if (heights[i] >= 1 && heights[i] <= 7)
                {
                    h = heights[i];
                }
                hashTable.Add(c+i, h);
            }

            int max = 0;

            
            foreach (char letter in word)
            {
                if (letter < 97 || letter > 122)
                {
                    continue;
                }
                if (max < (int) hashTable[(int)letter])
                {
                    max = (int) hashTable[(int)letter];
                }
            }

            int count = word.Length*1*max;
            Console.WriteLine(count);

        }
    
    }
}
