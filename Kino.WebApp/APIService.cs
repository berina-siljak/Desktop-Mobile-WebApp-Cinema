using Flurl.Http;
using Kino.Model;
using Kino.WebApp.Controllers;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kino.WebApp
{
    public class APIService
    {
        public static string Username { get; set; }
        public static int KorisnikID { get; set; }
        public static string Password { get; set; }
        private readonly string _route;
        public APIService(string route)
        {
            _route = route;
            //Username = "admin";
        }

#if DEBUG
        string _apiUrl = "http://localhost:44393/api/";
#endif
#if RELEASE
        string _apiUrl= "https://mywebsite.com/api/";
#endif


        public async Task<T> Get<T>(object search)
        {
            var url = $"{_apiUrl}/{_route}"; //promjena

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
                    //homeController.Unauthorized();
                    //MessageBox.Show("Niste authentificirani");
                    //await Application.Current.MainPage.DisplayAlert("Greška", "Pogrešan username ili password!", "OK");
                }
                throw;
            }
        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";
            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";

            try
            {
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }
                    //homeController.Unauthorized();
                //await Application.Current.MainPage.DisplayAlert("Greska", stringBuilder.ToString(), "OK");
                return default(T);
            }

        }

        public async Task<T> Update<T>(int id, object request)
        {
            try
            {
                var url = $"{_apiUrl}/{_route}/{id}";

                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                    //homeController.Unauthorized();
                //await Application.Current.MainPage.DisplayAlert("Greska", stringBuilder.ToString(), "OK");
                return default(T);
            }
        }
        public async Task<T> Delete<T>(int id)
        {
            try
            {
                var url = $"{_apiUrl}/{_route}/{id}";

                return await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                //homeController.Unauthorized();
                //await Application.Current.MainPage.DisplayAlert("Greska", stringBuilder.ToString(), "OK");
                return default(T);
            }
        }
    }
}
