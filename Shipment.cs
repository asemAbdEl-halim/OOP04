using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    internal abstract class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        private DeliveryAddress destination;

        // Constructor 1
        public Shipment(string trackingCode)
            : this(
                trackingCode,
                "Unknown",
                1,
                50,
                new DeliveryAddress("Cairo", "Unknown", 1))
        {
        }

        // Constructor 2
        public Shipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
        {
            if (!string.IsNullOrWhiteSpace(trackingCode))
                this.trackingCode = trackingCode;

            if (!string.IsNullOrWhiteSpace(description))
                this.description = description;

            if (weight > 0)
                this.weight = weight;

            if (deliveryFee > 0)
                this.deliveryFee = deliveryFee;

            this.destination = destination;
        }

        // Read Only
        public string TrackingCode
        {
            get { return trackingCode; }
        }

        // Read / Write
        public string Description
        {
            get { return description; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }

        // Read / Write
        public decimal Weight
        {
            get { return weight; }

            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        // Public Getter - Private Setter
        public decimal DeliveryFee
        {
            get { return deliveryFee; }

            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        // Read / Write
        public DeliveryAddress Destination
        {
            get { return destination; }

            set
            {
                destination = value;
            }
        }

        // Abstract Method
        public abstract decimal EstimatedCost();

        // Update Delivery Fee
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }

        // Method Overloading - First Version
        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
            {
                Weight = newWeight;
            }
        }

        // Method Overloading - Second Version
        public void UpdateWeight(decimal newWeight, decimal packingWeight)
        {
            if (newWeight > 0 && packingWeight >= 0)
            {
                Weight = newWeight + packingWeight;
            }
        }

        // Abstract Method
        public abstract void PrintShipment();
    }
}
