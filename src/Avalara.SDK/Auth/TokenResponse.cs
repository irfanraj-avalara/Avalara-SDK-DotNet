using System;
using System.Collections.Generic;
using System.Text;

namespace Avalara.SDK.Auth
{
    /// <summary>
    /// Represents the response from the /token endpoint for the Device Code OAuth2 Flow.
    /// </summary>
    public class TokenResponse
    {
        /// <summary>
        /// The TokenType for the token returned in the response.
        /// </summary>
        public string TokenType { get; set; }
        /// <summary>
        /// The IdToken for the user.
        /// </summary>
        public string IdToken{ get; set; }
        /// <summary>
        /// The refresh token used in the OAuth2 refresh 
        /// flow to retrieve an updated access token.
        /// </summary>
        public string RefreshToken { get; set; }
        /// <summary>
        /// The access token used to make requests to the Avatax APIs.
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// Http Status code for the response.
        /// </summary>
        public int HttpStatusCode { get; set; }
        /// <summary>
        /// The expiry time for the access token.
        /// </summary>
        public int ExpiryTime { get; set; }
        /// <summary>
        /// The expiry datetime for the access token with the date it was created added to the ExpiryTime
        /// </summary>
        public DateTime ExpiryDateTime { get; set; }
        /// <summary>
        /// The error message returned from the auth service in the
        /// event of an exception or failure scenarios. This can include values such
        /// as "authorization_pending" or "slow_down" for different device code scenarios.
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
