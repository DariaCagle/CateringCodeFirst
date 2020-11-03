using Catering.Controllers;
using Catering.Models.PostModels;
using System;

namespace CateringVisualizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var chefTypeController = new ChefTypesController();
            var chef = new ChefTypePostModel
            {
                Name = "Pastry Chef"
            };
            chefTypeController.CreateChef(chef);
            Console.WriteLine(chefTypeController.GetById(1).Name);

            var userController = new UsersController();
            var user = new UserPostModel()
            {
                FullName = "Freddy Krueger",
                Phone = "+66666661313"
            };
            userController.CreateUser(user);
            foreach (var person in userController.GetAll())
            {
                Console.Write(person.FullName + " ");
                Console.WriteLine(person.Phone);
            }
            Console.WriteLine();

            var waitersController = new WaitersController();
            var waiter = new WaiterPostModel()
            {
                FullName = "Andrew Miller",
                Address = "15 Wilson Street"
            };
            var model = waitersController.CreateWaiter(waiter);
            Console.WriteLine(model.FullName);



            var orderController = new CateringOrdersController();
            var order = new CateringOrderPostModel()
            {
                UserId = 1,
                ChefTypeId = 1,
                Date = new DateTime(2021, 06, 13),
                NumberOfPeople = 36,
                Outdoors = false,
                Address = "13 Elm Street",
                WaiterId = 1
            };
            var newOrder = orderController.CreateCateringOrder(order);
            Console.WriteLine(newOrder.Id);
            foreach (var or in orderController.GetAll())
            {
                Console.Write(or.User.FullName + " ");
                Console.WriteLine(or.ChefType.Name);
            }
            Console.WriteLine();


        }
    }
}
