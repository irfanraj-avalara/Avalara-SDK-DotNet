using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Avalara.SDK.Client
{
    /// <summary>
    /// Interface for the API Client
    /// </summary>
    public interface IApiClient : IDisposable
    {
    /// <summary>
    /// The Configuration for the API Client
    /// </summary>
    IReadableConfiguration Configuration { get;  }

    /// <summary>
    /// The Serializer settings for the API Client
    /// </summary>
    JsonSerializerSettings SerializerSettings {get; set;}

    /// <summary>
    /// Get Method to make an API call Async
    /// </summary>
    Task<ApiResponse<T>> GetAsync<T>(string path, RequestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), string requiredScopes = default(string));

    /// <summary>
    /// Post Method to make an API call Async
    /// </summary>
    Task<ApiResponse<T>> PostAsync<T>(string path, RequestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), string requiredScopes = default(string));

    /// <summary>
    /// Put Method to make an API call Async
    /// </summary>
    Task<ApiResponse<T>> PutAsync<T>(string path, RequestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), string requiredScopes = default(string));

    /// <summary>
    /// Delete Method to make an API call Async
    /// </summary>
    Task<ApiResponse<T>> DeleteAsync<T>(string path, RequestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), string requiredScopes = default(string));

    /// <summary>
    /// Head Method to make an API call Async
    /// </summary>
    Task<ApiResponse<T>> HeadAsync<T>(string path, RequestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), string requiredScopes = default(string));

    /// <summary>
    /// Options Method to make an API call Async
    /// </summary>
    Task<ApiResponse<T>> OptionsAsync<T>(string path, RequestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), string requiredScopes = default(string));

    /// <summary>
    /// Patch Method to make an API call Async
    /// </summary>
    Task<ApiResponse<T>> PatchAsync<T>(string path, RequestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), string requiredScopes = default(string));

    /// <summary>
    /// Get Method to make an API call 
    /// </summary>
    ApiResponse<T> Get<T>(string path, RequestOptions options, string requiredScopes = default(string));

    /// <summary>
    /// Post Method to make an API call
    /// </summary>
    ApiResponse<T> Post<T>(string path, RequestOptions options, string requiredScopes = default(string));

    /// <summary>
    /// Put Method to make an API call
    /// </summary>
    ApiResponse<T> Put<T>(string path, RequestOptions options, string requiredScopes = default(string));

    /// <summary>
    /// Delete Method to make an API call
    /// </summary>
    ApiResponse<T> Delete<T>(string path, RequestOptions options, string requiredScopes = default(string));

    /// <summary>
    /// Head Method to make an API call
    /// </summary>
    ApiResponse<T> Head<T>(string path, RequestOptions options, string requiredScopes = default(string));

    /// <summary>
    /// Options Method to make an API call
    /// </summary>
    ApiResponse<T> Options<T>(string path, RequestOptions options, string requiredScopes = default(string));

    /// <summary>
    /// Patch Method to make an API call
    /// </summary>
    ApiResponse<T> Patch<T>(string path, RequestOptions options, string requiredScopes = default(string));
}

    internal interface IInternalApiClient : IApiClient
    {
        string SdkVersion { get;  set; }
    }
}