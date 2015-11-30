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
using Microsoft.Azure.Management.OperationalInsights.Models;

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    /// <summary>
    /// Parameters specifying the search query and range.
    /// </summary>
    public partial class SearchGetSearchResultParameters
    {
        private System.DateTime? _end;
        
        /// <summary>
        /// Optional. Gets or sets the end date.
        /// </summary>
        public System.DateTime? End
        {
            get { return this._end; }
            set { this._end = value; }
        }
        
        private Facet _facet;
        
        /// <summary>
        /// Optional. Gets or sets the facet details.
        /// </summary>
        public Facet Facet
        {
            get { return this._facet; }
            set { this._facet = value; }
        }
        
        private Highlight _highlight;
        
        /// <summary>
        /// Optional. Gets or sets the highlight.
        /// </summary>
        public Highlight Highlight
        {
            get { return this._highlight; }
            set { this._highlight = value; }
        }
        
        private bool _includeArchive;
        
        /// <summary>
        /// Optional. Gets or sets the include archive boolean.
        /// </summary>
        public bool IncludeArchive
        {
            get { return this._includeArchive; }
            set { this._includeArchive = value; }
        }
        
        private string _query;
        
        /// <summary>
        /// Optional. Gets or sets the query to search.
        /// </summary>
        public string Query
        {
            get { return this._query; }
            set { this._query = value; }
        }
        
        private int _skip;
        
        /// <summary>
        /// Optional. Gets or sets the number to skip.
        /// </summary>
        public int Skip
        {
            get { return this._skip; }
            set { this._skip = value; }
        }
        
        private System.DateTime? _start;
        
        /// <summary>
        /// Optional. Gets or sets the start date.
        /// </summary>
        public System.DateTime? Start
        {
            get { return this._start; }
            set { this._start = value; }
        }
        
        private int _top;
        
        /// <summary>
        /// Optional. Gets or sets the number to get from the top.
        /// </summary>
        public int Top
        {
            get { return this._top; }
            set { this._top = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SearchGetSearchResultParameters
        /// class.
        /// </summary>
        public SearchGetSearchResultParameters()
        {
        }
    }
}
