using System;
using System.Collections;
using System.Collections.Generic;
using Extension;

namespace payal_csharp_quiz1
{
    class Program
    {
        public delegate void Highest(List<Employee> listEmployees);
        public delegate void Lowest(List<Employee> listEmployees);
        static void Main(string[] args)
        {
            Console.WriteLine("Payal Patel\n");
            //Task 1
            Console.WriteLine("Answer 1) Properties of anonymous types will be read-only properties so you cannot change their values.\n");

            //Task 2
            List<Employee> listEmployees = new List<Employee>();
            listEmployees.Add(new Employee(1, "John", 100000));
            listEmployees.Add(new Employee(2, "Rahul", 300000));
            listEmployees.Add(new Employee(3, "Paul", 200000));

            listEmployees.ForEach(emp => emp.ToString());

            Employee e = new Employee();
            Highest highSalary = e.getHighest;
            highSalary(listEmployees);

            Lowest lowSalary = e.getLowest;
            lowSalary(listEmployees);

            //Task 3
            var info = Tuple.Create<string, int, string>("payal", 23, "21 rue de blue heaven");
            //Interpolation
            Console.WriteLine($"Name: {info.Item1}, age: {info.Item2} and address: {info.Item3}");
            //Format ({0})
            Console.WriteLine("Name: {0}, age: {1} and address: {2}", info.Item1, info.Item2, info.Item3);

            //Task 4
            Hashtable myHashtable = new Hashtable();
            listEmployees.ForEach(emp => myHashtable.Add(emp.id,emp.name));

            foreach (DictionaryEntry item in myHashtable)
            {
                Console.WriteLine("key:{0} , value:{1}", item.Key, item.Value);
            }

            //Task 5
            MyGenericClass<Employee>.PrintValue(new Employee(4, "Meera",400000));

            //Task 6
            int i = 12;

            bool result = i.IsDivisibleBy3();

            if (result==true)
            {
                Console.WriteLine($"{i} is divisible by 3");
            }
            else
            {
                Console.WriteLine($"{i} is not divisible by 3");
            }

            //Task 7
            String s = "hello";
            bool vowel = isContainVowel(s);
            if (vowel)
            {
                Console.WriteLine(s+" contains vowel");
            }
            else
            {
                Console.WriteLine(s + "does not contain vowel");
            }

            //Task 8
            Student std = new Student();
            std.PrintMessage(80);
        }

        private static bool isContainVowel(string str)
        {
            str = str.ToLower();
            char[] Letters = str.ToCharArray();
            bool found = false;

            for (int i = 0; i < Letters.Length; i++)
            {
                if (Letters[i] == 'a' || Letters[i] == 'e' || Letters[i] == 'o' || Letters[i] == 'o' || Letters[i] == 'u')
                {
                    found = true;
                    Console.WriteLine(Letters[i]);
                }
            }

            return found;
        }
    }
}
