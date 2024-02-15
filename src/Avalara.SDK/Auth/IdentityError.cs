using System;
using System.Collections.Generic;
using System.Text;

namespace Avalara.SDK.Auth
{
    /// <summary>
    /// Represents the response from the Avalara Identity Service for an error scenario.
    /// </summary>
    public class IdentityError
    {
        /// <summary>
        /// The error message from the response.
        /// </summary>
        public string Error { get; set; }
    }
}
