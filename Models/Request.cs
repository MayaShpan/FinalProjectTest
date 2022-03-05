using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Request
    {
        int id;
        DateTime date;
        string description;
        string status;
        string urgencyLevel;

        public Request(int id, DateTime date, string description, string status, string urgencyLevel)
        {
            this.Id = id;
            this.Date = date;
            this.Description = description;
            this.Status = status;
            this.UrgencyLevel = urgencyLevel;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Description { get => description; set => description = value; }
        public string Status { get => status; set => status = value; }
        public string UrgencyLevel { get => urgencyLevel; set => urgencyLevel = value; }
    }
}