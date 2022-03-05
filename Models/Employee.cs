using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Employee
    {
        int id;
        string name;
        string phoneNumber;
        string email;
        int jobPrecentage;
        int seniority;

        public Employee(int id, string name, string phoneNumber, string email, int jobPrecentage, int seniority)
        {
            this.Id = id;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.JobPrecentage = jobPrecentage;
            this.Seniority = seniority;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public int JobPrecentage { get => jobPrecentage; set => jobPrecentage = value; }
        public int Seniority { get => seniority; set => seniority = value; }
    }
}