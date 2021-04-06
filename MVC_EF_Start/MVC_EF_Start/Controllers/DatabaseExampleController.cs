using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_EF_Start.DataAccess;
using MVC_EF_Start.Models;

namespace MVC_EF_Start.Controllers
{
    public class DatabaseExampleController : Controller
    {
        public ApplicationDbContext dbContext;

        public DatabaseExampleController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<ViewResult> DatabaseOperations()
        {

            Store store = new Store();
            store.storeId = 1;
            store.storeName = "Wallmart";

            Products p1 = new Products();
            p1.ProductId = 1;
            p1.name = "Oil";
            p1.cost = 100;
            p1.store = store;

            Products p2 = new Products();
            p2.ProductId = 2;
            p2.name = "Gas";
            p2.cost = 200;
            p2.store = store;

            Products p3 = new Products();
            p3.ProductId = 3;
            p3.name = "Iphone";
            p3.cost = 30;
            p3.store = store;

            Products p4 = new Products();
            p4.ProductId = 4;
            p4.name = "cream";
            p4.cost = 60;
            p4.store = store;


            Products p5 = new Products();
            p5.ProductId = 5;
            p5.name = "sunflower OIL";
            p5.cost = 90;
            p5.store = store;

            Products p6 = new Products();
            p6.ProductId = 6;
            p6.name = "ShowerHandle";
            p6.cost = 190;
            p6.store = store;

            Products p7 = new Products();
            p7.ProductId = 7;
            p7.name = "Oven";
            p7.cost = 200;
            p7.store = store;

            Products p8 = new Products();
            p8.ProductId = 8;
            p8.name = "Laptop";
            p8.cost = 34;
            p8.store = store;

            Products p9 = new Products();
            p9.ProductId = 9;
            p9.name = "apples";
            p9.cost = 50;
            p9.store = store;

            Products p10 = new Products();
            p10.ProductId = 10;
            p10.name = "Oranges";
            p10.cost = 98;
            p10.store = store;

            Orders o1 = new Orders();
            o1.OrderId = 1;
            o1.OrderTotal = 2000;
            o1.OrderTime = "05-21-2020 12:01:54";
            o1.store = store;

            Orders o2 = new Orders();
            o2.OrderId = 2;
            o2.OrderTotal = 200;
            o1.OrderTime = "04-12-2020 13:45:12";
            o2.store = store;

            Orders o3 = new Orders();
            o3.OrderId = 3;
            o3.OrderTotal = 2200;
            o3.OrderTime = "02-12-2019 12:34:22";
            o3.store = store;

            Orders o4 = new Orders();
            o4.OrderId = 4;
            o4.OrderTotal = 2040;
            o4.OrderTime = "06-22-2020 14:54:22";
            o4.store = store;

            Orders o5 = new Orders();
            o5.OrderId = 5;
            o5.OrderTotal = 2010;
            o5.OrderTime = "04-21-2020 13:43:12";
            o5.store = store;

            Orders o6 = new Orders();
            o6.OrderId = 6;
            o6.OrderTotal = 2300;
            o6.OrderTime = "01-23-2020 1:00:12";
            o6.store = store;

            Orders o7 = new Orders();
            o7.OrderId = 7;
            o7.OrderTotal = 2400;
            o7.OrderTime = "03-18-2020 15:34:12";
            o7.store = store;

            Orders o8 = new Orders();
            o8.OrderId = 8;
            o8.OrderTotal = 800;
            o8.OrderTime = "08-03-2020 18:45:11";
            o8.store = store;

            Orders o9 = new Orders();
            o9.OrderId = 9;
            o9.OrderTime = "05-05-21 12:34:33";
            o9.OrderTotal = 8700;
            o9.store = store;

            Orders o10 = new Orders();
            o10.OrderId = 10;
            o10.OrderTotal = 100;
            o10.OrderTime = "03-01-2020 19:22:01";
            o10.store = store;


            OrderProductMap op1 = new OrderProductMap
            {
                order = o1,
                product = p1,
                pquantity = 10
            };


            OrderProductMap op2 = new OrderProductMap
            {
                order = o1,
                product = p2,
                pquantity = 100
            };


            OrderProductMap op3 = new OrderProductMap
            {
                order = o1,
                product = p3,
                pquantity = 15
            };


            OrderProductMap op4 = new OrderProductMap
            {
                order = o1,
                product = p7,
                pquantity = 1
            };


            OrderProductMap op5 = new OrderProductMap
            {
                order = o1,
                product = p5,
                pquantity = 8
            };

            OrderProductMap op6 = new OrderProductMap
            {
                order = o1,
                product = p10,
                pquantity = 10
            };



            OrderProductMap op7 = new OrderProductMap
            {
                order = o2,
                product = p1,
                pquantity = 66
            };


            OrderProductMap op8 = new OrderProductMap
            {
                order = o2,
                product = p5,
                pquantity = 40
            };


            OrderProductMap op9 = new OrderProductMap
            {
                order = o2,
                product = p9,
                pquantity = 115
            };


            OrderProductMap op10 = new OrderProductMap
            {
                order = o3,
                product = p7,
                pquantity = 132
            };


            OrderProductMap op11 = new OrderProductMap
            {
                order = o3,
                product = p9,
                pquantity = 83
            };

            OrderProductMap op12 = new OrderProductMap
            {
                order = o3,
                product = p1,
                pquantity = 110
            };

            OrderProductMap op13 = new OrderProductMap
            {
                order = o3,
                product = p2,
                pquantity = 11
            };

            OrderProductMap op14 = new OrderProductMap
            {
                order = o3,
                product = p6,
                pquantity = 15
            };


            OrderProductMap op15 = new OrderProductMap
            {
                order = o3,
                product = p8,
                pquantity = 190
            };


            OrderProductMap op16 = new OrderProductMap
            {
                order = o4,
                product = p1,
                pquantity = 11
            };


            OrderProductMap op17 = new OrderProductMap
            {
                order = o4,
                product = p7,
                pquantity = 111
            };


            OrderProductMap op18 = new OrderProductMap
            {
                order = o4,
                product = p3,
                pquantity = 80
            };

            OrderProductMap op19 = new OrderProductMap
            {
                order = o4,
                product = p6,
                pquantity = 140
            };



            OrderProductMap op20 = new OrderProductMap
            {
                order = o5,
                product = p1,
                pquantity = 600
            };

            OrderProductMap op21 = new OrderProductMap
            {
                order = o5,
                product = p3,
                pquantity = 1
            };



            OrderProductMap op22 = new OrderProductMap
            {
                order = o6,
                product = p2,
                pquantity = 300
            };


            OrderProductMap op23 = new OrderProductMap
            {
                order = o6,
                product = p3,
                pquantity = 15
            };


            OrderProductMap op24 = new OrderProductMap
            {
                order = o6,
                product = p7,
                pquantity = 11
            };


            OrderProductMap op25 = new OrderProductMap
            {
                order = o7,
                product = p1,
                pquantity = 8
            };

            OrderProductMap op26 = new OrderProductMap
            {
                order = o7,
                product = p4,
                pquantity = 110
            };



            OrderProductMap op27 = new OrderProductMap
            {
                order = o8,
                product = p1,
                pquantity = 30
            };


            OrderProductMap op28 = new OrderProductMap
            {
                order = o8,
                product = p6,
                pquantity = 35
            };


            OrderProductMap op29 = new OrderProductMap
            {
                order = o8,
                product = p3,
                pquantity = 15
            };


            OrderProductMap op30 = new OrderProductMap
            {
                order = o9,
                product = p2,
                pquantity = 158
            };


            OrderProductMap op31 = new OrderProductMap
            {
                order = o10,
                product = p8,
                pquantity = 980
            };




            dbContext.Products.Add(p1);
            dbContext.Products.Add(p2);
            dbContext.Products.Add(p3);
            dbContext.Products.Add(p4);
            dbContext.Products.Add(p5);
            dbContext.Products.Add(p6);
            dbContext.Products.Add(p7);
            dbContext.Products.Add(p8);
            dbContext.Products.Add(p9);
            dbContext.Products.Add(p10);

            dbContext.Orders.Add(o1);
            dbContext.Orders.Add(o2);
            dbContext.Orders.Add(o3);
            dbContext.Orders.Add(o4);
            dbContext.Orders.Add(o5);
            dbContext.Orders.Add(o6);
            dbContext.Orders.Add(o7);
            dbContext.Orders.Add(o8);
            dbContext.Orders.Add(o9);
            dbContext.Orders.Add(o10);


            dbContext.OrderProductMaps.Add(op1);
            dbContext.OrderProductMaps.Add(op2);
            dbContext.OrderProductMaps.Add(op3);
            dbContext.OrderProductMaps.Add(op4);
            dbContext.OrderProductMaps.Add(op5);
            dbContext.OrderProductMaps.Add(op6);
            dbContext.OrderProductMaps.Add(op7);
            dbContext.OrderProductMaps.Add(op8);
            dbContext.OrderProductMaps.Add(op9);
            dbContext.OrderProductMaps.Add(op10);
            dbContext.OrderProductMaps.Add(op11);
            dbContext.OrderProductMaps.Add(op12);
            dbContext.OrderProductMaps.Add(op13);
            dbContext.OrderProductMaps.Add(op14);
            dbContext.OrderProductMaps.Add(op15);
            dbContext.OrderProductMaps.Add(op16);
            dbContext.OrderProductMaps.Add(op17);
            dbContext.OrderProductMaps.Add(op18);
            dbContext.OrderProductMaps.Add(op19);
            dbContext.OrderProductMaps.Add(op20);
            dbContext.OrderProductMaps.Add(op21);
            dbContext.OrderProductMaps.Add(op22);
            dbContext.OrderProductMaps.Add(op23);
            dbContext.OrderProductMaps.Add(op24);
            dbContext.OrderProductMaps.Add(op25);
            dbContext.OrderProductMaps.Add(op26);
            dbContext.OrderProductMaps.Add(op27);
            dbContext.OrderProductMaps.Add(op28);
            dbContext.OrderProductMaps.Add(op29);
            dbContext.OrderProductMaps.Add(op30);
            dbContext.OrderProductMaps.Add(op31);
            dbContext.SaveChanges();



            return View();
        }

        public ViewResult LINQOperations()
        {

            //Geting List of orders Where a product 1 is sold

            var productList = (from or in dbContext.Orders join opm in dbContext.OrderProductMaps on or.OrderId equals opm.order.OrderId where opm.product.ProductId == 3 select new { or.OrderId }).ToList();

            Console.WriteLine(productList);

            
            
            //var productList = (from or in dbContext.Orders join opm in dbContext.OrderProductMaps on or.OrderId equals opm.order.OrderId where opm.pquantity=(from op select new { or.OrderId }).ToList();

            ViewBag.Products = productList;
            var OrderItems = (from op in dbContext.OrderProductMaps where op.productquantity == dbContext.OrderProductMaps.Where(p => p.product.ProductId == 3).Max(x => x.productquantity) select new {op.order.OrderId }).ToList();
            
            ViewBag.Order = OrderItems;
            
            return View();


        }
    }
}