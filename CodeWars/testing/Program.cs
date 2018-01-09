using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] peopleInLine = new int[100];
            List<int> Vasya = new List<int>();
            foreach (int money in peopleInLine)
            {
                if (money == 25)
                    Vasya.Add(money);
                else if (money == 50)
                {
                    if (Vasya.Contains(25))
                    {
                        Vasya.Remove(25);
                        Vasya.Add(50);
                    }
                    else
                    {
                       
                    }
                }
                else if (money == 100)
                {
                    if (Vasya.Contains(50) && Vasya.Where(x => x == 25).Count() >= 1)
                    {
                        Vasya.Remove(25);
                        Vasya.Remove(50);
                        Vasya.Add(100);
                    }
                    else if (Vasya.Where(x => x == 25).Count() >= 3)
                    {
                        Vasya.Remove(25);
                        Vasya.Remove(25);
                        Vasya.Remove(25);
                        Vasya.Add(100);
                    }
                                    
                }
            }
            
        }
    }
}
