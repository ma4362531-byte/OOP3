//using System.Timers;

//namespace OOP3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
#region Q1 Part1

//(A)What is the difference between Method Overloading and Method Overriding?

//      Method Overloading means having multiple methods with the same name but different parameters.
//Method Overriding means providing a new implementation for an inherited method in a derived class.

//           (B) What is the difference between Static Binding and Dynamic Binding?


//            Static Binding determines the method to be executed at compile time.
//Dynamic Binding determines the method to be executed at runtime.


#region Q2 

//       (A)     What is the purpose of the sealed keyword when applied to a class?


//The sealed keyword prevents other classes from inheriting from that class.

//       (B)What is the difference between a sealed class and a sealed method?


//A sealed class prevents inheritance, while a sealed method prevents further overriding in derived classes.

//          (C)  Can a sealed method be overridden? Why?


//No, a sealed method cannot be overridden because the sealed keyword prevents further overriding in derived classes.

#endregion

#endregion

#region part2
//using System;
//using System.Collections.Generic;

//namespace LogisticsSystem
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
          
//            Driver driver = new Driver(1, "Mohamed Hamada", "01000000000");

            
//            DeliveryCenter center = new DeliveryCenter();

           
//            center.Driver = driver;

//            DeliveryAddress defaultAddress = new DeliveryAddress("123 St", "Cairo", "Egypt");

            
//            StandardShipment std = new StandardShipment("SH001", "Laptop", 3, 35, defaultAddress);
//            ExpressShipment exp = new ExpressShipment("SH002", "Mobile Phone", 2, 60, defaultAddress, 30);
//            InternationalShipment intl = new InternationalShipment("SH003", "Television", 5, 120, defaultAddress, "Germany", 100);

            
//            center.AddShipment(std);
//            center.AddShipment(exp);
//            center.AddShipment(intl);

        
//            center.PrintAllShipments();

            
//            Console.WriteLine("Printing Using DeliveryHelper...\n");
//            DeliveryHelper.PrintShipmentDetails(std);
//            DeliveryHelper.PrintShipmentDetails(exp);
//            DeliveryHelper.PrintShipmentDetails(intl);

//            Console.WriteLine("\n================================================\n");

            
//            Console.WriteLine("Updating Weight...\n");
//            Console.WriteLine($"Original Weight : {std.Weight} KG\n");

//            std.UpdateWeight(5);
//            Console.WriteLine($"Updated Weight : {std.Weight} KG\n");

//            std.UpdateWeight(5, 0.5);
//            Console.WriteLine($"Updated Weight After Packing : {std.Weight} KG\n");

//            Console.WriteLine("================================================\n");

            
//            Console.WriteLine("Printing Using Shipment[]...\n");
//            Shipment[] shipmentArray = new Shipment[] { std, exp, intl };

//            foreach (var item in shipmentArray)
//            {
//                if (item is StandardShipment)
//                    Console.WriteLine("Standard Shipment...\n");
//                else if (item is ExpressShipment)
//                    Console.WriteLine("Express Shipment...\n");
//                else if (item is InternationalShipment)
//                    Console.WriteLine("International Shipment...\n");
//            }

//            Console.WriteLine("================================================");
//        }
//    }

//    public class Driver
//    {
//        public int DriverId { get; set; }
//        public string FullName { get; set; }
//        public string PhoneNumber { get; set; }

//        public Driver(int driverId, string fullName, string phoneNumber)
//        {
//            DriverId = driverId;
//            FullName = fullName;
//            PhoneNumber = phoneNumber;
//        }
//    }

//    public class DeliveryAddress
//    {
//        public string Street { get; set; }
//        public string City { get; set; }
//        public string Country { get; set; }

//        public DeliveryAddress(string street, string city, string country)
//        {
//            Street = street;
//            City = city;
//            Country = country;
//        }
//    }

