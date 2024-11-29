using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._11._19.Ugyfel
{
    internal class Customer
    {
        public string FirstName, LastName, Email, Address;
        public DateTime BirthDate;


        public Customer(string firstname, string lastname, DateTime birthdate, string email, string address) 
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.BirthDate = birthdate;
            this.Email = email;
            this.Address = address;
        }
        public int GetAge() 
        {
            int age = 0;
            string[] st = BirthDate.Split('.');
            int[] BirthdateInt = new int[]
            { Convert.ToInt32(st[0]), Convert.ToInt32(st[1]), Convert.ToInt32(st[2]) };
            int[] today = new int[] { 2024, 11, 19 };
            age = today[0] - BirthdateInt[0];
            if (today[1] <= BirthdateInt[1]) 
            {
                if (today[2] <= today[2])
                {
                    age++;
                }
            }
            
            return age;
        }
        public bool IsEmailValid()
        {
            bool Allvalid = false;
            bool Secondvalid = false;

            for (int i = 0; i < Email.Length; i++)
            {
                if (((int)Email[i] < 123 && 47 < (int)Email[i]) && i < Email.Length && i > 0 )
                {
                    if (Email[i] == '@')
                    {
                        for (int j = i+1; j < Email.Length; j++)
                        {
                            if (Email[j] == '.' || ((int)Email[j] < 123) && (int)Email[j] > 64)
                            {
                                Secondvalid = true;
                            }
                        }
                    }
                    if (Secondvalid)
                    {
                        Allvalid = true;
                    }
                }
            }
            

            return Allvalid;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
