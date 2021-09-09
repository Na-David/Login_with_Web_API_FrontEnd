using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace LOGIN
{
    public class DatabaseManager
    {
        public static void FetchLogin(string Username)
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetStringAsync("http://10.0.2.2:3492/api/Students/{0}",);
            //var Student_Obj = JsonConvert.DeserializeObject<>(response.Result);
            //return Student_Obj.ToList();

        }
    }
}