// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights.Models
{

    /// <summary>
    /// Defines values for ComparisonOperationType.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ComparisonOperationType
    {
        [System.Runtime.Serialization.EnumMember(Value = "Equals")]
        Equals,
        [System.Runtime.Serialization.EnumMember(Value = "NotEquals")]
        NotEquals,
        [System.Runtime.Serialization.EnumMember(Value = "GreaterThan")]
        GreaterThan,
        [System.Runtime.Serialization.EnumMember(Value = "GreaterThanOrEqual")]
        GreaterThanOrEqual,
        [System.Runtime.Serialization.EnumMember(Value = "LessThan")]
        LessThan,
        [System.Runtime.Serialization.EnumMember(Value = "LessThanOrEqual")]
        LessThanOrEqual
    }
}
