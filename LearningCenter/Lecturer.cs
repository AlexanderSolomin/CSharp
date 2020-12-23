using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCenter
{
    class Lecturer : Person, ISal
    {
        private string submission;
        private string faculty;
        private string position;
        private int SalBase = 10;
        public double Bonus { get; set; }
        public void Salary()
        {
            double salary = SalBase + SalBase * (Expirience() / 10);
            if (Bonus > 0)
            {
                salary = salary * Bonus;
            }
            Console.WriteLine("Зарплата {0}а составила {1}\n", surname, salary);
        }

        public Lecturer(string submission, string faculty, string position)
        {
            this.submission = submission;
            this.faculty = faculty;
            this.position = position;
        }
        public Lecturer(string surname, string submission, string faculty, string position, DateTime dateOfBirth,
            DateTime dateOfRecruit) : base(surname, dateOfBirth, dateOfRecruit)
        {
            this.submission = submission;
            this.faculty = faculty;
            this.position = position;
        }
        public Lecturer() { }
        public override string ToString()
        {
            return $"{base.ToString()}\nПозиция: {submission}\nФакультет: {faculty}\nДолжность: {position}\n";
        }
    }
}