//    public class Shipment
//    {
//        public string TrackingCode { get; set; }
//        public string Description { get; set; }
//        public double Weight { get; set; }
//        public decimal DeliveryFee { get; set; }
//        public DeliveryAddress Address { get; set; }

//        public virtual decimal EstimatedCost => DeliveryFee;

//        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress address)
//        {
//            TrackingCode = trackingCode;
//            Description = description;
//            Weight = weight;
//            DeliveryFee = deliveryFee;
//            Address = address;
//        }

//        public void UpdateWeight(double newWeight) => Weight = newWeight;
//        public void UpdateWeight(double newWeight, double packingWeight) => Weight = newWeight + packingWeight;

//        public virtual void PrintShipment()
//        {
//            Console.WriteLine($"Tracking Code : {TrackingCode}");
//            Console.WriteLine($"Description   : {Description}");
//            Console.WriteLine($"Weight        : {Weight} KG");
//            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
//        }
//    }

//    public class StandardShipment : Shipment
//    {
//        public StandardShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress address)
//            : base(trackingCode, description, weight, deliveryFee, address) { }

//        public override void PrintShipment()
//        {
//            Console.WriteLine("Standard Shipment\n");
//            base.PrintShipment();
//            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
//        }
//    }

//    public class ExpressShipment : Shipment
//    {
//        public decimal ExtraFee { get; set; }

//        public ExpressShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress address, decimal extraFee)
//            : base(trackingCode, description, weight, deliveryFee, address)
//        {
//            ExtraFee = extraFee;
//        }

//        public override decimal EstimatedCost => DeliveryFee + ((decimal)Weight * 5m) + ExtraFee;

//        public override void PrintShipment()
//        {
//            Console.WriteLine("Express Shipment\n");
//            base.PrintShipment();
//            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
//            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
//        }
//    }

//    public class InternationalShipment : Shipment
//    {
//        public string DestinationCountry { get; set; }
//        public decimal CustomsFee { get; set; }

//        public InternationalShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress address, string destinationCountry, decimal customsFee)
//            : base(trackingCode, description, weight, deliveryFee, address)
//        {
//            DestinationCountry = destinationCountry;
//            CustomsFee = customsFee;
//        }

//        public override decimal EstimatedCost => DeliveryFee + ((decimal)Weight * 5m) + CustomsFee;

//        public override void PrintShipment()
//        {
//            Console.WriteLine("International Shipment\n");
//            base.PrintShipment();
//            Console.WriteLine($"Destination Country : {DestinationCountry}");
//            Console.WriteLine($"Customs Fee        : {CustomsFee} EGP");
//            Console.WriteLine($"Estimated Cost     : {EstimatedCost} EGP");
//        }
//    }

//    public class DeliveryCenter
//    {
//        public Driver Driver { get; set; }
//        private List<Shipment> _shipments = new List<Shipment>();

//        public void AddShipment(Shipment shipment) => _shipments.Add(shipment);

//        public void PrintAllShipments()
//        {
//            Console.WriteLine("================================================");
//            Console.WriteLine("Delivery Center");
//            Console.WriteLine("================================================");
//            if (Driver != null) Console.WriteLine($"Driver : {Driver.FullName}");
//            Console.WriteLine("------------------------------------------------");

//            foreach (var s in _shipments)
//            {
//                s.PrintShipment();
//                Console.WriteLine("------------------------------------------------\n");
//            }
//        }
//    }

//    public static class DeliveryHelper
//    {
//        public static void PrintShipmentDetails(Shipment shipment)
//        {
//            if (shipment is StandardShipment) Console.WriteLine("Standard Shipment Printed Successfully.");
//            else if (shipment is ExpressShipment) Console.WriteLine("Express Shipment Printed Successfully.");
//            else if (shipment is InternationalShipment) Console.WriteLine("International Shipment Printed Successfully.");
//        }
//    }
//}



#endregion



//        }
//    }
//}
