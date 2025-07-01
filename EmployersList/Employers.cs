using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmployersList
{    /*
Задание 3
Создайте приложение для учёта сотрудников. Необходимо
хранить следующую информацию:
 ФИО
 Должность
 Заработная плата
 Рабочий email

     */
    internal struct Employers: IComparable<Employers>, IEquatable<Employers>
    {
        public string FullName{ get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public MailAddress WorkEmail { get; set; }

        public Employers() {
            FullName = "Unknown";
            Position = "Unknown";
            Salary = 0.0;
            WorkEmail = new MailAddress("example@gmail.com");
        }
        public Employers(string fullName, string position = "Unknown", double salary = 0.0, string email = "example@gmail.com")
        {
            FullName = fullName;
            Position = position;
            Salary = salary;
            WorkEmail = new MailAddress(email);
        }
        



    }
}
