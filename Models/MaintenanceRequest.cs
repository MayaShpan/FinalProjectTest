using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class MaintenanceRequest
    {
        int id;
        DateTime dateOfTreatment;

        public MaintenanceRequest(int id, DateTime dateOfTreatment)
        {
            this.Id = id;
            this.DateOfTreatment = dateOfTreatment;
        }

        public int Id { get => id; set => id = value; }
        public DateTime DateOfTreatment { get => dateOfTreatment; set => dateOfTreatment = value; }
    }
}