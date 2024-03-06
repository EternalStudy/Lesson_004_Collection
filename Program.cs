using System.Linq;
using System.Net.NetworkInformation;

namespace Lesson_004_Colltction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1 Исключить повторы массива List<int> ints = new List<int> { 0, 1, 1, -1, 101, 102, 101, 11, 1111, 11 };
            /*Дан список целых чисел (числа не последовательны), в котором некоторые числа повторяются. 
             * Выведите список чисел на экран, исключив из него повторы.
            List<int> ints = new List<int> { 0, 1, 1, -1, -101, 102, 101, 11, 1111, 11 };
            Task1(ints);*/
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            int[] arrey = { 1, 2, 5, 7, 9, 11, 12, 14, 15, 16, 18, 19, 20, 22, 25 };
            int tarjet = 32;
            FindSumOfThreeNums(arrey, tarjet);
        }
        public static void FindSumOfThreeNums(int[] arrey, int tarjet)
        {
            for (int i = 0; i < arrey.Length - 1; i++)
            {
                for (int j = i + 1; j < arrey.Length - 1; j++)
                {
                    for (int k = j + 1; k < arrey.Length - 1; k++)
                    {
                        if (arrey[i] + arrey[j] + arrey[k] == tarjet)
                        {
                            Console.WriteLine($"{arrey[i]} + {arrey[j]} + {arrey[k]}= {tarjet}");
                        }
                    }
                }
            }
        }
        static void Task1(List<int> ints)
        {
            List<int> list = new List<int>();
            foreach (int i in ints)
            {
                //if(!list.Contains(i)) list.Add(i);
                if (!list.Any(x => x == i || x == -i)) list.Add(i);
            }
            foreach (var x in list)
            {
                Console.WriteLine(x);
            }

            /*HashSet<int> set = new HashSet<int>(ints);
            foreach (var x in set)
            {
                //Console.WriteLine(x);
            }*/
        }
        static void Task2()
        {
            /*Дан список целых чисел (числа не последовательны), в котором некоторые числа повторяются.
             Выведите список чисел на экран, расположив их в порядке возрастания частоты повторения*/
            List<int> ints = new List<int> { 1, 2, 2, 2, 3, 4, 4, 5, 5, 5, 5, 6, 7, 0 };
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var x in ints)
            {
                if (dict.ContainsKey(x)) { dict[x]++; }
                else { dict.Add(x, 1); }
            }
            PriorityQueue<int, int> priority = new PriorityQueue<int, int>();
            foreach (var el in dict)
            {
                priority.Enqueue(el.Key, el.Value);
            }
            while (priority.Count > 0)
            {
                Console.WriteLine(priority.Dequeue());
            }
        }
        static void Task3()
        {
            /*Задача: У вас есть список студентов. Необходимо отфильтровать студентов старше 20 лет и отсортировать их по алфавиту.*/
            List<Student> list = new List<Student>();
            Student student = new Student();
            student.FullName = "Etturnal Study";
            student.Age = 27;
            list.Add(student);
            student = new Student();
            student.FullName = "Vlagibator GTA";
            student.Age = 20;
            list.Add(student);
            student = new Student();
            student.FullName = "Veter Sever";
            student.Age = 35;
            list.Add(student);

            list = list.Where(x => x.Age >= 25).OrderBy(x=>x.FullName).ToList();
            foreach(var item in list)
            {
                Console.WriteLine("Name: " + item.FullName + "Age= " + item.Age);
            }
        }
        static void Task4()
        {
            List<int> ints = new List<int> { 1, 2, 2, 2, 3, 4, 4, 5, 5, 5, 5, 6, 7, 0 };
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var x in ints)
            {
                if (dict.ContainsKey(x)) { dict[x]++; }
                else { dict.Add(x, 1); }
            }
            PriorityQueue<int, int> priority = new PriorityQueue<int, int>();
            foreach (var el in dict)
            {
                priority.Enqueue(el.Key, el.Value);
            }
            while (priority.Count > 0)
            {
                Console.WriteLine(priority.Dequeue());
            }
        }
        static void Task5()
        {
            List<Student> list = new List<Student>();
            Student student = new Student();
            student.FullName = "Eturnal Study";
            student.Age = 27;
            list.Add(student);
            student = new Student();
            student.FullName = "Vlagibator GTA";
            student.Age = 20;
            list.Add(student);
            student = new Student();
            student.FullName = "Veter Sever";
            student.Age = 35;
            list.Add(student);
            student.FullName = "Mother";
            student.Age = 48;
            list.Add(student);
            student = new Student();
            student.FullName = "Brother";
            student.Age = 16;
            list.Add(student);
            student = new Student();
            student.FullName = "Father";
            student.Age = 49;
            list.Add(student);
            student = new Student();
            student.FullName = "Besit";
            student.Age = 10;
            list.Add(student);
            student = new Student();
            student.FullName = "Child";
            student.Age = 5;
            list.Add(student);
            student = new Student();
            student.FullName = "Grand";
            student.Age = 65;
            list.Add(student);

            list = list.Skip(3).Take(6).Where(x => x.Age >= 10).OrderBy(x => x.FullName).ToList();
            //list = list.Where(x => x.Age >= 25).OrderBy(x => x.FullName).ToList();
            foreach (var item in list)
            {
                Console.WriteLine("Name: " + item.FullName + "Age= " + item.Age);
            }
        }

    }
    class Student
    {
        public string FullName { get; set; }
        public int Age { get; set; }
    }
}
