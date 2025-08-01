// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServicesBackup.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary>
    /// Context class which will be filled in by the System.ClientModel.SourceGeneration.
    /// For more information see 'https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/System.ClientModel/src/docs/ModelReaderWriterContext.md'
    /// </summary>
    [ModelReaderWriterBuildable(typeof(BackupCommonSettings))]
    [ModelReaderWriterBuildable(typeof(BackupContent))]
    [ModelReaderWriterBuildable(typeof(BackupDailySchedule))]
    [ModelReaderWriterBuildable(typeof(BackupDay))]
    [ModelReaderWriterBuildable(typeof(BackupEngineBaseResourceList))]
    [ModelReaderWriterBuildable(typeof(BackupEngineData))]
    [ModelReaderWriterBuildable(typeof(BackupEngineExtendedInfo))]
    [ModelReaderWriterBuildable(typeof(BackupEngineResource))]
    [ModelReaderWriterBuildable(typeof(BackupErrorDetail))]
    [ModelReaderWriterBuildable(typeof(BackupGenericEngine))]
    [ModelReaderWriterBuildable(typeof(BackupGenericJob))]
    [ModelReaderWriterBuildable(typeof(BackupGenericProtectedItem))]
    [ModelReaderWriterBuildable(typeof(BackupGenericProtectionContainer))]
    [ModelReaderWriterBuildable(typeof(BackupGenericProtectionIntent))]
    [ModelReaderWriterBuildable(typeof(BackupGenericProtectionPolicy))]
    [ModelReaderWriterBuildable(typeof(BackupGenericRecoveryPoint))]
    [ModelReaderWriterBuildable(typeof(BackupGoalFeatureSupportContent))]
    [ModelReaderWriterBuildable(typeof(BackupHourlySchedule))]
    [ModelReaderWriterBuildable(typeof(BackupIdentityInfo))]
    [ModelReaderWriterBuildable(typeof(BackupJobData))]
    [ModelReaderWriterBuildable(typeof(BackupJobListResult))]
    [ModelReaderWriterBuildable(typeof(BackupJobResource))]
    [ModelReaderWriterBuildable(typeof(BackupManagementUsage))]
    [ModelReaderWriterBuildable(typeof(BackupManagementUsageList))]
    [ModelReaderWriterBuildable(typeof(BackupNameInfo))]
    [ModelReaderWriterBuildable(typeof(BackupPrivateEndpointConnectionData))]
    [ModelReaderWriterBuildable(typeof(BackupPrivateEndpointConnectionProperties))]
    [ModelReaderWriterBuildable(typeof(BackupPrivateEndpointConnectionResource))]
    [ModelReaderWriterBuildable(typeof(BackupProtectedItemData))]
    [ModelReaderWriterBuildable(typeof(BackupProtectedItemResource))]
    [ModelReaderWriterBuildable(typeof(BackupProtectionContainerData))]
    [ModelReaderWriterBuildable(typeof(BackupProtectionContainerResource))]
    [ModelReaderWriterBuildable(typeof(BackupProtectionIntentData))]
    [ModelReaderWriterBuildable(typeof(BackupProtectionIntentResource))]
    [ModelReaderWriterBuildable(typeof(BackupProtectionPolicyData))]
    [ModelReaderWriterBuildable(typeof(BackupProtectionPolicyResource))]
    [ModelReaderWriterBuildable(typeof(BackupRecoveryPointData))]
    [ModelReaderWriterBuildable(typeof(BackupRecoveryPointResource))]
    [ModelReaderWriterBuildable(typeof(BackupResourceConfigData))]
    [ModelReaderWriterBuildable(typeof(BackupResourceConfigProperties))]
    [ModelReaderWriterBuildable(typeof(BackupResourceConfigResource))]
    [ModelReaderWriterBuildable(typeof(BackupResourceEncryptionConfig))]
    [ModelReaderWriterBuildable(typeof(BackupResourceEncryptionConfigExtendedCreateOrUpdateContent))]
    [ModelReaderWriterBuildable(typeof(BackupResourceEncryptionConfigExtendedData))]
    [ModelReaderWriterBuildable(typeof(BackupResourceEncryptionConfigExtendedProperties))]
    [ModelReaderWriterBuildable(typeof(BackupResourceEncryptionConfigExtendedResource))]
    [ModelReaderWriterBuildable(typeof(BackupResourceVaultConfigData))]
    [ModelReaderWriterBuildable(typeof(BackupResourceVaultConfigProperties))]
    [ModelReaderWriterBuildable(typeof(BackupResourceVaultConfigResource))]
    [ModelReaderWriterBuildable(typeof(BackupRetentionPolicy))]
    [ModelReaderWriterBuildable(typeof(BackupSchedulePolicy))]
    [ModelReaderWriterBuildable(typeof(BackupServerContainer))]
    [ModelReaderWriterBuildable(typeof(BackupServerEngine))]
    [ModelReaderWriterBuildable(typeof(BackupStatusContent))]
    [ModelReaderWriterBuildable(typeof(BackupStatusResult))]
    [ModelReaderWriterBuildable(typeof(BackupTargetDiskNetworkAccessSettings))]
    [ModelReaderWriterBuildable(typeof(BackupTieringPolicy))]
    [ModelReaderWriterBuildable(typeof(BackupWeeklySchedule))]
    [ModelReaderWriterBuildable(typeof(BekDetails))]
    [ModelReaderWriterBuildable(typeof(ContainerIdentityInfo))]
    [ModelReaderWriterBuildable(typeof(DailyRetentionFormat))]
    [ModelReaderWriterBuildable(typeof(DailyRetentionSchedule))]
    [ModelReaderWriterBuildable(typeof(DiskExclusionProperties))]
    [ModelReaderWriterBuildable(typeof(DiskInformation))]
    [ModelReaderWriterBuildable(typeof(DistributedNodesInfo))]
    [ModelReaderWriterBuildable(typeof(DpmBackupEngine))]
    [ModelReaderWriterBuildable(typeof(DpmBackupJob))]
    [ModelReaderWriterBuildable(typeof(DpmBackupJobExtendedInfo))]
    [ModelReaderWriterBuildable(typeof(DpmBackupJobTaskDetails))]
    [ModelReaderWriterBuildable(typeof(DpmContainer))]
    [ModelReaderWriterBuildable(typeof(DpmContainerExtendedInfo))]
    [ModelReaderWriterBuildable(typeof(DpmErrorInfo))]
    [ModelReaderWriterBuildable(typeof(DpmProtectedItem))]
    [ModelReaderWriterBuildable(typeof(DpmProtectedItemExtendedInfo))]
    [ModelReaderWriterBuildable(typeof(ExtendedLocation))]
    [ModelReaderWriterBuildable(typeof(FeatureSupportContent))]
    [ModelReaderWriterBuildable(typeof(FetchTieringCostInfoContent))]
    [ModelReaderWriterBuildable(typeof(FetchTieringCostInfoForRehydrationContent))]
    [ModelReaderWriterBuildable(typeof(FetchTieringCostSavingsInfoForPolicyContent))]
    [ModelReaderWriterBuildable(typeof(FetchTieringCostSavingsInfoForProtectedItemContent))]
    [ModelReaderWriterBuildable(typeof(FetchTieringCostSavingsInfoForVaultContent))]
    [ModelReaderWriterBuildable(typeof(FileShareBackupContent))]
    [ModelReaderWriterBuildable(typeof(FileShareProtectableItem))]
    [ModelReaderWriterBuildable(typeof(FileshareProtectedItem))]
    [ModelReaderWriterBuildable(typeof(FileshareProtectedItemExtendedInfo))]
    [ModelReaderWriterBuildable(typeof(FileShareProtectionPolicy))]
    [ModelReaderWriterBuildable(typeof(FileShareProvisionIlrContent))]
    [ModelReaderWriterBuildable(typeof(FileShareRecoveryPoint))]
    [ModelReaderWriterBuildable(typeof(FileShareRestoreContent))]
    [ModelReaderWriterBuildable(typeof(GenericContainer))]
    [ModelReaderWriterBuildable(typeof(GenericContainerExtendedInfo))]
    [ModelReaderWriterBuildable(typeof(GenericProtectedItem))]
    [ModelReaderWriterBuildable(typeof(GenericProtectionPolicy))]
    [ModelReaderWriterBuildable(typeof(GenericRecoveryPoint))]
    [ModelReaderWriterBuildable(typeof(IaasClassicComputeVmContainer))]
    [ModelReaderWriterBuildable(typeof(IaasClassicComputeVmProtectableItem))]
    [ModelReaderWriterBuildable(typeof(IaasClassicComputeVmProtectedItem))]
    [ModelReaderWriterBuildable(typeof(IaasComputeVmContainer))]
    [ModelReaderWriterBuildable(typeof(IaasComputeVmProtectableItem))]
    [ModelReaderWriterBuildable(typeof(IaasComputeVmProtectedItem))]
    [ModelReaderWriterBuildable(typeof(IaasVmBackupContent))]
    [ModelReaderWriterBuildable(typeof(IaasVmBackupExtendedProperties))]
    [ModelReaderWriterBuildable(typeof(IaasVmBackupJob))]
    [ModelReaderWriterBuildable(typeof(IaasVmBackupJobExtendedInfo))]
    [ModelReaderWriterBuildable(typeof(IaasVmBackupJobTaskDetails))]
    [ModelReaderWriterBuildable(typeof(IaasVmBackupJobV2))]
    [ModelReaderWriterBuildable(typeof(IaasVmContainer))]
    [ModelReaderWriterBuildable(typeof(IaasVmErrorInfo))]
    [ModelReaderWriterBuildable(typeof(IaasVmHealthDetails))]
    [ModelReaderWriterBuildable(typeof(IaasVmIlrRegistrationContent))]
    [ModelReaderWriterBuildable(typeof(IaasVmProtectableItem))]
    [ModelReaderWriterBuildable(typeof(IaasVmProtectedItem))]
    [ModelReaderWriterBuildable(typeof(IaasVmProtectedItemExtendedInfo))]
    [ModelReaderWriterBuildable(typeof(IaasVmProtectionPolicy))]
    [ModelReaderWriterBuildable(typeof(IaasVmRecoveryPoint))]
    [ModelReaderWriterBuildable(typeof(IaasVmRestoreContent))]
    [ModelReaderWriterBuildable(typeof(IaasVmRestoreWithRehydrationContent))]
    [ModelReaderWriterBuildable(typeof(IdentityBasedRestoreDetails))]
    [ModelReaderWriterBuildable(typeof(IlrContent))]
    [ModelReaderWriterBuildable(typeof(InquiryValidation))]
    [ModelReaderWriterBuildable(typeof(InstantRPAdditionalDetails))]
    [ModelReaderWriterBuildable(typeof(KekDetails))]
    [ModelReaderWriterBuildable(typeof(KeyAndSecretDetails))]
    [ModelReaderWriterBuildable(typeof(KpiResourceHealthDetails))]
    [ModelReaderWriterBuildable(typeof(LogSchedulePolicy))]
    [ModelReaderWriterBuildable(typeof(LongTermRetentionPolicy))]
    [ModelReaderWriterBuildable(typeof(LongTermSchedulePolicy))]
    [ModelReaderWriterBuildable(typeof(MabBackupJob))]
    [ModelReaderWriterBuildable(typeof(MabBackupJobExtendedInfo))]
    [ModelReaderWriterBuildable(typeof(MabBackupJobTaskDetails))]
    [ModelReaderWriterBuildable(typeof(MabContainer))]
    [ModelReaderWriterBuildable(typeof(MabContainerExtendedInfo))]
    [ModelReaderWriterBuildable(typeof(MabContainerHealthDetails))]
    [ModelReaderWriterBuildable(typeof(MabErrorInfo))]
    [ModelReaderWriterBuildable(typeof(MabFileFolderProtectedItem))]
    [ModelReaderWriterBuildable(typeof(MabFileFolderProtectedItemExtendedInfo))]
    [ModelReaderWriterBuildable(typeof(MabProtectionPolicy))]
    [ModelReaderWriterBuildable(typeof(MonthlyRetentionSchedule))]
    [ModelReaderWriterBuildable(typeof(MoveRPAcrossTiersContent))]
    [ModelReaderWriterBuildable(typeof(PointInTimeRange))]
    [ModelReaderWriterBuildable(typeof(PreBackupValidation))]
    [ModelReaderWriterBuildable(typeof(PrepareDataMoveContent))]
    [ModelReaderWriterBuildable(typeof(PreValidateEnableBackupContent))]
    [ModelReaderWriterBuildable(typeof(PreValidateEnableBackupResult))]
    [ModelReaderWriterBuildable(typeof(ProtectableContainer))]
    [ModelReaderWriterBuildable(typeof(ProtectableContainerResource))]
    [ModelReaderWriterBuildable(typeof(ProtectableContainerResourceList))]
    [ModelReaderWriterBuildable(typeof(ProtectedItemResourceList))]
    [ModelReaderWriterBuildable(typeof(ProtectionContainerResourceList))]
    [ModelReaderWriterBuildable(typeof(ProtectionIntentResourceList))]
    [ModelReaderWriterBuildable(typeof(ProtectionPolicyResourceList))]
    [ModelReaderWriterBuildable(typeof(ProvisionIlrConnectionContent))]
    [ModelReaderWriterBuildable(typeof(RecoveryPointDiskConfiguration))]
    [ModelReaderWriterBuildable(typeof(RecoveryPointMoveReadinessInfo))]
    [ModelReaderWriterBuildable(typeof(RecoveryPointProperties))]
    [ModelReaderWriterBuildable(typeof(RecoveryPointRehydrationInfo))]
    [ModelReaderWriterBuildable(typeof(RecoveryPointResourceList))]
    [ModelReaderWriterBuildable(typeof(RecoveryPointsRecommendedForMoveContent))]
    [ModelReaderWriterBuildable(typeof(RecoveryPointTierInformation))]
    [ModelReaderWriterBuildable(typeof(RecoveryPointTierInformationV2))]
    [ModelReaderWriterBuildable(typeof(RecoveryServicesBackupPrivateLinkServiceConnectionState))]
    [ModelReaderWriterBuildable(typeof(RecoveryServiceVaultProtectionIntent))]
    [ModelReaderWriterBuildable(typeof(ResourceGuardOperationDetail))]
    [ModelReaderWriterBuildable(typeof(ResourceGuardProxyBaseResourceList))]
    [ModelReaderWriterBuildable(typeof(ResourceGuardProxyData))]
    [ModelReaderWriterBuildable(typeof(ResourceGuardProxyProperties))]
    [ModelReaderWriterBuildable(typeof(ResourceGuardProxyResource))]
    [ModelReaderWriterBuildable(typeof(ResourceHealthDetails))]
    [ModelReaderWriterBuildable(typeof(ResourceProtectionIntent))]
    [ModelReaderWriterBuildable(typeof(ResponseError))]
    [ModelReaderWriterBuildable(typeof(RestoreContent))]
    [ModelReaderWriterBuildable(typeof(RestoreFileSpecs))]
    [ModelReaderWriterBuildable(typeof(RetentionDuration))]
    [ModelReaderWriterBuildable(typeof(SecuredVmDetails))]
    [ModelReaderWriterBuildable(typeof(SecurityPinContent))]
    [ModelReaderWriterBuildable(typeof(SimpleRetentionPolicy))]
    [ModelReaderWriterBuildable(typeof(SimpleSchedulePolicy))]
    [ModelReaderWriterBuildable(typeof(SimpleSchedulePolicyV2))]
    [ModelReaderWriterBuildable(typeof(SnapshotBackupAdditionalDetails))]
    [ModelReaderWriterBuildable(typeof(SnapshotRestoreContent))]
    [ModelReaderWriterBuildable(typeof(SqlAvailabilityGroupWorkloadProtectionContainer))]
    [ModelReaderWriterBuildable(typeof(SqlContainer))]
    [ModelReaderWriterBuildable(typeof(SqlDataDirectory))]
    [ModelReaderWriterBuildable(typeof(SqlDataDirectoryMapping))]
    [ModelReaderWriterBuildable(typeof(SqlProtectedItem))]
    [ModelReaderWriterBuildable(typeof(SqlProtectedItemExtendedInfo))]
    [ModelReaderWriterBuildable(typeof(SqlProtectionPolicy))]
    [ModelReaderWriterBuildable(typeof(StorageBackupJob))]
    [ModelReaderWriterBuildable(typeof(StorageBackupJobExtendedInfo))]
    [ModelReaderWriterBuildable(typeof(StorageBackupJobTaskDetails))]
    [ModelReaderWriterBuildable(typeof(StorageContainer))]
    [ModelReaderWriterBuildable(typeof(StorageErrorInfo))]
    [ModelReaderWriterBuildable(typeof(StorageProtectableContainer))]
    [ModelReaderWriterBuildable(typeof(SubProtectionPolicy))]
    [ModelReaderWriterBuildable(typeof(SystemData))]
    [ModelReaderWriterBuildable(typeof(TargetAfsRestoreInfo))]
    [ModelReaderWriterBuildable(typeof(TargetRestoreInfo))]
    [ModelReaderWriterBuildable(typeof(TieringCostInfo))]
    [ModelReaderWriterBuildable(typeof(TieringCostRehydrationInfo))]
    [ModelReaderWriterBuildable(typeof(TieringCostSavingInfo))]
    [ModelReaderWriterBuildable(typeof(TokenInformation))]
    [ModelReaderWriterBuildable(typeof(TriggerBackupContent))]
    [ModelReaderWriterBuildable(typeof(TriggerDataMoveContent))]
    [ModelReaderWriterBuildable(typeof(TriggerRestoreContent))]
    [ModelReaderWriterBuildable(typeof(UnknownBackupEngineBase))]
    [ModelReaderWriterBuildable(typeof(UnknownBackupRequest))]
    [ModelReaderWriterBuildable(typeof(UnknownFeatureSupportRequest))]
    [ModelReaderWriterBuildable(typeof(UnknownFetchTieringCostInfoRequest))]
    [ModelReaderWriterBuildable(typeof(UnknownIlrRequest))]
    [ModelReaderWriterBuildable(typeof(UnknownJob))]
    [ModelReaderWriterBuildable(typeof(UnknownProtectableContainer))]
    [ModelReaderWriterBuildable(typeof(UnknownProtectedItem))]
    [ModelReaderWriterBuildable(typeof(UnknownProtectionContainer))]
    [ModelReaderWriterBuildable(typeof(UnknownProtectionIntent))]
    [ModelReaderWriterBuildable(typeof(UnknownProtectionPolicy))]
    [ModelReaderWriterBuildable(typeof(UnknownRecoveryPoint))]
    [ModelReaderWriterBuildable(typeof(UnknownRestoreRequest))]
    [ModelReaderWriterBuildable(typeof(UnknownRetentionPolicy))]
    [ModelReaderWriterBuildable(typeof(UnknownSchedulePolicy))]
    [ModelReaderWriterBuildable(typeof(UnknownTieringCostInfo))]
    [ModelReaderWriterBuildable(typeof(UnknownWorkloadItem))]
    [ModelReaderWriterBuildable(typeof(UnknownWorkloadProtectableItem))]
    [ModelReaderWriterBuildable(typeof(UnlockDeleteContent))]
    [ModelReaderWriterBuildable(typeof(UnlockDeleteResult))]
    [ModelReaderWriterBuildable(typeof(UserAssignedIdentity))]
    [ModelReaderWriterBuildable(typeof(UserAssignedManagedIdentityDetails))]
    [ModelReaderWriterBuildable(typeof(VaultBackupJob))]
    [ModelReaderWriterBuildable(typeof(VaultBackupJobErrorInfo))]
    [ModelReaderWriterBuildable(typeof(VaultBackupJobExtendedInfo))]
    [ModelReaderWriterBuildable(typeof(VaultRetentionPolicy))]
    [ModelReaderWriterBuildable(typeof(VmAppContainerProtectableContainer))]
    [ModelReaderWriterBuildable(typeof(VmAppContainerProtectionContainer))]
    [ModelReaderWriterBuildable(typeof(VmEncryptionDetails))]
    [ModelReaderWriterBuildable(typeof(VmResourceFeatureSupportContent))]
    [ModelReaderWriterBuildable(typeof(VmResourceFeatureSupportResult))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadItem))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadProtectableItem))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadProtectedItem))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadProtectedItemExtendedInfo))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadProtectionPolicy))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadSapAseDatabaseProtectableItem))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadSapAseDatabaseProtectedItem))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadSapAseDatabaseWorkloadItem))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadSapAseSystemProtectableItem))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadSapAseSystemWorkloadItem))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadSapHanaDatabaseProtectableItem))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadSapHanaDatabaseProtectedItem))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadSapHanaDatabaseWorkloadItem))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadSapHanaDBInstance))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadSapHanaDBInstanceProtectedItem))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadSapHanaHsrProtectableItem))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadSapHanaSystemProtectableItem))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadSapHanaSystemWorkloadItem))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadSqlAvailabilityGroupProtectableItem))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadSqlDatabaseProtectableItem))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadSqlDatabaseProtectedItem))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadSqlDatabaseWorkloadItem))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadSqlInstanceProtectableItem))]
    [ModelReaderWriterBuildable(typeof(VmWorkloadSqlInstanceWorkloadItem))]
    [ModelReaderWriterBuildable(typeof(WeeklyRetentionFormat))]
    [ModelReaderWriterBuildable(typeof(WeeklyRetentionSchedule))]
    [ModelReaderWriterBuildable(typeof(WorkloadAutoProtectionIntent))]
    [ModelReaderWriterBuildable(typeof(WorkloadBackupContent))]
    [ModelReaderWriterBuildable(typeof(WorkloadBackupJob))]
    [ModelReaderWriterBuildable(typeof(WorkloadBackupJobExtendedInfo))]
    [ModelReaderWriterBuildable(typeof(WorkloadBackupJobTaskDetails))]
    [ModelReaderWriterBuildable(typeof(WorkloadContainer))]
    [ModelReaderWriterBuildable(typeof(WorkloadContainerAutoProtectionIntent))]
    [ModelReaderWriterBuildable(typeof(WorkloadContainerExtendedInfo))]
    [ModelReaderWriterBuildable(typeof(WorkloadContainerInquiryInfo))]
    [ModelReaderWriterBuildable(typeof(WorkloadErrorInfo))]
    [ModelReaderWriterBuildable(typeof(WorkloadInquiryDetails))]
    [ModelReaderWriterBuildable(typeof(WorkloadItem))]
    [ModelReaderWriterBuildable(typeof(WorkloadItemResource))]
    [ModelReaderWriterBuildable(typeof(WorkloadItemResourceList))]
    [ModelReaderWriterBuildable(typeof(WorkloadPointInTimeRecoveryPoint))]
    [ModelReaderWriterBuildable(typeof(WorkloadPointInTimeRestoreContent))]
    [ModelReaderWriterBuildable(typeof(WorkloadProtectableItem))]
    [ModelReaderWriterBuildable(typeof(WorkloadProtectableItemResource))]
    [ModelReaderWriterBuildable(typeof(WorkloadProtectableItemResourceList))]
    [ModelReaderWriterBuildable(typeof(WorkloadRecoveryPoint))]
    [ModelReaderWriterBuildable(typeof(WorkloadRestoreContent))]
    [ModelReaderWriterBuildable(typeof(WorkloadSapAsePointInTimeRecoveryPoint))]
    [ModelReaderWriterBuildable(typeof(WorkloadSapAsePointInTimeRestoreContent))]
    [ModelReaderWriterBuildable(typeof(WorkloadSapAseRecoveryPoint))]
    [ModelReaderWriterBuildable(typeof(WorkloadSapAseRestoreContent))]
    [ModelReaderWriterBuildable(typeof(WorkloadSapHanaPointInTimeRecoveryPoint))]
    [ModelReaderWriterBuildable(typeof(WorkloadSapHanaPointInTimeRestoreContent))]
    [ModelReaderWriterBuildable(typeof(WorkloadSapHanaPointInTimeRestoreWithRehydrateContent))]
    [ModelReaderWriterBuildable(typeof(WorkloadSapHanaRecoveryPoint))]
    [ModelReaderWriterBuildable(typeof(WorkloadSapHanaRestoreContent))]
    [ModelReaderWriterBuildable(typeof(WorkloadSapHanaRestoreWithRehydrateContent))]
    [ModelReaderWriterBuildable(typeof(WorkloadSqlAutoProtectionIntent))]
    [ModelReaderWriterBuildable(typeof(WorkloadSqlPointInTimeRecoveryPoint))]
    [ModelReaderWriterBuildable(typeof(WorkloadSqlPointInTimeRestoreContent))]
    [ModelReaderWriterBuildable(typeof(WorkloadSqlPointInTimeRestoreWithRehydrateContent))]
    [ModelReaderWriterBuildable(typeof(WorkloadSqlRecoveryPoint))]
    [ModelReaderWriterBuildable(typeof(WorkloadSqlRecoveryPointExtendedInfo))]
    [ModelReaderWriterBuildable(typeof(WorkloadSqlRestoreContent))]
    [ModelReaderWriterBuildable(typeof(WorkloadSqlRestoreWithRehydrateContent))]
    [ModelReaderWriterBuildable(typeof(WritableSubResource))]
    [ModelReaderWriterBuildable(typeof(YearlyRetentionSchedule))]
    public partial class AzureResourceManagerRecoveryServicesBackupContext : ModelReaderWriterContext
    {
    }
}
