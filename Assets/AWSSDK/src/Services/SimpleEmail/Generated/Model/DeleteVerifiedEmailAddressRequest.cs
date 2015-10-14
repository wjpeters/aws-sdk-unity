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
    /// Container for the parameters to the DeleteVerifiedEmailAddress operation.
    /// Deletes the specified email address from the list of verified addresses.
    /// 
    ///  <important>The DeleteVerifiedEmailAddress action is deprecated as of the May 15,
    /// 2012 release of Domain Verification. The DeleteIdentity action is now preferred.</important>
    /// 
    /// <para>
    /// This action is throttled at one request per second.
    /// </para>
    /// </summary>
    public partial class DeleteVerifiedEmailAddressRequest : AmazonSimpleEmailServiceRequest
    {
        private string _emailAddress;

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// An email address to be removed from the list of verified addresses.
        /// </para>
        /// </summary>
        public string EmailAddress
        {
            get { return this._emailAddress; }
            set { this._emailAddress = value; }
        }

        // Check to see if EmailAddress property is set
        internal bool IsSetEmailAddress()
        {
            return this._emailAddress != null;
        }

    }
}