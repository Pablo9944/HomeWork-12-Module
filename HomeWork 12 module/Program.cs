using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HomeWork_12_module
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<User> listUsers = new List<User>();
            listUsers.Add(new User() { Name = "Иван",Login=Guid.NewGuid().ToString().Substring(1,7),IsPremium=true});
            listUsers.Add(new User() { Name = "Владимир", Login = Guid.NewGuid().ToString().Substring(1, 7), IsPremium = false });

            foreach (var item in listUsers)
            {
                if (!item.IsPremium)
                {
                    Console.Write(item.Name +" ");
                    ShowAds();
                }
               
            }


        }
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }
}
