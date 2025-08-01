// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for task that migrates SQL Server databases to Azure SQL Database Managed Instance online scenario. </summary>
    public partial class SqlServerSqlMISyncTaskInput
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SqlServerSqlMISyncTaskInput"/>. </summary>
        /// <param name="selectedDatabases"> Databases to migrate. </param>
        /// <param name="storageResourceId"> Fully qualified resourceId of storage. </param>
        /// <param name="sourceConnectionInfo"> Connection information for source SQL Server. </param>
        /// <param name="targetConnectionInfo"> Connection information for Azure SQL Database Managed Instance. </param>
        /// <param name="azureApp"> Azure Active Directory Application the DMS (classic) instance will use to connect to the target instance of Azure SQL Database Managed Instance and the Azure Storage Account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="selectedDatabases"/>, <paramref name="storageResourceId"/>, <paramref name="sourceConnectionInfo"/>, <paramref name="targetConnectionInfo"/> or <paramref name="azureApp"/> is null. </exception>
        public SqlServerSqlMISyncTaskInput(IEnumerable<MigrateSqlServerSqlMIDatabaseInput> selectedDatabases, string storageResourceId, DataMigrationSqlConnectionInfo sourceConnectionInfo, DataMigrationMISqlConnectionInfo targetConnectionInfo, DataMigrationAadApp azureApp)
        {
            Argument.AssertNotNull(selectedDatabases, nameof(selectedDatabases));
            Argument.AssertNotNull(storageResourceId, nameof(storageResourceId));
            Argument.AssertNotNull(sourceConnectionInfo, nameof(sourceConnectionInfo));
            Argument.AssertNotNull(targetConnectionInfo, nameof(targetConnectionInfo));
            Argument.AssertNotNull(azureApp, nameof(azureApp));

            SelectedDatabases = selectedDatabases.ToList();
            StorageResourceId = storageResourceId;
            SourceConnectionInfo = sourceConnectionInfo;
            TargetConnectionInfo = targetConnectionInfo;
            AzureApp = azureApp;
        }

        /// <summary> Initializes a new instance of <see cref="SqlServerSqlMISyncTaskInput"/>. </summary>
        /// <param name="selectedDatabases"> Databases to migrate. </param>
        /// <param name="backupFileShare"> Backup file share information for all selected databases. </param>
        /// <param name="storageResourceId"> Fully qualified resourceId of storage. </param>
        /// <param name="sourceConnectionInfo"> Connection information for source SQL Server. </param>
        /// <param name="targetConnectionInfo"> Connection information for Azure SQL Database Managed Instance. </param>
        /// <param name="azureApp"> Azure Active Directory Application the DMS (classic) instance will use to connect to the target instance of Azure SQL Database Managed Instance and the Azure Storage Account. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlServerSqlMISyncTaskInput(IList<MigrateSqlServerSqlMIDatabaseInput> selectedDatabases, DataMigrationFileShareInfo backupFileShare, string storageResourceId, DataMigrationSqlConnectionInfo sourceConnectionInfo, DataMigrationMISqlConnectionInfo targetConnectionInfo, DataMigrationAadApp azureApp, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SelectedDatabases = selectedDatabases;
            BackupFileShare = backupFileShare;
            StorageResourceId = storageResourceId;
            SourceConnectionInfo = sourceConnectionInfo;
            TargetConnectionInfo = targetConnectionInfo;
            AzureApp = azureApp;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SqlServerSqlMISyncTaskInput"/> for deserialization. </summary>
        internal SqlServerSqlMISyncTaskInput()
        {
        }

        /// <summary> Databases to migrate. </summary>
        public IList<MigrateSqlServerSqlMIDatabaseInput> SelectedDatabases { get; }
        /// <summary> Backup file share information for all selected databases. </summary>
        public DataMigrationFileShareInfo BackupFileShare { get; set; }
        /// <summary> Fully qualified resourceId of storage. </summary>
        public string StorageResourceId { get; set; }
        /// <summary> Connection information for source SQL Server. </summary>
        public DataMigrationSqlConnectionInfo SourceConnectionInfo { get; set; }
        /// <summary> Connection information for Azure SQL Database Managed Instance. </summary>
        public DataMigrationMISqlConnectionInfo TargetConnectionInfo { get; set; }
        /// <summary> Azure Active Directory Application the DMS (classic) instance will use to connect to the target instance of Azure SQL Database Managed Instance and the Azure Storage Account. </summary>
        public DataMigrationAadApp AzureApp { get; set; }
    }
}
