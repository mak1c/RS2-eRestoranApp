using eRestoran.Model;
using eRestoran.Model.Requests;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI
{

    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static int? Rola { get; set; }
        public static int? UserId { get; set; }


        private readonly string _route;
        public APIService(string route)
        {
            _route = route;
        }

        //public async Task<T> Get<T>(object search)
        //{
        //    var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

        //    try
        //    {
        //        if (search != null)
        //        {
        //            url += "?";
        //            url += await search.ToQueryString();
        //        }

        //        return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        //    }
        //    catch (FlurlHttpException ex)
        //    {
        //        if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
        //        {
        //            MessageBox.Show("Niste authentificirani");
        //        }
        //        throw;
        //    }
        //}
        //public Task<int> CountAsync<T>(IQueryable<T> queryable)
        //{
        //    return queryable.CountAsync();
        //}
        public async Task<T> Get<T>(object search)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

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
                    MessageBox.Show("Niste authentificirani");
                }
                throw;
            }
        }

        //public async Task<T> Get<T>(object search)
        //{

        //    var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

        //    if (search != null)
        //    {
        //        url += "?";
        //        url += await search.ToQueryString();
        //    }

        //    var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

        //    return result;



        //}

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

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

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }

        }

        public async Task<T> Update<T>(int id, object request)
        {
            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

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

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }

        }
        public async Task<T> Delete<T>(int id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";
            return await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<T>();

        }

        public Image SetImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default,
                                                  ColorAdjustType.Bitmap);
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                                   0, 0, image.Width, image.Height,
                                   GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }
    }
}
