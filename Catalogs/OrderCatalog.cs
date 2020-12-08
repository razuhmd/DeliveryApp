using DeliveryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.Catalogs
{
    public class OrderCatalog
    {
        private Dictionary<int, Order> orders { get; }

        private OrderAddresss oAddress1 = new OrderAddresss() { OrderAddressId = 1, CustomerName = "Alex", StreetHouse = "Peterbangsvej 16, 2tv", PostCode = 2025, Town = "København", CustomerPhone = "32314565" };
        private OrderAddresss oAddress2 = new OrderAddresss() { OrderAddressId = 2, CustomerName = "Catalina", StreetHouse = "Peterbangsvej 17, 1tv", PostCode = 1625, Town = "København", CustomerPhone = "22314577" };

        private Vendor vendor1 = new Vendor() { VendorId = 1, VendorName = "XYZ", VendorAddress = "Gulmarsplan 1, 1616 Odense", VendorPhoneNumber = "71235421", VendorEmail = "xyz@gmail.org" };
        private Vendor vendor2 = new Vendor() { VendorId = 2, VendorName = "ABC", VendorAddress = "Gulmarsplan 2, 1616 Odense", VendorPhoneNumber = "71235422", VendorEmail = "abc@gmail.org" };
        public OrderCatalog()
        {
            orders = new Dictionary<int, Order>();
            orders.Add(1, new Order() { OrderId = 1, ExpectedDeliveryDate = DateTime.Today, Address = oAddress1, Vendor = vendor1});
            orders.Add(2, new Order() { OrderId = 2, ExpectedDeliveryDate = DateTime.Today, Address = oAddress2, Vendor = vendor2});
            orders.Add(3, new Order() { OrderId = 3, ExpectedDeliveryDate = DateTime.Today, Address = oAddress1, Vendor= vendor1});
            orders.Add(4, new Order() { OrderId = 4, ExpectedDeliveryDate = DateTime.Today, Address = oAddress2, Vendor = vendor2});
        }

        public Dictionary<int, Order> AllOrders()
        {
            return orders;
        }

        public void AddOrder(Order order)
        {
            orders.Add(order.OrderId, order);
        }

        public void RemoveOrder(Order order)
        {
            orders.Remove(order.OrderId);
        }
    }
}
