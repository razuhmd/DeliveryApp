using DeliveryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DeliveryApp.Catalogs
{
    public class RouteCatalog
    {
        private Dictionary<int, Route> routes { get; }

        private EmployeeCatalog _eCatalog;
                
        public RouteCatalog(EmployeeCatalog eCatalog)
        {
            _eCatalog = eCatalog;
            routes = new Dictionary<int, Route>();
            routes.Add(KeyGenerator(), new Route() { RouteId = 53, PostCodes = new List<int>(){ 2635, 2000, 2100 }, Employee = _eCatalog.GetEmployeeById(1) }); ;
            routes.Add(KeyGenerator(), new Route() { RouteId = 54, PostCodes = new List<int>() { 2780, 2800, 2900 } });
        }

        //public int IdGenerator()
        //{
        //    List<int> idList = new List<int>();
        //    int id = 1;
        //    foreach (var item in rutes.Values)
        //    {
        //        idList.Add(item.RuteId);
        //    }
        //    if (idList.Count != 0)
        //    {
        //        id = idList.Max() + 1;
        //    }
        //    return id;
        //}

        public int KeyGenerator()
        {
            List<int> keyList = new List<int>();
            int key = 1;
            foreach (var item in routes.Keys)
            {
                keyList.Add(item);
            }
            if (keyList.Count != 0)
            {
                key = keyList.Max() + 1;
            }
            return key;
        }

        public Dictionary<int, Route> AllRoutes()
        {
            return routes;
        }

        public void AddRoute(Route route)
        {
            routes.Add(route.RouteId, route);
        }

        public void RemoveRoute(Route route)
        {
            routes.Remove(route.RouteId);
        }

        public bool UpdateRoute(int routeId, Route route)
        {
            foreach (var routeItem in routes)
            {
                if (routeItem.Value.RouteId == routeId)
                {
                    routeItem.Value.RouteId = route.RouteId;
                    routeItem.Value.PostCodes = route.PostCodes;
                    routeItem.Value.Employee = route.Employee;

                    return true;
                }                
            }
            return false;
        }

    }
}
