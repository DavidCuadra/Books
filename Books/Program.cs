using Books.Models;
using BookingClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //Client c1 = new Client() { ClientID = 1, ClientName = "David", Email = "david@yahoo.com", GardaVetting = true, Insurance = true, NoiseLevel = Client.Noise.Normal, NumberPeople = "10", Phone = "0863535422" };
            //Client c2 = new Client() { ClientID = 2, ClientName = "Aliona", Email = "aliona@yahoo.com", GardaVetting = false, Insurance = false, NoiseLevel = Client.Noise.Noisy, NumberPeople = "15", Phone = "3455634223" };

            //ClientContext cContext = new ClientContext();
            //cContext.Clients.Add(c1);
            //cContext.Clients.Add(c2);
            //cContext.SaveChanges();

            APIClient.GetAsync().Wait();

            Console.ReadLine();

        }



    }
    
}
