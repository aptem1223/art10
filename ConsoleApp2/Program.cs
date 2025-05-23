using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    using System;
    struct Student
    {
        public string FullName;
        public string Group;
        public double[] Informatics; 
        public double[] Physics;     
        public double[] History;     

        public double AverageScoreInformatics()
        {
            return AverageArray(Informatics);
        }
        public double AverageScorePhysics()
        {
            return AverageArray(Physics);
        }
        public double AverageScoreHistory()
        {
            return AverageArray(History);
        }

        public double AverageScoreOverall()
        {
            double sum = 0;
            foreach (var val in Informatics) sum += val;
            foreach (var val in Physics) sum += val;
            foreach (var val in History) sum += val;
            return sum / (Informatics.Length + Physics.Length + History.Length);
        }

        private double AverageArray(double[] arr)
        {
            double sum = 0;
            foreach (var val in arr) sum += val;
            return sum / arr.Length;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Введите количество студентов: ");
            int n = int.Parse(Console.ReadLine());

            Student[] students = new Student[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Студент #{i + 1}:");

                Console.Write("ФИО: ");
                students[i].FullName = Console.ReadLine();

                Console.Write("Группа: ");
                students[i].Group = Console.ReadLine();

                students[i].Informatics = ReadScores("Информатика", 5);
                students[i].Physics = ReadScores("Физика", 5);
                students[i].History = ReadScores("История", 5);

                Console.WriteLine();
            }

            PrintStudents(students);

            double avgInf = 0, avgPhys = 0, avgHist = 0;
            foreach (var st in students)
            {
                avgInf += st.AverageScoreInformatics();
                avgPhys += st.AverageScorePhysics();
                avgHist += st.AverageScoreHistory();
            }
            avgInf /= n;
            avgPhys /= n;
            avgHist /= n;

            Console.WriteLine($"Средний балл по Информатике: {avgInf:F2}");
            Console.WriteLine($"Средний балл по Физике: {avgPhys:F2}");
            Console.WriteLine($"Средний балл по Истории: {avgHist:F2}");

            double A = 4.5; 

            var filteredStudents = Array.FindAll(students, s => s.AverageScoreOverall() > A);

            Console.WriteLine($"\nСтуденты с общим средним баллом выше {A}: {filteredStudents.Length}");
            if (filteredStudents.Length > 0)
                PrintStudents(filteredStudents);

            Console.Write("\nВведите ФИО для поиска студента: ");
            string searchName = Console.ReadLine();

            var found = Array.Find(students, s => s.FullName.Equals(searchName, StringComparison.OrdinalIgnoreCase));
            if (found.FullName == null)
                Console.WriteLine("Студент с таким ФИО не найден.");
            else
                PrintStudents(new Student[] { found });
        }

        static double[] ReadScores(string subject, int count)
        {
            double[] scores = new double[count];
            Console.WriteLine($"Введите {count} оценок по предмету {subject}:");
            for (int i = 0; i < count; i++)
            {
                scores[i] = ReadScore($"{subject} оценка #{i + 1}");
            }
            return scores;
        }

        static double ReadScore(string prompt)
        {
            double score;
            while (true)
            {
                Console.Write($"{prompt} (0-5): ");
                if (double.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= 5)
                    return score;
                Console.WriteLine("Ошибка ввода! Введите число от 0 до 5.");
            }
        }

        static void PrintStudents(Student[] students)
        {
            Console.WriteLine("\n{0,-25} {1,-10} {2,10} {3,10} {4,10} {5,15}",
                "ФИО", "Группа", "Информ.", "Физика", "История", "Средний балл");
            Console.WriteLine(new string('-', 85));

            foreach (var st in students)
            {
                Console.WriteLine("{0,-25} {1,-10} {2,10:F2} {3,10:F2} {4,10:F2} {5,15:F2}",
                    st.FullName, st.Group,
                    st.AverageScoreInformatics(),
                    st.AverageScorePhysics(),
                    st.AverageScoreHistory(),
                    st.AverageScoreOverall());
            }
            Console.Read();
        }
    }

}

