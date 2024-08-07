// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Deidentification
{
    /// <summary> String index encoding model. </summary>
    public partial class StringIndex
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StringIndex"/>. </summary>
        /// <param name="utf8"> The offset or length of the substring in UTF-8 encoding. </param>
        /// <param name="utf16">
        /// The offset or length of the substring in UTF-16 encoding.
        ///
        /// Primary encoding used by .NET, Java, and JavaScript.
        /// </param>
        /// <param name="codePoint">
        /// The offset or length of the substring in CodePoint encoding.
        ///
        /// Primary encoding used by Python.
        /// </param>
        internal StringIndex(int utf8, int utf16, int codePoint)
        {
            Utf8 = utf8;
            Utf16 = utf16;
            CodePoint = codePoint;
        }

        /// <summary> Initializes a new instance of <see cref="StringIndex"/>. </summary>
        /// <param name="utf8"> The offset or length of the substring in UTF-8 encoding. </param>
        /// <param name="utf16">
        /// The offset or length of the substring in UTF-16 encoding.
        ///
        /// Primary encoding used by .NET, Java, and JavaScript.
        /// </param>
        /// <param name="codePoint">
        /// The offset or length of the substring in CodePoint encoding.
        ///
        /// Primary encoding used by Python.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StringIndex(int utf8, int utf16, int codePoint, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Utf8 = utf8;
            Utf16 = utf16;
            CodePoint = codePoint;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StringIndex"/> for deserialization. </summary>
        internal StringIndex()
        {
        }

        /// <summary> The offset or length of the substring in UTF-8 encoding. </summary>
        public int Utf8 { get; }
        /// <summary>
        /// The offset or length of the substring in UTF-16 encoding.
        ///
        /// Primary encoding used by .NET, Java, and JavaScript.
        /// </summary>
        public int Utf16 { get; }
        /// <summary>
        /// The offset or length of the substring in CodePoint encoding.
        ///
        /// Primary encoding used by Python.
        /// </summary>
        public int CodePoint { get; }
    }
}
