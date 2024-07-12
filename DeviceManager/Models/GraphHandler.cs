using Microsoft.Identity.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager.Models
{
    public class GraphHandler
    {
        public static async Task<string> GetAccessTokenForUser(string clientId, string redirectUri, string[] scopes)
        {
            var cca = PublicClientApplicationBuilder.Create(clientId)
                .WithRedirectUri(redirectUri)
                .Build();

            var result = await cca.AcquireTokenInteractive(scopes)
                .ExecuteAsync();

            return result.AccessToken;
        }
        public static async Task<object> GetMeInformation(string authHeader)
        {
            string graphApiVersion = "beta";
            string resource = "me";
            string uri = $"https://graph.microsoft.com/{graphApiVersion}/{resource}";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authHeader);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(uri);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var responseData = JsonConvert.DeserializeObject<object>(responseBody); // Adjust the type accordingly
                        return responseData;
                    }
                    else
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"Response content:\n{responseBody}");
                        throw new HttpRequestException($"Request to {uri} failed with HTTP Status {response.StatusCode} {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    throw new Exception("GetMeInformation error");
                }
            }
        }
        public static async Task<object> GetManagerInformation(string authHeader)
        {
            string graphApiVersion = "v1.0";
            string resource = "me/manager";
            string uri = $"https://graph.microsoft.com/{graphApiVersion}/{resource}";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authHeader);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(uri);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var responseData = JsonConvert.DeserializeObject<object>(responseBody); // Adjust the type accordingly
                        return responseData;
                    }
                    else
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"Response content:\n{responseBody}");
                        throw new HttpRequestException($"Request to {uri} failed with HTTP Status {response.StatusCode} {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    throw new Exception("GetMeInformation error");
                }
            }
        }
        public static async Task<object> GetDevicesInformation(string authHeader)
        {
            string graphApiVersion = "v1.0";
            string resource = "deviceManagement/managedDevices";
            string uri = $"https://graph.microsoft.com/{graphApiVersion}/{resource}";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authHeader);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(uri);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var responseData = JsonConvert.DeserializeObject<object>(responseBody); // Adjust the type accordingly
                        return responseData;
                    }
                    else
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"Response content:\n{responseBody}");
                        throw new HttpRequestException($"Request to {uri} failed with HTTP Status {response.StatusCode} {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    throw new Exception("GetMeInformation error");
                }
            }
        }
        public static async Task<object> GetSupportInformation(string authHeader)
        {
            string graphApiVersion = "beta";
            string resource = "deviceManagement/intuneBrand";
            string uri = $"https://graph.microsoft.com/{graphApiVersion}/{resource}";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authHeader);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(uri);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var responseData = JsonConvert.DeserializeObject<object>(responseBody); // Adjust the type accordingly
                        return responseData;
                    }
                    else
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"Response content:\n{responseBody}");
                        throw new HttpRequestException($"Request to {uri} failed with HTTP Status {response.StatusCode} {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    throw new Exception("GetMeInformation error");
                }
            }
        }
        public static async Task<byte[]> GetProfileInformation(string authHeader)
        {
            string graphApiVersion = "beta";
            string resource2 = "me/photo/$value";
            string uri = $"https://graph.microsoft.com/{graphApiVersion}/{resource2}";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authHeader);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(uri);

                    if (response.IsSuccessStatusCode)
                    {
                        byte[] imageBytes = await response.Content.ReadAsByteArrayAsync();
                        return imageBytes;
                    }
                    else
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"Response content:\n{responseBody}");
                        throw new HttpRequestException($"Request to {uri} failed with HTTP Status {response.StatusCode} {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    throw new Exception("GetMeInformation error");
                }
            }
        }
        public static async Task<object> GetGroupTagInformation(string authHeader)
        {
            string graphApiVersion = "beta";
            string resource = "deviceManagement/windowsAutopilotDeviceIdentities";
            string uri = $"https://graph.microsoft.com/{graphApiVersion}/{resource}";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authHeader);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(uri);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var responseData = JsonConvert.DeserializeObject<object>(responseBody); // Adjust the type accordingly
                        return responseData;
                    }
                    else
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"Response content:\n{responseBody}");
                        throw new HttpRequestException($"Request to {uri} failed with HTTP Status {response.StatusCode} {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    throw new Exception("GetMeInformation error");
                }
            }
        }
    }
}
