﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.Common.Exceptions;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Microsoft.Azure.Commands.ResourceManager.Cmdlets.Utilities
{
    internal static class BicepUtility
    {
        public static bool IsBicepExecutable { get; private set; } = false;

        public static string MinimalVersionRequirement = "0.3.1";

        public static bool IsBicepFile(string templateFilePath)
        {
            return ".bicep".Equals(Path.GetExtension(templateFilePath), System.StringComparison.OrdinalIgnoreCase);
        }

        public delegate List<T> ScriptExecutor<T>(string script);

        public static bool CheckBicepExecutable<T>(ScriptExecutor<T> executeScript)
        {
            try
            {
                executeScript("get-command bicep");
            }
            catch
            {
                IsBicepExecutable = false;
                return IsBicepExecutable;
            }
            IsBicepExecutable = true;
            return IsBicepExecutable;
        }

        private static bool CheckMinimalVersionRequirement(string checkMinumVersionRequirement)
        {

            if (Version.Parse(checkMinumVersionRequirement).CompareTo(Version.Parse(GetBicepVesion())) > 0)
            {
                throw new AzPSApplicationException(string.Format(Properties.Resources.BicepVersionRequirement, checkMinumVersionRequirement));
            };
            return true;
        }

        public static string GetBicepVesion()
        {
            System.Management.Automation.PowerShell powershell = System.Management.Automation.PowerShell.Create();
            powershell.AddScript("bicep -v");
            var result = powershell.Invoke()[0].ToString();
            Regex pattern = new Regex("\\d+(\\.\\d+)+");
            string bicepVersion = pattern.Match(result)?.Value;
            return bicepVersion;
        }

        public static string BuildFile<T>(ScriptExecutor<T> executeScript, string bicepTemplateFilePath)
        {
            if (!IsBicepExecutable && !CheckBicepExecutable(executeScript))
            {
                throw new AzPSApplicationException(Properties.Resources.BicepNotFound);
            }

            CheckMinimalVersionRequirement(MinimalVersionRequirement);

            string tempDirectory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDirectory);

            if (FileUtilities.DataStore.FileExists(bicepTemplateFilePath))
            {
                System.Management.Automation.PowerShell powershell = System.Management.Automation.PowerShell.Create();
                powershell.AddScript($"bicep build '{bicepTemplateFilePath}' --outdir '{tempDirectory}'");
                powershell.Invoke();
                if (powershell.HadErrors)
                {
                    string errorMsg = string.Empty;
                    powershell.Streams.Error.ForEach(e => { errorMsg += (e + Environment.NewLine); });
                    throw new AzPSApplicationException(errorMsg);
                }
            }
            else
            {
                throw new AzPSArgumentException(Properties.Resources.InvalidBicepFilePath, "TemplateFile");
            }

            return Path.Combine(tempDirectory, Path.GetFileName(bicepTemplateFilePath)).Replace(".bicep", ".json");
        }
    }
}
