// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace NuGet.ProjectModel
{
    public class LockFileRuntimeTarget: LockFileItem
    {
        public const string RidProperty = "rid";
        public const string AssetTypeProperty = "assetType";

        public LockFileRuntimeTarget(string path):base(path)
        {
        }

        public string Runtime
        {
            get
            {
                return GetProperty(RidProperty);
            }
            set
            {
                SetProperty(RidProperty, value);
            }
        }

        public string AssetType
        {
            get
            {
                return GetProperty(AssetTypeProperty);
            }
            set
            {
                SetProperty(AssetTypeProperty, value);
            }
        }
    }
}