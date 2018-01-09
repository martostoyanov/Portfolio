using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Kata7
    {
        public static string[] GetNames(Person[] data)
        {
            string[] imena = new string[data.Length];
            for (int i = 0; i < imena.Length; i++)
            {
                imena[i] = data[i].Name;
            }

            return imena;
        }
        public static double Round(double n)
        {
            return Math.Round(n, 2);
        }
        public static int[] TwoOldestAges(int[] ages)
        {
            int durt = 0;
            int durt2 = 0;
            foreach (int item in ages)
            {
                if (item > durt)
                {
                    durt2 = durt;
                    durt = item;
                }
                else if (item > durt2)
                {
                    durt2 = item;
                }
            }
            return new int[] { durt2, durt };
        }
        public static double Execute(double num1, char op, double num2)
        {
            double suma = 0;
            if (op == '+')
            {
                suma = num1 + num2;
            }
            else if (op == '-')
            {
                suma = num1 - num2;
            }
            else if (op == '*')
            {
                suma = num1 * num2;
            }
            else if (op == '/')
            {
                if (num2 == 0)
                {
                    throw new ArgumentException("Division by zero.", nameof(num2));
                }
                else
                {
                    suma = num1 / num2;
                }
            }
            else { throw new ArgumentException("Invalid operator.", nameof(op)); }
            return suma;
        }
        public static int findSum(int n)
        {
            int suma = 0;
            for (int x = 0; x <= n; x++)
            {
                if (x % 5 == 0 || x % 3 == 0)
                {
                    suma += x;
                }
            }
            return suma;
        }
        public static int[] SortNumbers(int[] nums)
        {
            if (nums == null)
            {
                nums = new int[0];
            }
            else
            {
                Array.Sort(nums);
            }
            return nums;
        }
        public static int[] GetEvenNumbers(int[] numbers)
        {
            return numbers.Where(chislo => chislo % 2 == 0).ToArray();
        }
        public static int[] SumOfN(int n)
        {
            List<int> list = new List<int>();
            int suma = 0;
            if (n > 0)
            {
                for (int i = 0; i <= n; i++)
                {
                    suma += i;
                    list.Add(suma);
                }
            }
            else
            {
                for (int i = 0; i >= n; i--)
                {
                    suma += i;
                    list.Add(suma);
                }
            }
            return list.ToArray();
        }
        public static string OnesComplement(string n)
        {
            var smqna = n.ToCharArray();
            for (int i = 0; i < smqna.Length; i++)
            {
                if (smqna[i] == '1')
                {
                    smqna[i] = '0';
                }
                else
                {
                    smqna[i] = '1';
                }
            }
            return new string(smqna);
        }
        public static int[] ReverseSeq(int n)
        {
            int[] chisla = new int[n];
            for (int i = 0, chislo = n; i < n; i++, chislo--)
            {
                chisla[i] = chislo;
            }
            return chisla;
        }
    }

    //public class NaughtyOrNice
    //{
    //    public static IEnumerable<string> GetNiceNames(IEnumerable<Person> people)
    //    {
    //        return people.Where(proverka => proverka.WasNice == true).Select(proverka => proverka.Name);
    //    }

    //    public static IEnumerable<string> GetNaughtyNames(IEnumerable<Person> people)
    //    {
    //        return people.Where(proverka => proverka.WasNice == false).Select(proverka => proverka.Name);
    //    }
    //}

    public class Warrior
    {
        private string name;

        public Warrior(string name)
        {
            this.name = name;
            Health = 100;
        }

        public int Health { get; set; }

        public void Strike(Warrior enemy, int swings)
        {
            enemy.Health = Math.Max(0, enemy.Health - (swings * 10));
        }
    }










    public class Person
    {
        internal string Name;

    }
}
