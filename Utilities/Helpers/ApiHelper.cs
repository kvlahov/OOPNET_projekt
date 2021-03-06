﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Utilities.Model;

namespace Utilities.Helpers
{
    public class ApiHelper
    {
        private readonly UriBuilder uriBuilder;

        public string Url
        {
            get
            {
                SetupUri();
                return uriBuilder.ToString();
            }
        }

        private void SetupUri()
        {
            uriBuilder.Path = Path ?? "";
            if(FilterByCode)
            {
                uriBuilder.Path = "matches/country";
                uriBuilder.Query = $"fifa_code={CountryCode}";
            }
        }

        public string BaseUrl { get; set; }
        public string Path { get; set; }
        public string QueryParams { get; set; }
        public bool FilterByCode { get; set; }
        public string CountryCode { get; set; }

        public ApiHelper(string baseUrl)
        {
            BaseUrl = baseUrl;
            uriBuilder = new UriBuilder(baseUrl);
        }

        private async Task<string> GetAsJsonAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                return null;
            }
        }

        public async Task<List<T>> GetDataList<T>(string url = null)
        {
            url = url ?? Url;

            var data = await GetAsJsonAsync(url);
            return JsonConvert.DeserializeObject<List<T>>(data, MatchConverter.Settings);
        }
    }
}