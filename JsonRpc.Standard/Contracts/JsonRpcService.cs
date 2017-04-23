﻿namespace JsonRpc.Standard.Contracts
{
    /// <summary>
    /// Base class for providing JSON RPC service.
    /// </summary>
    public class JsonRpcService
    {
        /// <summary>
        /// Gets or sets the <see cref="RequestContext"/> of current request.
        /// </summary>
        public RequestContext RequestContext { get; set; }
    }
}
