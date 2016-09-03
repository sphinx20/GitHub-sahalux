using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Personal_Projects
{
    public class StringTrucate
    {
        public string[] Start(string message, int maxCharLength)
        {
            int counter = 0;
            var stringList = new ArrayList();
            int sp = 0;
            string tempString = string.Empty;
            //int i = 0;

            for (int i = 0; i < message.Length; i++)
                //while (true)
                //{
                    
                //}
            {

                if (message[i] == ' ')
                {
                    sp = i;
                }
                if (counter == maxCharLength)
                {
                    Console.WriteLine(sp);
                    
                   stringList.Add(tempString);
                   tempString = String.Empty;
                    counter = 0;

                }
                else
                {
                    tempString = tempString + message[i];
                    counter++;
                }
                //Console.WriteLine(tempString);
                
            }
            foreach (var str in stringList)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Press any key.");
            Console.ReadLine();
            return new string[]{"",""};
        }

        //public string Retract()
        //{
            
        //}
      
    }
}
