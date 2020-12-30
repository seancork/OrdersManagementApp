using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace seanoneill.Pages
{
    public static class MainMenu
    {
        public static class Customer
        {
            public const string PageName = "Customer";
            public const string RoleName = "Customer";
            public const string Path = "/Customer/Index";
            public const string ControllerName = "Customer";
            public const string ActionName = "Index";
        }

        public static class Report
        {
            public const string PageName = "Report";
            public const string RoleName = "Report";
            public const string Path = "/Report/Index";
            public const string ControllerName = "Report";
            public const string ActionName = "Index";
        }


        public static class Order
        {
            public const string PageName = "Order";
            public const string RoleName = "Customer";
            public const string Path = "/order/Index";
            public const string ControllerName = "Order";
            public const string ActionName = "Index";
        }


        public static class Product
        {
            public const string PageName = "Product";
            public const string RoleName = "Product";
            public const string Path = "/Product/Index";
            public const string ControllerName = "Product";
            public const string ActionName = "Index";
        }

    }
}
