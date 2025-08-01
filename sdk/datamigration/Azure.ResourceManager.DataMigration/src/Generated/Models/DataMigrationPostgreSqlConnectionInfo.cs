// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Information for connecting to PostgreSQL server. </summary>
    public partial class DataMigrationPostgreSqlConnectionInfo : ServerConnectionInfo
    {
        /// <summary> Initializes a new instance of <see cref="DataMigrationPostgreSqlConnectionInfo"/>. </summary>
        /// <param name="serverName"> Name of the server. </param>
        /// <param name="port"> Port for Server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public DataMigrationPostgreSqlConnectionInfo(string serverName, int port)
        {
            Argument.AssertNotNull(serverName, nameof(serverName));

            ServerName = serverName;
            Port = port;
            ConnectionInfoType = "PostgreSqlConnectionInfo";
        }

        /// <summary> Initializes a new instance of <see cref="DataMigrationPostgreSqlConnectionInfo"/>. </summary>
        /// <param name="connectionInfoType"> Type of connection info. </param>
        /// <param name="userName"> User name. </param>
        /// <param name="password"> Password credential. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="serverName"> Name of the server. </param>
        /// <param name="dataSource"> Data source. </param>
        /// <param name="serverVersion"> server version. </param>
        /// <param name="databaseName"> Name of the database. </param>
        /// <param name="port"> Port for Server. </param>
        /// <param name="shouldEncryptConnection"> Whether to encrypt the connection. </param>
        /// <param name="shouldTrustServerCertificate"> Whether to trust the server certificate. </param>
        /// <param name="additionalSettings"> Additional connection settings. </param>
        /// <param name="serverBrandVersion"> server brand version. </param>
        /// <param name="authentication"> Authentication type to use for connection. </param>
        internal DataMigrationPostgreSqlConnectionInfo(string connectionInfoType, string userName, string password, IDictionary<string, BinaryData> serializedAdditionalRawData, string serverName, string dataSource, string serverVersion, string databaseName, int port, bool? shouldEncryptConnection, bool? shouldTrustServerCertificate, string additionalSettings, string serverBrandVersion, DataMigrationAuthenticationType? authentication) : base(connectionInfoType, userName, password, serializedAdditionalRawData)
        {
            ServerName = serverName;
            DataSource = dataSource;
            ServerVersion = serverVersion;
            DatabaseName = databaseName;
            Port = port;
            ShouldEncryptConnection = shouldEncryptConnection;
            ShouldTrustServerCertificate = shouldTrustServerCertificate;
            AdditionalSettings = additionalSettings;
            ServerBrandVersion = serverBrandVersion;
            Authentication = authentication;
            ConnectionInfoType = connectionInfoType ?? "PostgreSqlConnectionInfo";
        }

        /// <summary> Initializes a new instance of <see cref="DataMigrationPostgreSqlConnectionInfo"/> for deserialization. </summary>
        internal DataMigrationPostgreSqlConnectionInfo()
        {
        }

        /// <summary> Name of the server. </summary>
        public string ServerName { get; set; }
        /// <summary> Data source. </summary>
        public string DataSource { get; set; }
        /// <summary> server version. </summary>
        public string ServerVersion { get; set; }
        /// <summary> Name of the database. </summary>
        public string DatabaseName { get; set; }
        /// <summary> Port for Server. </summary>
        public int Port { get; set; }
        /// <summary> Whether to encrypt the connection. </summary>
        public bool? ShouldEncryptConnection { get; set; }
        /// <summary> Whether to trust the server certificate. </summary>
        public bool? ShouldTrustServerCertificate { get; set; }
        /// <summary> Additional connection settings. </summary>
        public string AdditionalSettings { get; set; }
        /// <summary> server brand version. </summary>
        public string ServerBrandVersion { get; set; }
        /// <summary> Authentication type to use for connection. </summary>
        public DataMigrationAuthenticationType? Authentication { get; set; }
    }
}
