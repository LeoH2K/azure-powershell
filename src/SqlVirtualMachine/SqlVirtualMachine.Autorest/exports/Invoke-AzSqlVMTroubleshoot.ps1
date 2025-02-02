
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Starts SQL virtual machine troubleshooting.
.Description
Starts SQL virtual machine troubleshooting.
.Example
Invoke-AzSqlVMTroubleshoot -ResourceGroupName 'ResourceGroup01' -SqlVirtualMachineName 'sqlvm1' -StartTimeUtc '2023-03-15T17:10:00Z' -EndTimeUtc '2023-03-16T08:30:10Z' -TroubleshootingScenario 'UnhealthyReplica'
.Example
$sqlvm = Get-AzSqlVM -ResourceGroupName 'ResourceGroup01' -Name 'sqlvm1'
$sqlvm | Invoke-AzSqlVMTroubleshoot -StartTimeUtc '2023-03-15T17:10:00Z' -EndTimeUtc '2023-03-16T08:30:10Z' -TroubleshootingScenario 'UnhealthyReplica'

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.ISqlVirtualMachineIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlVMTroubleshooting
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <ISqlVirtualMachineIdentity>: Identity Parameter
  [AvailabilityGroupListenerName <String>]: Name of the availability group listener.
  [Id <String>]: Resource identity path
  [ResourceGroupName <String>]: Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
  [SqlVirtualMachineGroupName <String>]: Name of the SQL virtual machine group.
  [SqlVirtualMachineName <String>]: Name of the SQL virtual machine.
  [SubscriptionId <String>]: Subscription ID that identifies an Azure subscription.
.Link
https://learn.microsoft.com/powershell/module/az.sqlvirtualmachine/invoke-azsqlvmtroubleshoot
#>
function Invoke-AzSqlVMTroubleshoot {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlVMTroubleshooting])]
[CmdletBinding(DefaultParameterSetName='TroubleshootExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='TroubleshootExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Path')]
    [System.String]
    # Name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='TroubleshootExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Path')]
    [System.String]
    # Name of the SQL virtual machine.
    ${SqlVirtualMachineName},

    [Parameter(ParameterSetName='TroubleshootExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription ID that identifies an Azure subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='TroubleshootViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.ISqlVirtualMachineIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.DateTime]
    # End time in UTC timezone.
    ${EndTimeUtc},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.DateTime]
    # Start time in UTC timezone.
    ${StartTimeUtc},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.TroubleshootingScenario])]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.TroubleshootingScenario]
    # SQL VM troubleshooting scenario.
    ${TroubleshootingScenario},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # The name of the availability group
    ${UnhealthyReplicaInfoAvailabilityGroupName},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $PSVersionTable.PSVersion.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            TroubleshootExpanded = 'Az.SqlVirtualMachine.private\Invoke-AzSqlVMTroubleshoot_TroubleshootExpanded';
            TroubleshootViaIdentityExpanded = 'Az.SqlVirtualMachine.private\Invoke-AzSqlVMTroubleshoot_TroubleshootViaIdentityExpanded';
        }
        if (('TroubleshootExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
