using LCUSharp.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

public class LeagueRequestHandler : RequestHandler, ILeagueRequestHandler
{
    public int Port { get; set; }
    public string Token { get; set; }

    public LeagueRequestHandler(int port, string token)
    {
        ChangeSettings(port, token);
    }

    public void ChangeSettings(int port, string token)
    {
        Port = port;
        Token = token;
        CreateHttpClient();

        var authTokenBytes = Encoding.ASCII.GetBytes($"riot:{token}");
        HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authTokenBytes));
        HttpClient.BaseAddress = new Uri($"https://127.0.0.1:{port}/");
    }

    public async Task<string> GetJsonResponseAsync(HttpMethod httpMethod, string relativeUrl, IEnumerable<string> queryParameters = null)
    {
        return await GetJsonResponseAsync<object>(httpMethod, relativeUrl, queryParameters, null).ConfigureAwait(false);
    }

    public async Task<string> GetJsonResponseAsync<TRequest>(HttpMethod httpMethod, string relativeUrl, IEnumerable<string> queryParameters, TRequest body)
    {
        var request = await PrepareRequestAsync(httpMethod, relativeUrl, queryParameters, body).ConfigureAwait(false);
        var response = await HttpClient.SendAsync(request).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
        return await GetResponseContentAsync(response).ConfigureAwait(false);
    }

    public async Task<TResponse> GetResponseAsync<TResponse>(HttpMethod httpMethod, string relativeUrl, IEnumerable<string> queryParameters = null)
    {
        return await GetResponseAsync<object, TResponse>(httpMethod, relativeUrl, queryParameters, null).ConfigureAwait(false);
    }

    public async Task<TResponse> GetResponseAsync<TRequest, TResponse>(HttpMethod httpMethod, string relativeUrl, IEnumerable<string> queryParameters, TRequest body)
    {
        var json = await GetJsonResponseAsync(httpMethod, relativeUrl, queryParameters, body).ConfigureAwait(false);
        return await Task.Run(() => JsonConvert.DeserializeObject<TResponse>(json)).ConfigureAwait(false);
    }

    public async Task<HttpResponseMessage> SendJsonRequestAsync(HttpMethod httpMethod, string relativeUrl, IEnumerable<string> queryParameters, object body)
    {
        var request = await PrepareRequestAsync(httpMethod, relativeUrl, queryParameters, body).ConfigureAwait(false);
        return await HttpClient.SendAsync(request).ConfigureAwait(false);
    }
}
