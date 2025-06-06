// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Routes._QueryParameters.QueryContinuation;
using Routes._QueryParameters.QueryExpansion;

namespace Routes._QueryParameters
{
    public partial class QueryParameters
    {
        protected QueryParameters() => throw null;

        public virtual HttpPipeline Pipeline => throw null;

        public virtual Response TemplateOnly(string @param, RequestContext context) => throw null;

        public virtual Task<Response> TemplateOnlyAsync(string @param, RequestContext context) => throw null;

        public virtual Response TemplateOnly(string @param, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response> TemplateOnlyAsync(string @param, CancellationToken cancellationToken = default) => throw null;

        public virtual Response Explicit(string @param, RequestContext context) => throw null;

        public virtual Task<Response> ExplicitAsync(string @param, RequestContext context) => throw null;

        public virtual Response Explicit(string @param, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response> ExplicitAsync(string @param, CancellationToken cancellationToken = default) => throw null;

        public virtual Response AnnotationOnly(string @param, RequestContext context) => throw null;

        public virtual Task<Response> AnnotationOnlyAsync(string @param, RequestContext context) => throw null;

        public virtual Response AnnotationOnly(string @param, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response> AnnotationOnlyAsync(string @param, CancellationToken cancellationToken = default) => throw null;

        public virtual QueryParametersQueryExpansion GetQueryParametersQueryExpansionClient() => throw null;

        public virtual QueryParametersQueryContinuation GetQueryParametersQueryContinuationClient() => throw null;
    }
}
