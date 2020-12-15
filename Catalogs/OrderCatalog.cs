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
            orders.Add(KeyGenerator(), new Order() { OrderId = IdGenerator(), ExpectedDeliveryDate = DateTime.Today, Address = oAddress1, Vendor = vendor1});
            orders.Add(KeyGenerator(), new Order() { OrderId = IdGenerator(), ExpectedDeliveryDate = DateTime.Today, Address = oAddress2, Vendor = vendor2});
            orders.Add(KeyGenerator(), new Order() { OrderId = IdGenerator(), ExpectedDeliveryDate = DateTime.Today, Address = oAddress1, Vendor= vendor1});
            orders.Add(KeyGenerator(), new Order() { OrderId = IdGenerator(), ExpectedDeliveryDate = DateTime.Today, Address = oAddress2, Vendor = vendor2});
        }

        public int IdGenerator()
        {
            List<int> idList = new List<int>();
            int id = 1;
            foreach (var item in orders.Values)
            {
                idList.Add(item.OrderId);
            }
            if(idList.Count !=0)
            {
                id = idList.Max() + 1;
            }           
            return id;
        }

        public int KeyGenerator()
        {
            List<int> keyList = new List<int>();
            int key = 1;
            foreach (var item in orders.Keys)
            {
                keyList.Add(item);
            }
            if (keyList.Count != 0)
            {
                key = keyList.Max() + 1;
            }
            return key;
        }

        public Dictionary<int, Order> AllOrders()
        {
            return orders;
        }

        public Order GetOrderById(int id)
        {
            foreach (var order in orders.Values)
            {
                if (order.OrderId == id)
                {
                    return order;
                }
            }
            return null;
        }

        public void AddOrder(Order order)
        {
            order.OrderId = IdGenerator();
            orders.Add(KeyGenerator(), order);
        }

        public void RemoveOrder(Order order)
        {
            orders.Remove(order.OrderId);
        }

        public bool UpdateOrder(Order editOrder)
        {
            foreach (var orderItem in orders.Values)
            {
                if (orderItem.OrderId == editOrder.OrderId)
                {
                    orderItem.OrderId = editOrder.OrderId;
                    orderItem.ExpectedDeliveryDate = editOrder.ExpectedDeliveryDate;
                    orderItem.Address.OrderAddressId = editOrder.Address.OrderAddressId;
                    orderItem.Address.CustomerName = editOrder.Address.CustomerName;
                    orderItem.Address.StreetHouse = editOrder.Address.StreetHouse;
                    orderItem.Address.PostCode = editOrder.Address.PostCode;
                    orderItem.Address.Town = editOrder.Address.Town;
                    orderItem.Address.OrderAddressId = editOrder.Address.OrderAddressId;
                    orderItem.Address.CustomerPhone = editOrder.Address.CustomerPhone;
                    orderItem.Vendor.VendorId = editOrder.Vendor.VendorId;
                    orderItem.Vendor.VendorName = editOrder.Vendor.VendorName;
                    orderItem.Vendor.VendorAddress = editOrder.Vendor.VendorAddress;
                    orderItem.Vendor.VendorPhoneNumber = editOrder.Vendor.VendorPhoneNumber;
                    orderItem.Vendor.VendorEmail = editOrder.Vendor.VendorEmail;

                    return true;
                }
            }
            return false;
        }

        public Dictionary<int, Order> Search(string searchFor)
        {
            Dictionary<int, Order> searchedOrder = new Dictionary<int, Order>();

            foreach (var order in orders.Values)
            {
                if (order.Address.CustomerName.StartsWith(searchFor) || order.Address.CustomerPhone.StartsWith(searchFor) || order.Address.StreetHouse.StartsWith(searchFor) || order.Address.Town.StartsWith(searchFor) || order.Vendor.VendorName.StartsWith(searchFor) || order.Vendor.VendorAddress.StartsWith(searchFor) || order.Vendor.VendorEmail.StartsWith(searchFor) || order.Vendor.VendorPhoneNumber.StartsWith(searchFor))
                {
                    searchedOrder.Add(order.OrderId, order);
                }
            }

            return searchedOrder;
        }
    }
}
