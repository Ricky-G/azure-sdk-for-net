// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for task that validates migration input for SQL to Azure SQL Managed Instance. </summary>
    public partial class ValidateMigrationInputSqlServerSqlMITaskInput
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

        /// <summary> Initializes a new instance of <see cref="ValidateMigrationInputSqlServerSqlMITaskInput"/>. </summary>
        /// <param name="sourceConnectionInfo"> Information for connecting to source. </param>
        /// <param name="targetConnectionInfo"> Information for connecting to target. </param>
        /// <param name="selectedDatabases"> Databases to migrate. </param>
        /// <param name="backupBlobShare"> SAS URI of Azure Storage Account Container to be used for storing backup files. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceConnectionInfo"/>, <paramref name="targetConnectionInfo"/>, <paramref name="selectedDatabases"/> or <paramref name="backupBlobShare"/> is null. </exception>
        public ValidateMigrationInputSqlServerSqlMITaskInput(DataMigrationSqlConnectionInfo sourceConnectionInfo, DataMigrationSqlConnectionInfo targetConnectionInfo, IEnumerable<MigrateSqlServerSqlMIDatabaseInput> selectedDatabases, DataMigrationBlobShare backupBlobShare)
        {
            Argument.AssertNotNull(sourceConnectionInfo, nameof(sourceConnectionInfo));
            Argument.AssertNotNull(targetConnectionInfo, nameof(targetConnectionInfo));
            Argument.AssertNotNull(selectedDatabases, nameof(selectedDatabases));
            Argument.AssertNotNull(backupBlobShare, nameof(backupBlobShare));

            SourceConnectionInfo = sourceConnectionInfo;
            TargetConnectionInfo = targetConnectionInfo;
            SelectedDatabases = selectedDatabases.ToList();
            SelectedLogins = new ChangeTrackingList<string>();
            BackupBlobShare = backupBlobShare;
        }

        /// <summary> Initializes a new instance of <see cref="ValidateMigrationInputSqlServerSqlMITaskInput"/>. </summary>
        /// <param name="sourceConnectionInfo"> Information for connecting to source. </param>
        /// <param name="targetConnectionInfo"> Information for connecting to target. </param>
        /// <param name="selectedDatabases"> Databases to migrate. </param>
        /// <param name="selectedLogins"> Logins to migrate. </param>
        /// <param name="backupFileShare"> Backup file share information for all selected databases. </param>
        /// <param name="backupBlobShare"> SAS URI of Azure Storage Account Container to be used for storing backup files. </param>
        /// <param name="backupMode"> Backup Mode to specify whether to use existing backup or create new backup. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ValidateMigrationInputSqlServerSqlMITaskInput(DataMigrationSqlConnectionInfo sourceConnectionInfo, DataMigrationSqlConnectionInfo targetConnectionInfo, IList<MigrateSqlServerSqlMIDatabaseInput> selectedDatabases, IList<string> selectedLogins, DataMigrationFileShareInfo backupFileShare, DataMigrationBlobShare backupBlobShare, DataMigrationBackupMode? backupMode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceConnectionInfo = sourceConnectionInfo;
            TargetConnectionInfo = targetConnectionInfo;
            SelectedDatabases = selectedDatabases;
            SelectedLogins = selectedLogins;
            BackupFileShare = backupFileShare;
            BackupBlobShare = backupBlobShare;
            BackupMode = backupMode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ValidateMigrationInputSqlServerSqlMITaskInput"/> for deserialization. </summary>
        internal ValidateMigrationInputSqlServerSqlMITaskInput()
        {
        }

        /// <summary> Information for connecting to source. </summary>
        public DataMigrationSqlConnectionInfo SourceConnectionInfo { get; set; }
        /// <summary> Information for connecting to target. </summary>
        public DataMigrationSqlConnectionInfo TargetConnectionInfo { get; set; }
        /// <summary> Databases to migrate. </summary>
        public IList<MigrateSqlServerSqlMIDatabaseInput> SelectedDatabases { get; }
        /// <summary> Logins to migrate. </summary>
        public IList<string> SelectedLogins { get; }
        /// <summary> Backup file share information for all selected databases. </summary>
        public DataMigrationFileShareInfo BackupFileShare { get; set; }
        /// <summary> SAS URI of Azure Storage Account Container to be used for storing backup files. </summary>
        internal DataMigrationBlobShare BackupBlobShare { get; set; }
        /// <summary> SAS URI of Azure Storage Account Container. </summary>
        public Uri BackupBlobShareSasUri
        {
            get => BackupBlobShare is null ? default : BackupBlobShare.SasUri;
            set
            {
                if (BackupBlobShare is null)
                    BackupBlobShare = new DataMigrationBlobShare();
                BackupBlobShare.SasUri = value;
            }
        }

        /// <summary> Backup Mode to specify whether to use existing backup or create new backup. </summary>
        public DataMigrationBackupMode? BackupMode { get; set; }
    }
}
