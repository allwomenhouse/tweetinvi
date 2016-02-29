﻿using Tweetinvi.Core.Interfaces.Credentials;

namespace Tweetinvi.Core.Interfaces.RateLimit
{
    /// <summary>
    /// Helper class used to read the flags information from the rate limits
    /// and return the rate limits associated with a query.
    /// </summary>
    public interface IRateLimitHelper
    {
        /// <summary>
        /// Detect if the query can be identified as being a rate limited query.
        /// </summary>
        bool IsQueryAssociatedWithTokenRateLimit(string query, ITokenRateLimits rateLimits);

        /// <summary>
        /// Return the specified query rate limits if the query can be identified in the TokenRateLimits.
        /// </summary>
        ITokenRateLimit GetTokenRateLimitFromQuery(string query, ITokenRateLimits rateLimits);
    }
}