using System;
namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User() { Name = "Vusal", Surname = "Musayev", Username = "vusaloo", Password = "vusal2002" };
            User user2 = new Student(){Name = "Anar", Surname = "Guliyev", Username = "anarguli", Password = "guliyev22",Grade=50};
            //User user3 = new Student("Ulvi","Mammadov","mammadov233","mulvi5535",60);

            User[] users = { user1, user2 };
            Console.WriteLine("Please enter the username:");
            string getName = Console.ReadLine();
            Console.WriteLine("Please enter the password:");
            string getPass = Console.ReadLine();
            
            foreach (var item in users)
            {
                if(item.Username==getName && item.Password==getPass)
                {
                    item.GetData();
                    
                }
            }
        }
    }
}
