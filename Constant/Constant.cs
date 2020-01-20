namespace Appcent.Constant
{
    public class Constant
    {
        private static string page_number = "1";
        private static string apiKey = "55ad0d51aae5c5683bd001f7cb8b5bbd";
        private static string per_page = "20";
        public static string endPoint = "https://www.flickr.com/services/rest/?method=flickr.photos.getRecent&api_key=" + apiKey + "&extras=&per_page=" + per_page + "&page" + page_number + "&format=json&nojsoncallback=";

    }
}