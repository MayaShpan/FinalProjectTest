using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class RequestForInformation
    {
        int id;
        string type;
        int desiredQuantity;
        DateTime deliveryByDate;
        int bid;

        public RequestForInformation(int id, string type, int desiredQuantity, DateTime deliveryByDate, int bid)
        {
            this.Id = id;
            this.Type = type;
            this.DesiredQuantity = desiredQuantity;
            this.DeliveryByDate = deliveryByDate;
            this.Bid = bid;
        }

        public int Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public int DesiredQuantity { get => desiredQuantity; set => desiredQuantity = value; }
        public DateTime DeliveryByDate { get => deliveryByDate; set => deliveryByDate = value; }
        public int Bid { get => bid; set => bid = value; }
    }
}