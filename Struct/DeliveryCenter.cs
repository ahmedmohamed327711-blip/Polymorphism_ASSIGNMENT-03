using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_ASSIGNMENT_03.Struct
{
    internal class DeliveryCenter
    {
        #region Attrubites
        private Shipment[] shipments;
        #endregion

        #region Prop
        public string CenterName { get; set; }

        #endregion

        #region Constructor
        public DeliveryCenter()
        {
            shipments = new Shipment[10];
        }

        public DeliveryCenter(string centerName)
        {
            CenterName = centerName;
            shipments = new Shipment[20];
        }
        #endregion

        #region Indexer

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                {
                    return shipments[index];
                }

                return default;
            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                {
                    shipments[index] = value;
                }
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                foreach (Shipment shipment in shipments)
                {
                    if (shipment.TrackingCode == trackingCode)
                    {
                        return shipment;
                    }
                }

                return default;
            }
        }

        #endregion


        #region Methods
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }
        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null &&
                    shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }

            return false;
        }

        public void PrintAllShipments()
        {
            foreach (Shipment shipment in shipments)
            {
                if (shipment != null)
                {
                    shipment.PrintShipment();
                }
            }
        }
    #endregion
}
}
