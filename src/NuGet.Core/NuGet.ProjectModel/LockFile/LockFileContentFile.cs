// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace NuGet.ProjectModel
{
    public class LockFileContentFile: LockFileItem, IEquatable<LockFileContentFile>
    {
        public const string BuildActionProperty = "buildAction";
        public const string CodeLanguageProperty = "codeLanguage";
        public const string PPOutputPathProperty = "ppOutputPath";
        public const string OutputPathProperty = "outputPath";
        public const string CopyToOutputProperty = "copyToOutput";

        public LockFileContentFile(string path) : base(path)
        {
        }

        public string OutputPath
        {
            get
            {
                return GetProperty(OutputPathProperty);
            }
            set
            {
                SetProperty(OutputPathProperty, value);
            }
        }

        public string PPOutputPath
        {
            get
            {
                return GetProperty(OutputPathProperty);
            }
            set
            {
                SetProperty(OutputPathProperty, value);
            }
        }

        public string BuildAction
        {
            get
            {
                return GetProperty(OutputPathProperty);
            }
            set
            {
                SetProperty(OutputPathProperty, value);
            }
        }

        public string CodeLanguage
        {
            get
            {
                return GetProperty(OutputPathProperty);
            }
            set
            {
                SetProperty(OutputPathProperty, value);
            }
        }

        public bool CopyToOutput
        {
            get
            {
                return string.Equals(GetProperty(OutputPathProperty), bool.TrueString, StringComparison.OrdinalIgnoreCase);
            }
            set
            {
                SetProperty(OutputPathProperty, value.ToString());
            }
        }
    }
}