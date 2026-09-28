using Polymorphism_ASSIGNMENT_03.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_ASSIGNMENT_03.Classs
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
            : base(
            trackingCode,
            description,
            weight,
            deliveryFee,
            destination)
        {
        }
        public override void PrintShipment()
        {
            base.PrintShipment();
        }
    }
}
