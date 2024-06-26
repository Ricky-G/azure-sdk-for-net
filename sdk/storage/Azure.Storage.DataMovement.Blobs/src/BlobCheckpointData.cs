﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using Azure.Storage.Blobs.Models;

namespace Azure.Storage.DataMovement.Blobs
{
    /// <summary>
    /// Base class for Blob source and destination checkpoint data
    /// which contains shared fields.
    /// </summary>
    internal abstract class BlobCheckpointData : StorageResourceCheckpointData
    {
        /// <summary>
        /// Schema version.
        /// </summary>
        public int Version;

        public BlobCheckpointData(int version)
        {
            Version = version;
        }
    }
}
