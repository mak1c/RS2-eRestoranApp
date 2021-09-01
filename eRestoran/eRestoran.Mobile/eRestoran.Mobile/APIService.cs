using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using eRestoran.Model;
namespace eRestoran.Mobile
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static int Rola { get; set; }
        
        public static int Id { get; set; }

        private readonly string _route;

#if DEBUG
        //private string _apiUrl = "http://localhost:44392";
        private string _apiUrl = "http://localhost:61475/api";

#endif
#if RELEASE
        private string _apiUrl = "https://mywebsite.azure.com/api/";
#endif

        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{_apiUrl}/{_route}";

            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }

                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    //MessageBox.Show("Niste authentificirani");
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                }
                throw;
            }
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }


        public async Task<T> GetSimilarArticles<T>(int id)
        {
            var url = $"{_apiUrl}/{_route}/GetSimilarArticles/{id}";

            return await url.GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            //var url = $"{_apiUrl}/{_route}";

            //try
            //{
            //    return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            //}
            //catch (FlurlHttpException ex)
            //{
            //    var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

            //    var stringBuilder = new StringBuilder();
            //    foreach (var error in errors)
            //    {
            //        stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
            //    }

            //    await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
            //    return default(T);
            //}
            var url = $"{_apiUrl}/{_route}";
            var data = await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            return data;

        }

        public async Task<T> Update<T>(int id, object request)
        {

            var url = $"{_apiUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            //try
            //{
            //    var url = $"{_apiUrl}/{_route}/{id}";

            //    return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            //}
            //catch (FlurlHttpException ex)
            //{
            //    var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

            //    var stringBuilder = new StringBuilder();
            //    foreach (var error in errors)
            //    {
            //        stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
            //    }

            //    await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
            //    return default(T);
            //}

        }
    }
}

