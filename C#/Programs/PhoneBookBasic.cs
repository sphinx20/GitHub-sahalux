using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace My_Personal_Projects
{
    class PhoneBookBasic
    {
        static void New(String[] args)
        {

            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            var ns = Console.ReadLine();
            int N = Convert.ToInt32(ns);

            var phoneBook = new PhoneBook();

            for (int i = 0; i < N; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                if (tokens.Length == 2)
                {
                    int num = 0;
                    try
                    {
                        num = Convert.ToInt32(tokens[1]);
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                    var digits = num <= 0 ? 1 : Math.Floor(Math.Log10(Math.Abs(num)) + 1);
                    if (digits == 8)
                        phoneBook.Add(tokens[0], num);
                }
            }
            phoneBook.Records.Sort();

            string inc;
            var inp = new List<string>();
            do
            {
                inc = Console.ReadLine();
                if (!string.IsNullOrEmpty(inc))
                {
                    inp.Add(inc.ToLower().Trim());
                }
            } while (!string.IsNullOrEmpty(inc));

            foreach (string s in inp)
            {
                var r = phoneBook.Find(s);
                if (r == null)
                {
                    Console.WriteLine("Not found");
                }
                else
                {
                    Console.WriteLine(r.Name + "=" + r.Phonenum);
                }
            }
            Console.ReadLine();

        }


        public class Record : IComparable
        {
            public string Name;
            public int Phonenum;

            public Record(string n, int p)
            {
                Name = n;
                Phonenum = p;
            }

            // This function sorts the array list.   
            public int CompareTo(Object obj)
            {
                if (obj is Record)
                    return this.Name.CompareTo((obj as Record).Name);
                return 0;
            }



        }
        public class PhoneBook
        {
            public ArrayList Records = new ArrayList();

            public void Add(string name, int pnum)
            {
                var recordNew = new Record(name, pnum);
                var record = Find(name);

                if (record != null)
                {

                    record.Phonenum = pnum;

                }
                else
                {
                    //Console.WriteLine("Record is null");
                    Records.Add(recordNew);
                    //Sort the array everytime a new record is added.
                    if ((Records.Count % 10000) == 0)
                        Records.Sort();
                }
            }

            public void Remove(string name)
            {

                var record = Find(name);
                if (record != null)
                {
                    Records.Remove(record);

                }
            }

            public Record Find(string name)
            {
                return Search(name, 0, (Records.Count - 1));
            }

            //Binary Search
            public Record Search(string name, int beg, int end)
            {
                if (beg > end)
                    return null;

                int mid = (beg + end) / 2;
                var rec = (Record)Records[mid];
                if (string.Compare(rec.Name, name) == 0)
                {
                    return rec;
                }
                else if (string.Compare(rec.Name, name) < 0)
                {
                    return Search(name, mid + 1, end);
                }
                else
                {
                    return Search(name, beg, mid - 1);
                }
            }
        }
    }
}
