using Polymorphism_ASSIGNMENT_03.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_ASSIGNMENT_03.Classs
{
    internal class ExpressShipment: Shipment
    {
        //private decimal expressFee;
        private decimal extraFee;

        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Extra fee cannot be negative.");
                }

                extraFee = value;
            }
        }
        public ExpressShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            decimal extraFee)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination)
        {
            ExtraFee = extraFee;
        }


        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + ExtraFee;
            }
        }

        public override void PrintShipment()
        {
            base.PrintShipment();

            Console.WriteLine($"Extra Fee: {ExtraFee}");
        }
    }
}
