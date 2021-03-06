// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Action and its trigger that will be performed by Key Vault over the
    /// lifetime of a certificate.
    /// </summary>
    public partial class LifetimeAction
    {
        /// <summary>
        /// Initializes a new instance of the LifetimeAction class.
        /// </summary>
        public LifetimeAction() { }

        /// <summary>
        /// Initializes a new instance of the LifetimeAction class.
        /// </summary>
        /// <param name="trigger">The condition that will execute the
        /// action.</param>
        /// <param name="action">The action that will be executed.</param>
        public LifetimeAction(Trigger trigger = default(Trigger), Action action = default(Action))
        {
            Trigger = trigger;
            Action = action;
        }

        /// <summary>
        /// Gets or sets the condition that will execute the action.
        /// </summary>
        [JsonProperty(PropertyName = "trigger")]
        public Trigger Trigger { get; set; }

        /// <summary>
        /// Gets or sets the action that will be executed.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public Action Action { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Trigger != null)
            {
                this.Trigger.Validate();
            }
        }
    }
}
