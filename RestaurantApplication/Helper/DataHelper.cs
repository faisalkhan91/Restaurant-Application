using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RestaurantApplication.Helper
{
    public class DataHelper
    {
        public HttpClient InitializeBase()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53225");
            return client;
        }
    }
}
