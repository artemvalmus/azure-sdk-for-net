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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure.Management.Sql.Models
{
    /// <summary>
    /// Contains the response to the List Restorable Dropped Databases request.
    /// </summary>
    public partial class RestorableDroppedDatabaseListResponse : OperationResponse, IEnumerable<RestorableDroppedDatabase>
    {
        private IList<RestorableDroppedDatabase> _databases;
        
        /// <summary>
        /// Optional. Gets or sets the collection of restorable dropped
        /// databases that has been returned from a List Restorable Dropped
        /// Databases request.
        /// </summary>
        public IList<RestorableDroppedDatabase> Databases
        {
            get { return this._databases; }
            set { this._databases = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// RestorableDroppedDatabaseListResponse class.
        /// </summary>
        public RestorableDroppedDatabaseListResponse()
        {
            this.Databases = new List<RestorableDroppedDatabase>();
        }
        
        /// <summary>
        /// Gets the sequence of Databases.
        /// </summary>
        public IEnumerator<RestorableDroppedDatabase> GetEnumerator()
        {
            return this.Databases.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of Databases.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
