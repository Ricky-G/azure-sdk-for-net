// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace SpecialWords._Models
{
    public partial class Constructor : IJsonModel<Constructor>
    {
        internal Constructor() => throw null;

        void IJsonModel<Constructor>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        Constructor IJsonModel<Constructor>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual Constructor JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<Constructor>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        Constructor IPersistableModel<Constructor>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual Constructor PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<Constructor>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="constructor"> The <see cref="Constructor"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(Constructor constructor) => throw null;
    }
}
