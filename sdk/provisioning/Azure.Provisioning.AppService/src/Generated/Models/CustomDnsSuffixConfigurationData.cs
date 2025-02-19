// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// A class representing the CustomDnsSuffixConfiguration data model.
/// Full view of the custom domain suffix configuration for ASEv3.
/// </summary>
public partial class CustomDnsSuffixConfigurationData : ProvisionableConstruct
{
    /// <summary>
    /// Gets the provisioning state.
    /// </summary>
    public BicepValue<CustomDnsSuffixProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<CustomDnsSuffixProvisioningState>? _provisioningState;

    /// <summary>
    /// Gets the provisioning details.
    /// </summary>
    public BicepValue<string> ProvisioningDetails 
    {
        get { Initialize(); return _provisioningDetails!; }
    }
    private BicepValue<string>? _provisioningDetails;

    /// <summary>
    /// The default custom domain suffix to use for all sites deployed on the
    /// ASE.
    /// </summary>
    public BicepValue<string> DnsSuffix 
    {
        get { Initialize(); return _dnsSuffix!; }
        set { Initialize(); _dnsSuffix!.Assign(value); }
    }
    private BicepValue<string>? _dnsSuffix;

    /// <summary>
    /// The URL referencing the Azure Key Vault certificate secret that should
    /// be used as the default SSL/TLS certificate for sites with the custom
    /// domain suffix.
    /// </summary>
    public BicepValue<Uri> CertificateUri 
    {
        get { Initialize(); return _certificateUri!; }
        set { Initialize(); _certificateUri!.Assign(value); }
    }
    private BicepValue<Uri>? _certificateUri;

    /// <summary>
    /// The user-assigned identity to use for resolving the key vault
    /// certificate reference. If not specified, the system-assigned ASE
    /// identity will be used if available.
    /// </summary>
    public BicepValue<string> KeyVaultReferenceIdentity 
    {
        get { Initialize(); return _keyVaultReferenceIdentity!; }
        set { Initialize(); _keyVaultReferenceIdentity!.Assign(value); }
    }
    private BicepValue<string>? _keyVaultReferenceIdentity;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind 
    {
        get { Initialize(); return _kind!; }
        set { Initialize(); _kind!.Assign(value); }
    }
    private BicepValue<string>? _kind;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new CustomDnsSuffixConfigurationData.
    /// </summary>
    public CustomDnsSuffixConfigurationData()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// CustomDnsSuffixConfigurationData.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _provisioningState = DefineProperty<CustomDnsSuffixProvisioningState>("ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _provisioningDetails = DefineProperty<string>("ProvisioningDetails", ["properties", "provisioningDetails"], isOutput: true);
        _dnsSuffix = DefineProperty<string>("DnsSuffix", ["properties", "dnsSuffix"]);
        _certificateUri = DefineProperty<Uri>("CertificateUri", ["properties", "certificateUrl"]);
        _keyVaultReferenceIdentity = DefineProperty<string>("KeyVaultReferenceIdentity", ["properties", "keyVaultReferenceIdentity"]);
        _kind = DefineProperty<string>("Kind", ["kind"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }
}
