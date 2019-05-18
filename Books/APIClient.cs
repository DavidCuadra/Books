using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Books.Models;

namespace BookingClient
{
    class APIClient
    {
        public static async Task GetAsync() 
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:7330/");

                    // add an Accept header for JSON
                    client.DefaultRequestHeaders.
                        Accept.Add(new MediaTypeWithQualityHeaderValue("application/jason"));

                    //Get/property/all
                    HttpResponseMessage response = await client.GetAsync("api/BookingsAPI");
                    if (response.IsSuccessStatusCode)
                    {
                        //read results                        
                        var booking = await response.Content.ReadAsAsync<IEnumerable<Booking>>();
                        foreach (var book in booking)
                        {
                            Console.WriteLine(book);
                        }
                    }
                    else
                    {
                        Console.WriteLine(response.StatusCode + " " + response.ReasonPhrase);
                    }


                    //Property newCar = new Property()
                    //{
                    //    ID = 005,
                    //    Address = "55 Whaterver road",
                    //    NoBeds = 7,
                    //    Lease = Certificate.Delegated,
                    //    Email = "Isthisreal@unreal.org",
                    //    Expiry = new DateTime(2040, 8, 10),
                    //};


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}
