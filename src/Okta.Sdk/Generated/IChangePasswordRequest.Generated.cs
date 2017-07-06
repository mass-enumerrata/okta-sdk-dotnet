// <copyright file="IChangePasswordRequest.Generated.cs" company="Okta, Inc">
// Copyright (c) 2014-2017 Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

// Do not modify this file directly. This file was automatically generated with:
// spec.json - 0.3.0

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Okta.Sdk
{
    /// <summary>Represents a ChangePasswordRequest resource in the Okta API.</summary>
    public partial interface IChangePasswordRequest
    {
        PasswordCredential NewPassword { get; set; }

        PasswordCredential OldPassword { get; set; }

    }
}
