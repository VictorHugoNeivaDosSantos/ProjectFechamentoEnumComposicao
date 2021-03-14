using System;
using System.Globalization;
using ProjectUdemyFechamentoEnumCompos.Entities;
using ProjectUdemyFechamentoEnumCompos.Entities.Enums;

namespace ProjectUdemyFechamentoEnumCompos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth date: ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            Client cliente = new Client(name, email, birthdate);
            Console.WriteLine("Enter or date: ");
            Console.Write("Status: ");
            OrderStatus orderst = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many itens to this older? ");
            int qtdOlder = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, orderst, cliente);

            for (int i = 1; i <= qtdOlder; i++)
            {
                Console.WriteLine("Enter #" + i + " item data: ");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product Price: ");
                double priceProduct = double.Parse(Console.ReadLine());
                Console.Write("Unidade: ");
                int qtdUnit = int.Parse(Console.ReadLine());
                Product product = new Product(nameProduct, priceProduct);
                OrderItem orderItem = new OrderItem(qtdUnit, priceProduct, product);
                order.AddItem(orderItem);



            }


            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);



        }
    }
}
