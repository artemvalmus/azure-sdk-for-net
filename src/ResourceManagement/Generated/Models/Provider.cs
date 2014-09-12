// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Management.Resources.Models;

namespace Microsoft.Azure.Management.Resources.Models
{
    /// <summary>
    /// Resource provider information.
    /// </summary>
    public partial class Provider
    {
        private string _id;
        
        /// <summary>
        /// Optional. Gets or sets the provider id.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _namespace;
        
        /// <summary>
        /// Optional. Gets or sets the namespace of the provider.
        /// </summary>
        public string Namespace
        {
            get { return this._namespace; }
            set { this._namespace = value; }
        }
        
        private string _registrationState;
        
        /// <summary>
        /// Optional. Gets or sets the registration state of the provider.
        /// </summary>
        public string RegistrationState
        {
            get { return this._registrationState; }
            set { this._registrationState = value; }
        }
        
        private IList<ProviderResourceType> _resourceTypes;
        
        /// <summary>
        /// Optional. Gets or sets the collection of provider resource types.
        /// </summary>
        public IList<ProviderResourceType> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Provider class.
        /// </summary>
        public Provider()
        {
            this.ResourceTypes = new List<ProviderResourceType>();
        }
    }
}
