using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using FitnessTracker.Server.Model;

namespace FitnessTracker.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new TrackerContext())
            {
                var user = new User
                {
                    UserName = "Jano23",
                    FirstName = "tomas",
                    LastName = "Maly",
                    DateCreated = DateTime.Now,
                };
                context.Users.Add(user);
                context.SaveChanges();
            }

            ServiceHost selfHost = new ServiceHost(typeof(TrackerService));
            try
            {
                selfHost.Open();
                Console.WriteLine("The service is ready. Press <ENTER> to terminate service.");
                Console.ReadLine();
                selfHost.Close();

            }
            catch (CommunicationException ce)
            {
                Console.WriteLine($"An exception occured {ce.Message}");
                selfHost.Abort();
            }
        }
    }
}
