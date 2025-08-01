﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.TypeSpec.Generator.Primitives;
using Microsoft.TypeSpec.Generator.Providers;
using System.Threading;
using static Microsoft.TypeSpec.Generator.Snippets.Snippet;

namespace Azure.Generator.Primitives
{
    internal class KnownAzureParameters
    {
        public static readonly ParameterProvider Response = new("response", $"The response from the service.", new CSharpType(typeof(Response)));

        public static readonly ParameterProvider WaitUntil = new("waitUntil", $"<see cref=\"WaitUntil.Completed\"/> if the method should wait to return until the long-running operation has completed on the service; <see cref=\"WaitUntil.Started\"/> if it should return after starting the operation. For more information on long-running operations, please see <see href=\"https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md\"> Azure.Core Long-Running Operation samples</see>.", new CSharpType(typeof(WaitUntil)));

        public static readonly ParameterProvider RequestContext = new("context", $"The request context, which can override default behaviors of the client pipeline on a per-call basis.", new CSharpType(typeof(RequestContext)));
        public static readonly ParameterProvider OptionalRequestContext = new("context", $"The request context, which can override default behaviors of the client pipeline on a per-call basis.", new CSharpType(typeof(RequestContext)).WithNullable(true), defaultValue: Null);

        public static readonly ParameterProvider CancellationTokenWithoutDefault = new("cancellationToken", $"The cancellation token to use.", new CSharpType(typeof(CancellationToken)));
        public static readonly ParameterProvider OptionalMatchConditionsParameter = new("matchConditions", $"The content to send as the request conditions of the request.", new CSharpType(typeof(MatchConditions)).WithNullable(true), defaultValue: Default, location: ParameterLocation.Header);
        public static readonly ParameterProvider MatchConditionsParameter = new("matchConditions", $"The content to send as the request conditions of the request.", new CSharpType(typeof(MatchConditions)).WithNullable(true), location: ParameterLocation.Header);
        public static readonly ParameterProvider RequestConditionsParameter = new("requestConditions", $"The content to send as the request conditions of the request.", new CSharpType(typeof(RequestConditions)).WithNullable(true), location: ParameterLocation.Header);
        public static readonly ParameterProvider OptionalRequestConditionsParameter = new("requestConditions", $"The content to send as the request conditions of the request.", new CSharpType(typeof(RequestConditions)).WithNullable(true), defaultValue: Default, location: ParameterLocation.Header);
    }
}
