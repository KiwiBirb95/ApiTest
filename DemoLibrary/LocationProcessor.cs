using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class LocationProcessor
    {
        public static async Task<LocationModel> LoadLocation()
        {
            string url = "https://api.wheretheiss.at/v1/satellites/25544";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    LocationModel result = await response.Content.ReadAsAsync<LocationModel>();

                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
