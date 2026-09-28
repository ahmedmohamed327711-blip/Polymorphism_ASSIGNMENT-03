using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_ASSIGNMENT_03.Struct
{
    internal class Shipment
    {
        #region Attrubites
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        #endregion

        #region Proubity
        public string TrackingCode {
            get {
                return trackingCode;
            }
        } 

        public string Description
        {
            get { return description;}
            set
            {
                if (!string.IsNullOrWhiteSpace(value)){
                    description = value;
                }
            }
        }

        public decimal Weight
        {
            get { return weight;}
            set {
                if (value > 0)
                {
                    weight = value;
                }                     
            }
        }


        public decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }
           private set
            {
                if(value > 0)
                {
                    deliveryFee = value;
                }
            }
        }

        public DeliveryAddress Destination { get; set; }

        //Comuted property 
        public virtual decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);
            }
        }
        #endregion

        #region Constructor
        public Shipment() { }
        public Shipment(string TrackingCode)
        {
            trackingCode = TrackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = default;
        }

        public Shipment(string TrackingCode,string Description,decimal Weight,decimal DeliveryFee,DeliveryAddress destination)
        {
           trackingCode= TrackingCode;
            description= Description;
            weight= Weight; 
            deliveryFee= DeliveryFee;
            Destination = destination;
        }
        #endregion

        #region Functions
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                deliveryFee = newFee;
            }
            else
            {
                DeliveryFee = newFee;
            }
        }

        public virtual void PrintShipment()
        {
            Console.WriteLine(TrackingCode);
            Console.WriteLine(Description);
            Console.WriteLine(Weight);
            Console.WriteLine(DeliveryFee);
            Console.WriteLine(Destination.GetFullAddress());
        } 


        public void UpdateWeight(decimal newWeight)
        {
            
            Weight = newWeight;
        }
        public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            Weight = newWeight + extraPackingWeight;    
        }
        #endregion
    }
}
