// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// The configuration settings of the app registration for providers that have
/// app ids and app secrets.
/// </summary>
public partial class ContainerAppRegistration : ProvisionableConstruct
{
    /// <summary>
    /// The App ID of the app used for login.
    /// </summary>
    public BicepValue<string> AppId { get => _appId; set => _appId.Assign(value); }
    private readonly BicepValue<string> _appId;

    /// <summary>
    /// The app setting name that contains the app secret.
    /// </summary>
    public BicepValue<string> AppSecretSettingName { get => _appSecretSettingName; set => _appSecretSettingName.Assign(value); }
    private readonly BicepValue<string> _appSecretSettingName;

    /// <summary>
    /// Creates a new ContainerAppRegistration.
    /// </summary>
    public ContainerAppRegistration()
    {
        _appId = BicepValue<string>.DefineProperty(this, "AppId", ["appId"]);
        _appSecretSettingName = BicepValue<string>.DefineProperty(this, "AppSecretSettingName", ["appSecretSettingName"]);
    }
}
