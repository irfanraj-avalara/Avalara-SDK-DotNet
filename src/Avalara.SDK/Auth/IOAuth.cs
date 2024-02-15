using Avalara.SDK.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Avalara.SDK.Auth
{
    /// <summary>
    /// Token model class to deserialize token api response
    /// </summary>
    public class Token
    {
        /// <summary>
        /// (required)  The type of token this is, typically just the string “Bearer” 
        /// </summary>
        public string token_type { get; set; }
        /// <summary>
        /// (optional) If the access token will expire, then it is useful to return a refresh token which applications 
        /// can use to obtain another access token
        /// Not all grant type support this
        /// </summary>
        public string refresh_token { get; set; }
        /// <summary>
        /// (optional) Id Token for the user
        /// </summary>
        public string id_token { get; set; }
        /// <summary>
        /// (recommended)If the access token expires, the server should reply with the duration of time the access token is granted for
        /// </summary>
        public int expires_in { get; set; }
        /// <summary>
        /// (required)  The access token string as issued by the authorization server
        /// </summary>
        public string access_token { get; set; }
        /// <summary>
        /// If the scope the user granted is identical to the scope the app requested, this parameter is optional.
        /// If the granted scope is different from the requested scope, 
        /// such as if the user modified the scope, then this parameter is required.
        /// </summary>
        public string scope { get; set; }
    }

    /// <summary>
    /// Device Authorization model class to deserialize device authorization api response
    /// </summary>
    public class DeviceAuthorization
    {
        /// <summary>
        /// (required) device_code is the unique code for the device. When the user goes to the verification_uri in their browser-based device, this code will be bound to their session. 
        /// </summary>
        public string device_code { get; set; }
        /// <summary>
        /// user_code contains the code that should be input at the verification_uri to authorize the device.
        /// </summary>
        public string user_code { get; set; }
        /// <summary>
        /// expires_in indicates the lifetime (in seconds) of the device_code and user_code.
        /// </summary>
        public int expires_in { get; set; }
        /// <summary>
        /// interval indicates the interval (in seconds) at which the app should poll the token URL to request a token.
        /// </summary>
        public int interval { get; set; }
        /// <summary>
        /// (required) verification_uri contains the URL the user should visit to authorize the device.
        /// </summary>
        public string verification_uri { get; set; }
        /// <summary>
        /// verification_uri_complete contains the complete URL the user should visit to authorize the device. This allows your app to embed the user_code in the URL, if you so choose.
        /// </summary>
        public string verification_uri_complete { get; set; }
    }

    /// <summary>
    /// Interface to necessary properties and method to support different OAuth2 grants
    /// </summary>
    public interface IOAuth
    {
        /// <summary>
        /// Configuration object used for HttpClient
        /// </summary>
        IReadableConfiguration Configuration { get; set; }
        /// <summary>
        /// Authorization Server URL for oAuth2 flow
        /// </summary>
        string AuthorizationURL { get; set; }
        /// <summary>
        /// Token Server URL for oAut2h flow
        /// </summary>
        string TokenURL { get; set; }
        /// <summary>
        /// ClientID for oAuth2 flow
        /// </summary>
        string ClientID { get; set; }
        /// <summary>
        /// ClientSecret for oAuth2 flow
        /// </summary>
        string ClientSecret { get; set; }
        /// <summary>
        /// List of Scopes
        /// </summary>
        string RequiredScopes { get; set; }
        /// <summary>
        /// Other Properties to be used for authentication
        /// </summary>
        Dictionary<string, string> ParameterCollection { get; set; }
        /// <summary>
        /// Method Return the access token
        /// </summary>
        TokenResponse GetAccessToken();
    }
}
