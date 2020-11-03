using Catering.Controllers;
using Catering.Models.PostModels;
using System;

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

            var orderController = new CateringOrderController();
            //var order = new CateringOrderPostModel()
            //{
            //    UserId = 3,
            //    ChefTypeId = 3,
            //    Date = new DateTime(2021, 06, 13),
            //    NumberOfPeople = 36,
            //    Outdoors = false,
            //    Address = "13 Elm Street"
            //};

            //var newOrder = orderController.CreateCateringOrder(order);
            //Console.WriteLine(newOrder.Id);
            //Console.WriteLine(newOrder.ChefType.Name);
            foreach (var or in orderController.GetAll())
            {
                Console.Write(or.User.FullName + " ");
                Console.WriteLine(or.ChefType.Name);
            }
            Console.WriteLine();
        }
    }
}
