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

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Parameters supplied to the Update Hosted Service operation.
    /// </summary>
    public partial class HostedServiceUpdateParameters
    {
        private string _description;
        
        /// <summary>
        /// Optional. A description for the cloud service. The description may
        /// be up to 1024 characters in length. You must specify a value for
        /// at least one of Label or Description.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private IDictionary<string, string> _extendedProperties;
        
        /// <summary>
        /// Optional. Represents the name of an extended cloud service
        /// property. Each extended property must have a defined name and a
        /// value. You can have a maximum of 50 extended property name and
        /// value pairs. The maximum length of the name element is 64
        /// characters, only alphanumeric characters and underscores are valid
        /// in the name, and it must start with a letter. Attempting to use
        /// other characters, starting with a non-letter character, or
        /// entering a name that is identical to that of another extended
        /// property owned by the same service will result in a status code
        /// 400 (Bad Request) error. Each extended property value has a
        /// maximum length of 255 characters.
        /// </summary>
        public IDictionary<string, string> ExtendedProperties
        {
            get { return this._extendedProperties; }
            set { this._extendedProperties = value; }
        }
        
        private string _label;
        
        /// <summary>
        /// Optional. A name for the cloud service. The name may be up to 100
        /// characters in length. You must specify a value for at least one of
        /// Label or Description. It is recommended that the label be unique
        /// within the subscription. The name can be used identify the service
        /// for your tracking purposes.
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }
        
        private string _reverseDnsFqdn;
        
        /// <summary>
        /// Optional. Dns address to which the cloud service's IP address
        /// resolves when queried using a reverse Dns query.
        /// </summary>
        public string ReverseDnsFqdn
        {
            get { return this._reverseDnsFqdn; }
            set { this._reverseDnsFqdn = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the HostedServiceUpdateParameters
        /// class.
        /// </summary>
        public HostedServiceUpdateParameters()
        {
            this.ExtendedProperties = new Dictionary<string, string>();
        }
    }
}
