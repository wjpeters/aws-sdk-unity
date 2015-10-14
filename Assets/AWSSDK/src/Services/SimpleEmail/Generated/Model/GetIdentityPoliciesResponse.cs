//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//

/*
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Represents a map of policy names to policies returned from a successful <code>GetIdentityPolicies</code>
    /// request.
    /// </summary>
    public partial class GetIdentityPoliciesResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _policies = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Policies. 
        /// <para>
        /// A map of policy names to policies.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Policies
        {
            get { return this._policies; }
            set { this._policies = value; }
        }

        // Check to see if Policies property is set
        internal bool IsSetPolicies()
        {
            return this._policies != null && this._policies.Count > 0; 
        }

    }
}