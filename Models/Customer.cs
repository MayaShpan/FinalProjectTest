using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Customer
    {
        int id;
        string name;
        string type;
        string company;
        string contactPersonName;
        string contactPersonPhone;
        string anotherContactPersonPhone;
        string address;
        string email;
        string test;

        public Customer(int id, string name, string type, string company, string contactPersonName, string contactPersonPhone, string anotherContactPersonPhone, string address, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Company = company;
            this.ContactPersonName = contactPersonName;
            this.ContactPersonPhone = contactPersonPhone;
            this.AnotherContactPersonPhone = anotherContactPersonPhone;
            this.Address = address;
            this.Email = email;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Company { get => company; set => company = value; }
        public string ContactPersonName { get => contactPersonName; set => contactPersonName = value; }
        public string ContactPersonPhone { get => contactPersonPhone; set => contactPersonPhone = value; }
        public string AnotherContactPersonPhone { get => anotherContactPersonPhone; set => anotherContactPersonPhone = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
    }
}