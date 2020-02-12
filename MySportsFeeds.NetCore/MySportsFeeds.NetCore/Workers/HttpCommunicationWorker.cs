using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.Workers
{
    internal class HttpCommunicationWorker
    {
        /// <summary>
        /// The base URL
        /// </summary>
        private Uri baseUrl;

        /// <summary>
        /// The authentication header
        /// </summary>
        private AuthenticationHeaderValue authenticationHeader = null;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpCommunicationWorker"/> class.
        /// </summary>
        /// <param name="baseUrl">The base URL.</param>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        public HttpCommunicationWorker(string baseUrl, string apiKey, string password)
        {
            this.baseUrl = new Uri(baseUrl);
            
            SetBasicAuthentication(apiKey, password);
        }

        /// <summary>
        /// Sets the basic authentication.
        /// </summary>
        /// <param name="base64Auth">The base64 authentication.</param>
        public void SetBasicAuthentication(string apiKey, string password)
        {

            var credentials = $"{apiKey}:{password}";
            byte[] userPassBytes = Encoding.UTF8.GetBytes(credentials);
            string userPassBase64 = Convert.ToBase64String(userPassBytes);
            this.authenticationHeader = new AuthenticationHeaderValue("Basic", userPassBase64);
        }


        /// <summary>
        /// Creates a new instance of System.Net.Http.HttpClient
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// must be disposed by caller
        /// </remarks>
        private HttpClient CreateHttpClient()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = this.baseUrl;

            if (this.authenticationHeader != null)
            {
                httpClient.DefaultRequestHeaders.Authorization = this.authenticationHeader;
            }

            return httpClient;
        }

        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestUrl">The request URL.</param>
        /// <returns></returns>
        public async Task<T> GetAsync<T>(string requestUrl)
        {
            using (HttpClient httpClient = CreateHttpClient())
            using (HttpResponseMessage httpResponse = await httpClient.GetAsync(requestUrl).ConfigureAwait(false))
            {
                string json = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    return JsonConvert.DeserializeObject<T>(json);
                }
                catch (Exception ex)
                {
                    ex.Data["json"] = json;
                    throw;
                }
            }
        }

        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <param name="requestUrl">The request URL.</param>
        /// <returns></returns>
        public async Task<string> GetAsync(string requestUrl)
        {
            using (HttpClient httpClient = CreateHttpClient())
            using (HttpResponseMessage httpResponse = await httpClient.GetAsync(requestUrl).ConfigureAwait(false))
            {
                string json = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);

                return json;
            }
        }
    }
}
