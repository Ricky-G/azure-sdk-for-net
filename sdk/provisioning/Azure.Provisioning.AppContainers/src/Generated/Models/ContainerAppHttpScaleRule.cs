// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Container App container Http scaling rule.
/// </summary>
public partial class ContainerAppHttpScaleRule : ProvisionableConstruct
{
    /// <summary>
    /// Metadata properties to describe http scale rule.
    /// </summary>
    public BicepDictionary<string> Metadata 
    {
        get { Initialize(); return _metadata!; }
        set { Initialize(); _metadata!.Assign(value); }
    }
    private BicepDictionary<string>? _metadata;

    /// <summary>
    /// Authentication secrets for the custom scale rule.
    /// </summary>
    public BicepList<ContainerAppScaleRuleAuth> Auth 
    {
        get { Initialize(); return _auth!; }
        set { Initialize(); _auth!.Assign(value); }
    }
    private BicepList<ContainerAppScaleRuleAuth>? _auth;

    /// <summary>
    /// The resource ID of a user-assigned managed identity that is assigned to
    /// the Container App, or &apos;system&apos; for system-assigned identity.
    /// </summary>
    public BicepValue<string> Identity 
    {
        get { Initialize(); return _identity!; }
        set { Initialize(); _identity!.Assign(value); }
    }
    private BicepValue<string>? _identity;

    /// <summary>
    /// Creates a new ContainerAppHttpScaleRule.
    /// </summary>
    public ContainerAppHttpScaleRule()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ContainerAppHttpScaleRule.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _metadata = DefineDictionaryProperty<string>("Metadata", ["metadata"]);
        _auth = DefineListProperty<ContainerAppScaleRuleAuth>("Auth", ["auth"]);
        _identity = DefineProperty<string>("Identity", ["identity"]);
    }
}
