namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01

            #region Question01

            /*
             * a) a)  What is Abstraction in Object-Oriented Programming?
             * ==> Answer <==
             * ==> Abstraction means hiding unnecessary details and showing only the important parts of an object.
             * 
             * b) Why is abstraction considered one of the four pillars of OOP?
             * => Answer <==
             * ==> Abstraction is one of the four pillars of OOP because it makes the code simpler, easier to understand, and easier to use by hiding complex implementation details.
             * **/

            #endregion

            #region Question02

            /*
             * a)  What is the difference between an Abstract Class and an Interface?
             * => Answer <==
             * ==> Abstract Class: Can contain normal methods, abstract methods, fields, and properties. A class can inherit from only one abstract class.
             * ==> Interface: Mainly defines what a class should do. A class can implement multiple interfaces.
             * 
             * b)  When would you choose an Interface instead of an Abstract Class?
             * => Answer <==
             * ==> We choose an Interface when different classes need to have the same behavior, even if they are not related by inheritance.
             * 
             * c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
             * => Answer <==
             * ==> A class cannot inherit from multiple abstract classes.
             * A class can implement multiple interfaces.
             * **/

            #endregion

            #endregion

            #region Part02

            #region Question01

            /*
             * 1) Convert Shipment into an Abstract Class
             * **/

            #endregion

            #region Question02

            /*
             * 2) Create Abstract Members
             * **/

            #endregion

            #region Question03

            /*
             * 3) Update All Shipment Types
             * **/

            #endregion

            #region Question04

            /*
             * 4) Create ITrackable
             * **/

            #endregion

            #region Question05

            /*
             * 5) Create IInsurable
             * **/

            #endregion

            #region Question06

            /*
             * 6) Create DeliveryReport
             * **/

            #endregion

            #region Question07

            /*
             * 7)  Update DeliveryCenter
             * **/

            #endregion

            #region Question08

            /*
             * 8)  Main() Checklist
             * **/
            // ==> Answer <==
            /*
             // Create Delivery Center
            DeliveryCenter center = new DeliveryCenter();

            // Create Standard Shipment
            StandardShipment standard = new StandardShipment(
                "SH001",
                "Laptop",
                3,
                80,
                new DeliveryAddress("Cairo", "Tahrir Street", 15)
            );

            // Create Express Shipment
            ExpressShipment express = new ExpressShipment(
                "SH002",
                "Mobile Phone",
                2,
                60,
                new DeliveryAddress("Cairo", "Nasr Street", 20),
                30
            );

            // Create International Shipment
            InternationalShipment international = new InternationalShipment(
                "SH003",
                "Television",
                8,
                120,
                new DeliveryAddress("Cairo", "Main Street", 10),
                "Germany",
                100
            );

            // Add shipments
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

            // Print all shipment details
            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            center.PrintAllShipments();

            Console.WriteLine("==========================================");
            Console.WriteLine();

            // Print Tracking Status
            Console.WriteLine("Tracking Status");
            Console.WriteLine();

            center.PrintTrackingStatuses();

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();

            // Print Insurance
            Console.WriteLine("Insurance");
            Console.WriteLine();

            Console.WriteLine(
                "Standard Shipment Insurance : " +
                standard.CalculateInsurance().ToString("0.00") +
                " EGP");

            Console.WriteLine();

            Console.WriteLine(
                "Express Shipment Insurance : " +
                express.CalculateInsurance().ToString("0.00") +
                " EGP");

            Console.WriteLine();

            Console.WriteLine(
                "International Shipment Insurance : " +
                international.CalculateInsurance().ToString("0.00") +
                " EGP");

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();

            // ITrackable Array
            ITrackable[] trackableShipments =
            {
                standard,
                express,
                international
            };

            Console.WriteLine("Interface Polymorphism - Tracking");
            Console.WriteLine();

            foreach (ITrackable shipment in trackableShipments)
            {
                Console.WriteLine(shipment.GetTrackingStatus());
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();

            // IInsurable Array
            IInsurable[] insurableShipments =
            {
                standard,
                express,
                international
            };

            Console.WriteLine("Interface Polymorphism - Insurance");
            Console.WriteLine();

            foreach (IInsurable shipment in insurableShipments)
            {
                Console.WriteLine(
                    "Insurance: " +
                    shipment.CalculateInsurance().ToString("0.00") +
                    " EGP");
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();

            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");

            Console.ReadKey();
             */

            #endregion

            #endregion
        }
    }
}
