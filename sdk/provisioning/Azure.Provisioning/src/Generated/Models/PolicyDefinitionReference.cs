// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Resources;

/// <summary>
/// The policy definition reference.
/// </summary>
public partial class PolicyDefinitionReference : ProvisionableConstruct
{
    /// <summary>
    /// The ID of the policy definition or policy set definition.
    /// </summary>
    public BicepValue<string> PolicyDefinitionId 
    {
        get { Initialize(); return _policyDefinitionId!; }
        set { Initialize(); _policyDefinitionId!.Assign(value); }
    }
    private BicepValue<string>? _policyDefinitionId;

    /// <summary>
    /// The parameter values for the referenced policy rule. The keys are the
    /// parameter names.
    /// </summary>
    public BicepDictionary<ArmPolicyParameterValue> Parameters 
    {
        get { Initialize(); return _parameters!; }
        set { Initialize(); _parameters!.Assign(value); }
    }
    private BicepDictionary<ArmPolicyParameterValue>? _parameters;

    /// <summary>
    /// A unique id (within the policy set definition) for this policy
    /// definition reference.
    /// </summary>
    public BicepValue<string> PolicyDefinitionReferenceId 
    {
        get { Initialize(); return _policyDefinitionReferenceId!; }
        set { Initialize(); _policyDefinitionReferenceId!.Assign(value); }
    }
    private BicepValue<string>? _policyDefinitionReferenceId;

    /// <summary>
    /// The name of the groups that this policy definition reference belongs to.
    /// </summary>
    public BicepList<string> GroupNames 
    {
        get { Initialize(); return _groupNames!; }
        set { Initialize(); _groupNames!.Assign(value); }
    }
    private BicepList<string>? _groupNames;

    /// <summary>
    /// Creates a new PolicyDefinitionReference.
    /// </summary>
    public PolicyDefinitionReference()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of PolicyDefinitionReference.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _policyDefinitionId = DefineProperty<string>("PolicyDefinitionId", ["policyDefinitionId"]);
        _parameters = DefineDictionaryProperty<ArmPolicyParameterValue>("Parameters", ["parameters"]);
        _policyDefinitionReferenceId = DefineProperty<string>("PolicyDefinitionReferenceId", ["policyDefinitionReferenceId"]);
        _groupNames = DefineListProperty<string>("GroupNames", ["groupNames"]);
    }
}
