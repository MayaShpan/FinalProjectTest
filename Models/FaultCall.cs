using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class FaultCall
    {
        int id;
        string type;
        bool disablesActivity;
        DateTime dateOfTreatment;

        public FaultCall(int id, string type, bool disablesActivity, DateTime dateOfTreatment)
        {
            this.Id = id;
            this.Type = type;
            this.DisablesActivity = disablesActivity;
            this.DateOfTreatment = dateOfTreatment;
        }

        public int Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public bool DisablesActivity { get => disablesActivity; set => disablesActivity = value; }
        public DateTime DateOfTreatment { get => dateOfTreatment; set => dateOfTreatment = value; }
    }
}