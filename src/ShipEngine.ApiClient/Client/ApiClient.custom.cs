using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;
using System.Web;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using RestSharp;

namespace ShipEngine.ApiClient.Client
{
    /// <summary>
    /// Customized code to augment the auto-generated Swagger-Codegen code
    /// </summary>
    public partial class ApiClient
    {
        static ApiClient()
        {
            EnsureSecurityProtocol();
        }

        /// <summary>
        /// Ensures that TLS 1.2 or greater is enabled, which is required by ShipEngine
        /// </summary>
        private static void EnsureSecurityProtocol()
        {
            // Determine whether TLS 1.2 is explicitly enabled
            var tls12Enabled = ServicePointManager.SecurityProtocol.HasFlag(SecurityProtocolType.Tls12);

            // Determine whether the .Net Framework is deferring to the operating system's TLS implementation
            var osDefaultEnabled = ServicePointManager.SecurityProtocol == 0;

            // If neither of the above are enabled, then explicitly enable TLS 1.2
            if (!tls12Enabled && !osDefaultEnabled)
            {
                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
            }
        }
    }
}
