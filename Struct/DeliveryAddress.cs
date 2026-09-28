using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_ASSIGNMENT_03.Struct
{
    internal struct DeliveryAddress
    {
        #region Propuity
        public string City { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        #endregion

        #region Constructor
        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }
        #endregion

        #region Methods
        public string GetFullAddress()
        {
            return $" City is {City} == Street is  {Street} == BuildingNumber= {BuildingNumber}";
        }
        #endregion
    }
}
