using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Schedule
    {
        int id;
        DateTime startTime;
        DateTime endTime;
        string description;
        string remarks;

        public Schedule(int id, DateTime startTime, DateTime endTime, string description, string remarks)
        {
            this.Id = id;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Description = description;
            this.Remarks = remarks;
        }

        public int Id { get => id; set => id = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        public string Description { get => description; set => description = value; }
        public string Remarks { get => remarks; set => remarks = value; }
    }