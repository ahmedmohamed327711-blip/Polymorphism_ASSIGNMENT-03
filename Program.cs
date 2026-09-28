using Polymorphism_ASSIGNMENT_03.Classs;
using Polymorphism_ASSIGNMENT_03.Struct;

namespace Polymorphism_ASSIGNMENT_03
{
    internal class Program
    {
        private static DeliveryAddress destination;

        static void Main(string[] args)
        {

            #region Assignment01
            #region DeliveryAddress_obj
            DeliveryAddress address01 = new DeliveryAddress();
            address01.City = "Cairo";
            address01.Street = "ahmed helmy";
            address01.BuildingNumber = 1;
            Console.WriteLine(address01.GetFullAddress());
            DeliveryAddress address02 = new DeliveryAddress();
            address02.City = "alex";
            address02.Street = "helmy maher";
            address02.BuildingNumber = 2;
            Console.WriteLine(address02.GetFullAddress());
            #endregion

            #region Delivery Center

            DeliveryCenter deliveryCenter = new DeliveryCenter();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter Data For Shipment {i + 1}");
                Console.WriteLine();

                Console.Write("Tracking Code: ");
                string trackingCode = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Weight: ");
                decimal weight = decimal.Parse(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                decimal deliveryFee = decimal.Parse(Console.ReadLine());

                Console.Write("City: ");
                string city = Console.ReadLine();

                Console.Write("Street: ");
                string street = Console.ReadLine();

                Console.Write("Building Number: ");
                int buildingNumber = int.Parse(Console.ReadLine());

                DeliveryAddress address =
                    new DeliveryAddress(city, street, buildingNumber);

                Shipment shipment =
                    new Shipment(
                        trackingCode,
                        description,
                        weight,
                        deliveryFee,
                        address
                    );

                if (deliveryCenter.AddShipment(shipment))
                {
                    Console.WriteLine("Shipment added successfully.");
                }
                else
                {
                    Console.WriteLine("Delivery center is full.");
                }

                Console.WriteLine();
            }

            #endregion

            #region Print Shipments Using Integer Indexer
            for (int i = 0; i < 3; i++)
            {
                Shipment shipment = deliveryCenter[i];

                if (shipment != null)
                {
                    Console.WriteLine($"Shipment {i + 1}");
                    Console.WriteLine($"Tracking Code: {shipment.TrackingCode}");
                    Console.WriteLine($"Description: {shipment.Description}");
                    Console.WriteLine($"Weight: {shipment.Weight}");
                    Console.WriteLine($"Delivery Fee: {shipment.DeliveryFee}");
                    Console.WriteLine($"Estimated Cost: {shipment.EstimatedCost}");
                    Console.WriteLine(
                        $"Address: {shipment.Destination.GetFullAddress()}"
                    );

                    Console.WriteLine();
                }
            }
            #endregion

            #region Search By Tracking Code

            Console.Write("Enter Tracking Code To Search: ");
            string searchCode = Console.ReadLine();

            Shipment foundShipment = deliveryCenter[searchCode];
            if (foundShipment != null)
            {
                Console.WriteLine("Shipment Found");
                Console.WriteLine($"Tracking Code: {foundShipment.TrackingCode}");
                Console.WriteLine($"Description: {foundShipment.Description}");
                Console.WriteLine($"Weight: {foundShipment.Weight}");
                Console.WriteLine($"Delivery Fee: {foundShipment.DeliveryFee}");
                Console.WriteLine($"Estimated Cost: {foundShipment.EstimatedCost}");
                Console.WriteLine(
                    $"Address: {foundShipment.Destination.GetFullAddress()}"
                );
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }

            #endregion
            #endregion

            #region Assignment02

            Console.Write("Enter Center Name: ");
            string centerName = Console.ReadLine();

            DeliveryCenter deliveryCenter02 = new DeliveryCenter(centerName);

            Console.WriteLine();
            Console.WriteLine("Enter Standard Shipment Data");

            Console.Write("Tracking Code: ");
            string standardTrackingCode = Console.ReadLine();

            Console.Write("Description: ");
            string standardDescription = Console.ReadLine();

            Console.Write("Weight: ");
            decimal standardWeight = decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal standardDeliveryFee = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string standardCity = Console.ReadLine();

            Console.Write("Street: ");
            string standardStreet = Console.ReadLine();

            Console.Write("Building Number: ");
            int standardBuildingNumber = int.Parse(Console.ReadLine());

            DeliveryAddress standardAddress =
                new DeliveryAddress(
                    standardCity,
                    standardStreet,
                    standardBuildingNumber
                );

            StandardShipment standardShipment =
                new StandardShipment(
                    standardTrackingCode,
                    standardDescription,
                    standardWeight,
                    standardDeliveryFee,
                    standardAddress
                );

            Console.WriteLine();
            Console.WriteLine("Enter Express Shipment Data");

            Console.Write("Tracking Code: ");
            string expressTrackingCode = Console.ReadLine();

            Console.Write("Description: ");
            string expressDescription = Console.ReadLine();

            Console.Write("Weight: ");
            decimal expressWeight = decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal expressDeliveryFee = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string expressCity = Console.ReadLine();

            Console.Write("Street: ");
            string expressStreet = Console.ReadLine();

            Console.Write("Building Number: ");
            int expressBuildingNumber = int.Parse(Console.ReadLine());

            Console.Write("Extra Fee: ");
            decimal extraFee = decimal.Parse(Console.ReadLine());

            DeliveryAddress expressAddress =
                new DeliveryAddress(
                    expressCity,
                    expressStreet,
                    expressBuildingNumber
                );

            ExpressShipment expressShipment =
                new ExpressShipment(
                    expressTrackingCode,
                    expressDescription,
                    expressWeight,
                    expressDeliveryFee,
                    expressAddress,
                    extraFee
                );

            Console.WriteLine();
            Console.WriteLine("Enter International Shipment Data");

            Console.Write("Tracking Code: ");
            string internationalTrackingCode = Console.ReadLine();

            Console.Write("Description: ");
            string internationalDescription = Console.ReadLine();

            Console.Write("Weight: ");
            decimal internationalWeight = decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal internationalDeliveryFee = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string internationalCity = Console.ReadLine();

            Console.Write("Street: ");
            string internationalStreet = Console.ReadLine();

            Console.Write("Building Number: ");
            int internationalBuildingNumber = int.Parse(Console.ReadLine());

            Console.Write("Destination Country: ");
            string destinationCountry = Console.ReadLine();

            Console.Write("Customs Fee: ");
            decimal customsFee = decimal.Parse(Console.ReadLine());

            DeliveryAddress internationalAddress =
                new DeliveryAddress(
                    internationalCity,
                    internationalStreet,
                    internationalBuildingNumber
                );

            InternationalShipment internationalShipment =
                new InternationalShipment(
                    internationalTrackingCode,
                    internationalDescription,
                    internationalWeight,
                    internationalDeliveryFee,
                    internationalAddress,
                    destinationCountry,
                    customsFee
                );

            deliveryCenter02.AddShipment(standardShipment);
            deliveryCenter02.AddShipment(expressShipment);
            deliveryCenter02.AddShipment(internationalShipment);

          
            deliveryCenter02.PrintAllShipments();

            Console.WriteLine();
            Console.Write("Enter Tracking Code To Search: ");
            string searchTrackingCode = Console.ReadLine();

            Shipment foundShipment02 = deliveryCenter02[searchTrackingCode];

            if (foundShipment02 != null)
            {
                Console.WriteLine();
                Console.WriteLine("Shipment Found");
                foundShipment02.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment Not Found");
            }

            Console.WriteLine();
            Console.Write("Enter Tracking Code To Remove: ");
            string removeTrackingCode = Console.ReadLine();

            if (deliveryCenter02.RemoveShipment(removeTrackingCode))
            {
                Console.WriteLine("Shipment removed successfully.");
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }

            deliveryCenter02.PrintAllShipments();

            #endregion

            #region Assignment03

            #region Theoretical Questions
            //Q1 — Overloading, Overriding, and Binding

            //a
            //Method Overloading ==> it have the same method name but different parameters.
            //Method Overriding ==> it have the same method name and same parameters but different class or signature.

            //============================================================================================================

            //b
            //static Binding ==> it is a compile time binding, it is also called early binding. It is used in method overloading.
            //dynamic Binding ==> it is a run time binding, it is also called late binding. It is used in method overriding.

            //============================================================================================================

            //  Q2 Sealed Classes and Methods

            //a
            //sealed ==> it is use to prevent inheritance  ||  cannot be inherited,

            //============================================================================================================
            //b
            //sealed method ==> cannot be overridden in child classes.

            //============================================================================================================
            //c
            //No ==> because sealed method cannot be overridden in child classes.  
            #endregion


            #region 9-Checklist
            DeliveryCenter center = new DeliveryCenter("Cairo Delivery Center");
            StandardShipment standard = new StandardShipment(
                "SH001",
                "Laptop",
                3,
                80,
                destination);

            ExpressShipment express = new ExpressShipment(
                "SH002",
                "Mobile Phone",
                2,
                60,
                destination,
                30);

            InternationalShipment international = new InternationalShipment(
                "SH003",
                "Television",
                8,
                120,
                destination,
                "Germany",
                100);

            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

            center.PrintAllShipments();

            DeliveryHelper.PrintShipmentDetails(standard);
            DeliveryHelper.PrintShipmentDetails(express);
            DeliveryHelper.PrintShipmentDetails(international);

            Console.WriteLine($"Original Weight: {standard.Weight}");

            standard.UpdateWeight(5);

            Console.WriteLine($"Updated Weight: {standard.Weight}");

            standard.UpdateWeight(5, 0.5m);

            Console.WriteLine($"Updated Weight After Packing: {standard.Weight}");

            Shipment[] shipments =
            {
                standard,
                express,
                international
            };

            foreach (Shipment shipment in shipments)
            {
                shipment.PrintShipment();
            }

            #endregion
            #endregion

        }
    }
}
