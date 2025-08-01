// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The MigrateSqlServerSqlDBSyncTaskOutputTableLevel. </summary>
    public partial class MigrateSqlServerSqlDBSyncTaskOutputTableLevel : MigrateSqlServerSqlDBSyncTaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlDBSyncTaskOutputTableLevel"/>. </summary>
        internal MigrateSqlServerSqlDBSyncTaskOutputTableLevel()
        {
            ResultType = "TableLevelOutput";
        }

        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlDBSyncTaskOutputTableLevel"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="tableName"> Name of the table. </param>
        /// <param name="databaseName"> Name of the database. </param>
        /// <param name="cdcInsertCounter"> Number of applied inserts. </param>
        /// <param name="cdcUpdateCounter"> Number of applied updates. </param>
        /// <param name="cdcDeleteCounter"> Number of applied deletes. </param>
        /// <param name="fullLoadEstFinishedOn"> Estimate to finish full load. </param>
        /// <param name="fullLoadStartedOn"> Full load start time. </param>
        /// <param name="fullLoadEndedOn"> Full load end time. </param>
        /// <param name="fullLoadTotalRows"> Number of rows applied in full load. </param>
        /// <param name="state"> Current state of the table migration. </param>
        /// <param name="totalChangesApplied"> Total number of applied changes. </param>
        /// <param name="dataErrorsCounter"> Number of data errors occurred. </param>
        /// <param name="lastModifiedOn"> Last modified time on target. </param>
        internal MigrateSqlServerSqlDBSyncTaskOutputTableLevel(string id, string resultType, IDictionary<string, BinaryData> serializedAdditionalRawData, string tableName, string databaseName, long? cdcInsertCounter, long? cdcUpdateCounter, long? cdcDeleteCounter, DateTimeOffset? fullLoadEstFinishedOn, DateTimeOffset? fullLoadStartedOn, DateTimeOffset? fullLoadEndedOn, long? fullLoadTotalRows, SyncTableMigrationState? state, long? totalChangesApplied, long? dataErrorsCounter, DateTimeOffset? lastModifiedOn) : base(id, resultType, serializedAdditionalRawData)
        {
            TableName = tableName;
            DatabaseName = databaseName;
            CdcInsertCounter = cdcInsertCounter;
            CdcUpdateCounter = cdcUpdateCounter;
            CdcDeleteCounter = cdcDeleteCounter;
            FullLoadEstFinishedOn = fullLoadEstFinishedOn;
            FullLoadStartedOn = fullLoadStartedOn;
            FullLoadEndedOn = fullLoadEndedOn;
            FullLoadTotalRows = fullLoadTotalRows;
            State = state;
            TotalChangesApplied = totalChangesApplied;
            DataErrorsCounter = dataErrorsCounter;
            LastModifiedOn = lastModifiedOn;
            ResultType = resultType ?? "TableLevelOutput";
        }

        /// <summary> Name of the table. </summary>
        public string TableName { get; }
        /// <summary> Name of the database. </summary>
        public string DatabaseName { get; }
        /// <summary> Number of applied inserts. </summary>
        public long? CdcInsertCounter { get; }
        /// <summary> Number of applied updates. </summary>
        public long? CdcUpdateCounter { get; }
        /// <summary> Number of applied deletes. </summary>
        public long? CdcDeleteCounter { get; }
        /// <summary> Estimate to finish full load. </summary>
        public DateTimeOffset? FullLoadEstFinishedOn { get; }
        /// <summary> Full load start time. </summary>
        public DateTimeOffset? FullLoadStartedOn { get; }
        /// <summary> Full load end time. </summary>
        public DateTimeOffset? FullLoadEndedOn { get; }
        /// <summary> Number of rows applied in full load. </summary>
        public long? FullLoadTotalRows { get; }
        /// <summary> Current state of the table migration. </summary>
        public SyncTableMigrationState? State { get; }
        /// <summary> Total number of applied changes. </summary>
        public long? TotalChangesApplied { get; }
        /// <summary> Number of data errors occurred. </summary>
        public long? DataErrorsCounter { get; }
        /// <summary> Last modified time on target. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
    }
}
