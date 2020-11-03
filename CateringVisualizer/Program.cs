using Catering.Controllers;
using Catering.Models.PostModels;
using Catering.Models.ViewModels;
using System;
using System.Collections.Generic;

namespace CateringVisualizer
{
    class Program
    {
        static void Main(string[] args)
        {
            //var chefTypeController = new ChefTypeController();
            //var chef = new ChefTypePostModel
            //{
            //    Name = "Pastry Chef"
            //};
            //chefTypeController.CreateChef(chef);
            //Console.WriteLine(chefTypeController.GetById(3).Name);

            //var userController = new UserController();
            //var user = new UserPostModel()
            //{
            //    FullName = "Freddy Krueger",
            //    Phone = "+66666661313"
            //};
            //userController.CreateUser(user);
            //foreach (var person in userController.GetAll())
            //{
            //    Console.Write(person.FullName + " ");
            //    Console.WriteLine(person.Phone);
            //}
            //Console.WriteLine();

            var waitersController = new WaitersController();
            //var waiter = new WaiterPostModel()
            //{
            //    FullName = "Andrew Miller",
            //    Address = "15 Wilson Street"
            //};
            //var model = waitersController.CreateWaiter(waiter);
            //Console.WriteLine(model.FullName);



            var orderController = new CateringOrdersController();
            var order = new CateringOrderPostModel()
            {
                UserId = 3,
                ChefTypeId = 3,
                Date = new DateTime(2021, 06, 13),
                NumberOfPeople = 36,
                Outdoors = false,
                Address = "13 Elm Street",
                WaiterId = 1
            };
            orderController.CreateCateringOrder(order);


            //var newOrder = orderController.CreateCateringOrder(order);
            //Console.WriteLine(newOrder.Id);
            //Console.WriteLine(newOrder.ChefType.Name);
            //foreach (var or in orderController.GetAll())
            //{
            //    Console.Write(or.User.FullName + " ");
            //    Console.WriteLine(or.ChefType.Name);
            //}
            //Console.WriteLine();


        }
    }
}
