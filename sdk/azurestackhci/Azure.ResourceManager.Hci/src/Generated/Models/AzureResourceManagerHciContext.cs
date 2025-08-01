// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// Context class which will be filled in by the System.ClientModel.SourceGeneration.
    /// For more information see 'https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/System.ClientModel/src/docs/ModelReaderWriterContext.md'
    /// </summary>
    [ModelReaderWriterBuildable(typeof(ArcDefaultExtensionDetails))]
    [ModelReaderWriterBuildable(typeof(ArcExtensionData))]
    [ModelReaderWriterBuildable(typeof(ArcExtensionInstanceView))]
    [ModelReaderWriterBuildable(typeof(ArcExtensionInstanceViewStatus))]
    [ModelReaderWriterBuildable(typeof(ArcExtensionListResult))]
    [ModelReaderWriterBuildable(typeof(ArcExtensionPatch))]
    [ModelReaderWriterBuildable(typeof(ArcExtensionPatchContent))]
    [ModelReaderWriterBuildable(typeof(ArcExtensionResource))]
    [ModelReaderWriterBuildable(typeof(ArcExtensionUpgradeContent))]
    [ModelReaderWriterBuildable(typeof(ArcIdentityResult))]
    [ModelReaderWriterBuildable(typeof(ArcPasswordCredential))]
    [ModelReaderWriterBuildable(typeof(ArcSettingData))]
    [ModelReaderWriterBuildable(typeof(ArcSettingList))]
    [ModelReaderWriterBuildable(typeof(ArcSettingPatch))]
    [ModelReaderWriterBuildable(typeof(ArcSettingResource))]
    [ModelReaderWriterBuildable(typeof(DeploymentSettingAdapterPropertyOverrides))]
    [ModelReaderWriterBuildable(typeof(DeploymentSettingHostNetwork))]
    [ModelReaderWriterBuildable(typeof(DeploymentSettingInfrastructureNetwork))]
    [ModelReaderWriterBuildable(typeof(DeploymentSettingIntents))]
    [ModelReaderWriterBuildable(typeof(DeploymentSettingIPPools))]
    [ModelReaderWriterBuildable(typeof(DeploymentSettingListResult))]
    [ModelReaderWriterBuildable(typeof(DeploymentSettingNetworkController))]
    [ModelReaderWriterBuildable(typeof(DeploymentSettingObservability))]
    [ModelReaderWriterBuildable(typeof(DeploymentSettingPhysicalNodes))]
    [ModelReaderWriterBuildable(typeof(DeploymentSettingQosPolicyOverrides))]
    [ModelReaderWriterBuildable(typeof(DeploymentSettingScaleUnits))]
    [ModelReaderWriterBuildable(typeof(DeploymentSettingStorage))]
    [ModelReaderWriterBuildable(typeof(DeploymentSettingStorageAdapterIPInfo))]
    [ModelReaderWriterBuildable(typeof(DeploymentSettingStorageNetworks))]
    [ModelReaderWriterBuildable(typeof(DeploymentSettingVirtualSwitchConfigurationOverrides))]
    [ModelReaderWriterBuildable(typeof(EceActionStatus))]
    [ModelReaderWriterBuildable(typeof(EceDeploymentSecrets))]
    [ModelReaderWriterBuildable(typeof(EceReportedProperties))]
    [ModelReaderWriterBuildable(typeof(EdgeDeviceListResult))]
    [ModelReaderWriterBuildable(typeof(HciArcEnabledEdgeDevice))]
    [ModelReaderWriterBuildable(typeof(HciArcEnabledEdgeDeviceProperties))]
    [ModelReaderWriterBuildable(typeof(HciClusterCertificateContent))]
    [ModelReaderWriterBuildable(typeof(HciClusterData))]
    [ModelReaderWriterBuildable(typeof(HciClusterDeploymentConfiguration))]
    [ModelReaderWriterBuildable(typeof(HciClusterDeploymentInfo))]
    [ModelReaderWriterBuildable(typeof(HciClusterDeploymentSecuritySettings))]
    [ModelReaderWriterBuildable(typeof(HciClusterDeploymentSettingData))]
    [ModelReaderWriterBuildable(typeof(HciClusterDeploymentSettingResource))]
    [ModelReaderWriterBuildable(typeof(HciClusterDeploymentStep))]
    [ModelReaderWriterBuildable(typeof(HciClusterDesiredProperties))]
    [ModelReaderWriterBuildable(typeof(HciClusterIdentityResult))]
    [ModelReaderWriterBuildable(typeof(HciClusterListResult))]
    [ModelReaderWriterBuildable(typeof(HciClusterNode))]
    [ModelReaderWriterBuildable(typeof(HciClusterOfferData))]
    [ModelReaderWriterBuildable(typeof(HciClusterOfferResource))]
    [ModelReaderWriterBuildable(typeof(HciClusterPatch))]
    [ModelReaderWriterBuildable(typeof(HciClusterPublisherData))]
    [ModelReaderWriterBuildable(typeof(HciClusterPublisherResource))]
    [ModelReaderWriterBuildable(typeof(HciClusterRawCertificate))]
    [ModelReaderWriterBuildable(typeof(HciClusterReportedProperties))]
    [ModelReaderWriterBuildable(typeof(HciClusterResource))]
    [ModelReaderWriterBuildable(typeof(HciClusterSecuritySettingData))]
    [ModelReaderWriterBuildable(typeof(HciClusterSecuritySettingResource))]
    [ModelReaderWriterBuildable(typeof(HciClusterUpdateData))]
    [ModelReaderWriterBuildable(typeof(HciClusterUpdatePrerequisite))]
    [ModelReaderWriterBuildable(typeof(HciClusterUpdateResource))]
    [ModelReaderWriterBuildable(typeof(HciClusterUpdateRunData))]
    [ModelReaderWriterBuildable(typeof(HciClusterUpdateRunResource))]
    [ModelReaderWriterBuildable(typeof(HciClusterUpdateSummaryData))]
    [ModelReaderWriterBuildable(typeof(HciClusterUpdateSummaryResource))]
    [ModelReaderWriterBuildable(typeof(HciDeploymentCluster))]
    [ModelReaderWriterBuildable(typeof(HciEdgeDeviceAdapterPropertyOverrides))]
    [ModelReaderWriterBuildable(typeof(HciEdgeDeviceArcExtension))]
    [ModelReaderWriterBuildable(typeof(HciEdgeDeviceConfiguration))]
    [ModelReaderWriterBuildable(typeof(HciEdgeDeviceData))]
    [ModelReaderWriterBuildable(typeof(HciEdgeDeviceExtensionProfile))]
    [ModelReaderWriterBuildable(typeof(HciEdgeDeviceHostNetwork))]
    [ModelReaderWriterBuildable(typeof(HciEdgeDeviceIntents))]
    [ModelReaderWriterBuildable(typeof(HciEdgeDeviceNicDetail))]
    [ModelReaderWriterBuildable(typeof(HciEdgeDeviceProperties))]
    [ModelReaderWriterBuildable(typeof(HciEdgeDeviceReportedProperties))]
    [ModelReaderWriterBuildable(typeof(HciEdgeDeviceResource))]
    [ModelReaderWriterBuildable(typeof(HciEdgeDeviceStorageAdapterIPInfo))]
    [ModelReaderWriterBuildable(typeof(HciEdgeDeviceStorageNetworks))]
    [ModelReaderWriterBuildable(typeof(HciEdgeDeviceSwitchDetail))]
    [ModelReaderWriterBuildable(typeof(HciEdgeDeviceValidateContent))]
    [ModelReaderWriterBuildable(typeof(HciEdgeDeviceValidateResult))]
    [ModelReaderWriterBuildable(typeof(HciEdgeDeviceVirtualSwitchConfigurationOverrides))]
    [ModelReaderWriterBuildable(typeof(HciEdgeSwitchExtension))]
    [ModelReaderWriterBuildable(typeof(HciNetworkProfile))]
    [ModelReaderWriterBuildable(typeof(HciNicDetail))]
    [ModelReaderWriterBuildable(typeof(HciOfferList))]
    [ModelReaderWriterBuildable(typeof(HciOSProfile))]
    [ModelReaderWriterBuildable(typeof(HciPackageVersionInfo))]
    [ModelReaderWriterBuildable(typeof(HciPrecheckResult))]
    [ModelReaderWriterBuildable(typeof(HciPrecheckResultTags))]
    [ModelReaderWriterBuildable(typeof(HciPublisherList))]
    [ModelReaderWriterBuildable(typeof(HciReportedProperties))]
    [ModelReaderWriterBuildable(typeof(HciSkuData))]
    [ModelReaderWriterBuildable(typeof(HciSkuList))]
    [ModelReaderWriterBuildable(typeof(HciSkuMappings))]
    [ModelReaderWriterBuildable(typeof(HciSkuResource))]
    [ModelReaderWriterBuildable(typeof(HciUpdateList))]
    [ModelReaderWriterBuildable(typeof(HciUpdateStep))]
    [ModelReaderWriterBuildable(typeof(HciValidationFailureDetail))]
    [ModelReaderWriterBuildable(typeof(IsolatedVmAttestationConfiguration))]
    [ModelReaderWriterBuildable(typeof(LogCollectionContent))]
    [ModelReaderWriterBuildable(typeof(LogCollectionContentProperties))]
    [ModelReaderWriterBuildable(typeof(LogCollectionError))]
    [ModelReaderWriterBuildable(typeof(LogCollectionProperties))]
    [ModelReaderWriterBuildable(typeof(LogCollectionSession))]
    [ModelReaderWriterBuildable(typeof(OptionalServices))]
    [ModelReaderWriterBuildable(typeof(PerNodeArcState))]
    [ModelReaderWriterBuildable(typeof(PerNodeExtensionState))]
    [ModelReaderWriterBuildable(typeof(PerNodeRemoteSupportSession))]
    [ModelReaderWriterBuildable(typeof(RemoteSupportContent))]
    [ModelReaderWriterBuildable(typeof(RemoteSupportContentProperties))]
    [ModelReaderWriterBuildable(typeof(RemoteSupportNodeSettings))]
    [ModelReaderWriterBuildable(typeof(RemoteSupportProperties))]
    [ModelReaderWriterBuildable(typeof(ResponseError))]
    [ModelReaderWriterBuildable(typeof(SbeCredentials))]
    [ModelReaderWriterBuildable(typeof(SbeDeploymentInfo))]
    [ModelReaderWriterBuildable(typeof(SbeDeploymentPackageInfo))]
    [ModelReaderWriterBuildable(typeof(SbePartnerInfo))]
    [ModelReaderWriterBuildable(typeof(SbePartnerProperties))]
    [ModelReaderWriterBuildable(typeof(SdnIntegration))]
    [ModelReaderWriterBuildable(typeof(SecurityComplianceStatus))]
    [ModelReaderWriterBuildable(typeof(SecuritySettingListResult))]
    [ModelReaderWriterBuildable(typeof(SoftwareAssuranceChangeContent))]
    [ModelReaderWriterBuildable(typeof(SoftwareAssuranceChangeRequestProperties))]
    [ModelReaderWriterBuildable(typeof(SoftwareAssuranceProperties))]
    [ModelReaderWriterBuildable(typeof(SystemData))]
    [ModelReaderWriterBuildable(typeof(UnknownEdgeDevice))]
    [ModelReaderWriterBuildable(typeof(UpdateRunList))]
    [ModelReaderWriterBuildable(typeof(UpdateSummariesList))]
    [ModelReaderWriterBuildable(typeof(UserAssignedIdentity))]
    public partial class AzureResourceManagerHciContext : ModelReaderWriterContext
    {
    }
}
