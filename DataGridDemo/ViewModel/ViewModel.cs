using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridDemo
{
    public class ViewModel
    {
        public ObservableCollection<OrderInfo> Orders { get; set; }

        public ViewModel()
        {
            Orders = new ObservableCollection<OrderInfo>();
            GenerateOrders();
        }

        private void GenerateOrders()
        {
            var order1 = new OrderInfo
            {
                Customers = new CustomerInfo
                {
                    CustomerName = "Maria Anders",
                    City = "Berlin",
                    Country = "Germany"
                },
                ShippersInfo = new ShipperDetails[]
                {
                new ShipperDetails { ShipperID = 1, CompanyName = "Speedy Express" },
                new ShipperDetails { ShipperID = 2, CompanyName = "United Package" }
                }
            };

            var order2 = new OrderInfo
            {
                Customers = new CustomerInfo
                {
                    CustomerName = "Ana Trujillo",
                    City = "México D.F.",
                    Country = "Mexico"
                },
                ShippersInfo = new ShipperDetails[]
                {
                new ShipperDetails { ShipperID = 3, CompanyName = "Federal Shipping" }
                }
            };

            var order3 = new OrderInfo
            {
                Customers = new CustomerInfo
                {
                    CustomerName = "Thomas Hardy",
                    City = "London",
                    Country = "UK"
                },
                ShippersInfo = new ShipperDetails[]
                {
                new ShipperDetails { ShipperID = 5, CompanyName = "Speedy Express" },
                new ShipperDetails { ShipperID = 3, CompanyName = "Federal Shipping" },
                new ShipperDetails { ShipperID = 5, CompanyName = "Federal Shipping" }

                }
            };

            var order4 = new OrderInfo
            {
                Customers = new CustomerInfo
                {
                    CustomerName = "Marsh",
                    City = "London",
                    Country = "UK"
                },
                ShippersInfo = new ShipperDetails[]
               {
                new ShipperDetails { ShipperID = 8, CompanyName = "Speedy Express" },

               }
            };

            var order5 = new OrderInfo
            {
                Customers = new CustomerInfo
                {
                    CustomerName = "Milton",
                    City = "London",
                    Country = "UK"
                },
                ShippersInfo = new ShipperDetails[]
               {
                new ShipperDetails { ShipperID = 3, CompanyName = "Speedy Express" },

               }
            };

            Orders.Add(order1);
            Orders.Add(order2);
            Orders.Add(order3);
            Orders.Add(order4);
            Orders.Add(order5);

        }
    }
}

