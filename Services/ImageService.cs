using Android.Widget;
using Appcent.Viewmodel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appcent.Services
{

    public class ImageService
    {
        public TextView textView;
        public ImageView imagen;
        public ImageView imagenejemplo;
        string listUrl = "";
        List<string> listImage;
        private RestClient _restClient;
        private ImageViewmodel _imagevm;

        public async Task<List<string>> GetImage()
        {
            var client = _restClient.GetStoredJsonClient();
            var message = _restClient.GetStoredMessage();

            message.RequestUri = new Uri(Constant.Constant.endPoint);
            message.Method = HttpMethod.Get;
            var responseMessage = await client.SendAsync(message);
            var responseMessageStr = await responseMessage.Content.ReadAsStringAsync();
            var p1 = responseMessageStr.Substring(14);
            var p2 = p1.Substring(0, p1.Length - 1);
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                ImageModel image = JsonConvert.DeserializeObject<ImageModel>(p2);
                listImage = new List<string>();
                foreach (var img in image.photos.photo)
                {
                    listUrl = "https://farm1.staticflickr.com/" + img.server + "/" + img.id + "_" + img.secret + "_z.jpg";
                    listImage.Add(listUrl);
                    imagen.SetImageBitmap(_imagevm.GetImageBitmapFromUrl(listUrl));
                }

                return listImage;
            }
            return null;
        }
    }
}