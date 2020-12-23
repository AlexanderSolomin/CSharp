using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LearningCenter
{
    class Laborer : Person, ISal
    {
        private string submission;
        private string lab;
        private int SalBase = 10;
        public double Bonus { get; set; }
        public void Salary()
        {
            double salary = SalBase;
            if (Bonus > 0)
            {
                salary = SalBase * Bonus;
            }

            Console.WriteLine("Зарплата {0}а составила {1}\n", surname, salary);
        }
        public Laborer(string submission, string lab)
        {
            this.submission = submission;
            this.lab = lab;
        }
        public Laborer(string surname, string submission, string lab, DateTime dateOfBirth,
            DateTime dateOfRecruit) : base(surname, dateOfBirth, dateOfRecruit)
        {
            this.submission = submission;
            this.lab = lab;
        }
        public Laborer() { }
        public override string ToString()
        {
            return $"{base.ToString()}\nПозиция: {submission}\nЛаборатория: {lab}\n";
        }
    }
}
