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
using System.Linq;

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    /// <summary>
    /// Highlight details.
    /// </summary>
    public partial class Highlight
    {
        private string _post;
        
        /// <summary>
        /// Optional. Gets or sets the post string.
        /// </summary>
        public string Post
        {
            get { return this._post; }
            set { this._post = value; }
        }
        
        private string _pre;
        
        /// <summary>
        /// Optional. Gets or sets the pre string.
        /// </summary>
        public string Pre
        {
            get { return this._pre; }
            set { this._pre = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Highlight class.
        /// </summary>
        public Highlight()
        {
        }
    }
}
