using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Appcent.Services
{
    public class RestClient
    {
        public HttpClient GetStoredJsonClient()
        {
            var client = GetStoredClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            return client;
        }
        public HttpClient GetStoredClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            return client;
        }
        public HttpRequestMessage GetStoredMessage()
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Headers.Clear();
            return message;
        }
    }
}