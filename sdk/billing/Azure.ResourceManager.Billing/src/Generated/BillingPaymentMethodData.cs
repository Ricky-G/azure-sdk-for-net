// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Billing.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A class representing the BillingPaymentMethod data model.
    /// A payment method.
    /// </summary>
    public partial class BillingPaymentMethodData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="BillingPaymentMethodData"/>. </summary>
        public BillingPaymentMethodData()
        {
            Logos = new ChangeTrackingList<PaymentMethodLogo>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="BillingPaymentMethodData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="paymentMethodId"> Id of payment method. </param>
        /// <param name="accountHolderName"> The account holder name for the payment method. This is only supported for payment methods with family CreditCard. </param>
        /// <param name="displayName"> The display name of the payment method. </param>
        /// <param name="expiration"> The expiration month and year of the payment method. This is only supported for payment methods with family CreditCard. </param>
        /// <param name="family"> The family of payment method. </param>
        /// <param name="lastFourDigits"> Last four digits of payment method. </param>
        /// <param name="logos"> The list of logos for the payment method. </param>
        /// <param name="paymentMethodType"> The type of payment method. </param>
        /// <param name="status"> Status of the payment method. </param>
        /// <param name="tags"> Dictionary of metadata associated with the resource. It may not be populated for all resource types. Maximum key/value length supported of 256 characters. Keys/value should not empty value nor null. Keys can not contain &lt; &gt; % &amp; \ ? /. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BillingPaymentMethodData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier paymentMethodId, string accountHolderName, string displayName, string expiration, PaymentMethodFamily? family, string lastFourDigits, IList<PaymentMethodLogo> logos, string paymentMethodType, PaymentMethodStatus? status, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            PaymentMethodId = paymentMethodId;
            AccountHolderName = accountHolderName;
            DisplayName = displayName;
            Expiration = expiration;
            Family = family;
            LastFourDigits = lastFourDigits;
            Logos = logos;
            PaymentMethodType = paymentMethodType;
            Status = status;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Id of payment method. </summary>
        [WirePath("properties.id")]
        public ResourceIdentifier PaymentMethodId { get; }
        /// <summary> The account holder name for the payment method. This is only supported for payment methods with family CreditCard. </summary>
        [WirePath("properties.accountHolderName")]
        public string AccountHolderName { get; }
        /// <summary> The display name of the payment method. </summary>
        [WirePath("properties.displayName")]
        public string DisplayName { get; }
        /// <summary> The expiration month and year of the payment method. This is only supported for payment methods with family CreditCard. </summary>
        [WirePath("properties.expiration")]
        public string Expiration { get; }
        /// <summary> The family of payment method. </summary>
        [WirePath("properties.family")]
        public PaymentMethodFamily? Family { get; set; }
        /// <summary> Last four digits of payment method. </summary>
        [WirePath("properties.lastFourDigits")]
        public string LastFourDigits { get; }
        /// <summary> The list of logos for the payment method. </summary>
        [WirePath("properties.logos")]
        public IList<PaymentMethodLogo> Logos { get; }
        /// <summary> The type of payment method. </summary>
        [WirePath("properties.paymentMethodType")]
        public string PaymentMethodType { get; }
        /// <summary> Status of the payment method. </summary>
        [WirePath("properties.status")]
        public PaymentMethodStatus? Status { get; set; }
        /// <summary> Dictionary of metadata associated with the resource. It may not be populated for all resource types. Maximum key/value length supported of 256 characters. Keys/value should not empty value nor null. Keys can not contain &lt; &gt; % &amp; \ ? /. </summary>
        [WirePath("tags")]
        public IDictionary<string, string> Tags { get; }
    }
}
