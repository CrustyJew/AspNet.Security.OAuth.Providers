﻿/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace AspNet.Security.OAuth.Reddit {
    /// <summary>
    /// Defines a set of options used by <see cref="RedditAuthenticationHandler"/>.
    /// </summary>
    public class RedditAuthenticationOptions : OAuthOptions {
        public RedditAuthenticationOptions() {
            AuthenticationScheme = RedditAuthenticationDefaults.AuthenticationScheme;
            DisplayName = RedditAuthenticationDefaults.DisplayName;
            ClaimsIssuer = RedditAuthenticationDefaults.Issuer;

            CallbackPath = new PathString(RedditAuthenticationDefaults.CallbackPath);

            AuthorizationEndpoint = RedditAuthenticationDefaults.AuthorizationEndpoint;
            TokenEndpoint = RedditAuthenticationDefaults.TokenEndpoint;
            UserInformationEndpoint = RedditAuthenticationDefaults.UserInformationEndpoint;

            Scope.Add("identity");
        }
        /// <summary>
        /// UserAgent string to pass during requests to Reddit.
        /// STRONGLY recommend to set this according to policy to avoid request throttling
        /// </summary>
        public string UserAgent { get; set; }
    }
}