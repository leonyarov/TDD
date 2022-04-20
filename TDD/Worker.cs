using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace TDD
{
    public class Worker : IComparable<Worker>
    {
        public string id, name, family, email, phone, address;
        public int salary;
        public static int count = 0;
        static Random random = new Random();


        public Worker(string  id, string name, string family, string email,string phone,string address, int salary)
        {
            this.id = id;
            this.name = name;
            this.family = family;
            this.email = email;
            this.phone = phone;
            this.address = address;
            SetSalary(salary);
        }

        public Worker()
        {
            id = random.Next(10, 10000).ToString();
            name = "John";
            family = "Doe" + count++;
            email = name + family + "@gmail.com";
            phone = random.Next(10, 1000000).ToString();
            address = randomStreet();
            salary = random.Next(3_000, 50_000);
        }

        public void SetSalary(int money)
        {
            money = money < 0 ? 0 : money;
            salary = money;
        }

        public int CompareTo(Worker other)
        {
            return salary.CompareTo(other.salary);
        }

        private string randomStreet()
        {
            var street1 = new string[] {"Zait", "Mezada", "Irus", "Street", "Cardboard"};
            var street2 = new string[] {"Blvd", "Strt", "Box"};
            var s1 = street1[random.Next(street1.Length)];
            var s2 = street2[random.Next(street2.Length)];
            return s1 + " " + s2;
        }

        public static double CountTax(int w)
        {
            var s = w;
            if (s < 6450) return 0.1;
            if (s < 9240) return 0.14;
            if (s < 14840) return 0.20;
            if (s < 20_620) return 0.31;
            if (s < 42_910) return 0.35;
            return 0.47;
        }

        private bool Equals(Worker other)
        {
            if (other == null) return false;
            if (salary != other.salary) return false;
            if (name != other.name) return false;
            if (family != other.family) return false;
            if (id != other.id) return false;
            if (phone != other.phone) return false;
            if (address != other.address) return false;
            return true;
        }
    }
}
