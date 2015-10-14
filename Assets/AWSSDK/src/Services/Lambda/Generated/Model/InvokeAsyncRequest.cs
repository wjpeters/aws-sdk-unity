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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the InvokeAsync operation.
    /// <important>This API is deprecated. We recommend you use <code>Invoke</code> API (see
    /// <a>Invoke</a>).</important> 
    /// <para>
    /// Submits an invocation request to AWS Lambda. Upon receiving the request, Lambda executes
    /// the specified function asynchronously. To see the logs generated by the Lambda function
    /// execution, see the CloudWatch logs console.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permission for the <code>lambda:InvokeFunction</code> action.
    /// </para>
    /// </summary>
    public partial class InvokeAsyncRequest : AmazonLambdaRequest
    {
        private string _functionName;
        private Stream _invokeArgsStream;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The Lambda function name.
        /// </para>
        /// </summary>
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property InvokeArgsStream. 
        /// <para>
        /// JSON that you want to provide to your Lambda function as input.
        /// </para>
        /// </summary>
        public Stream InvokeArgsStream
        {
            get { return this._invokeArgsStream; }
            set { this._invokeArgsStream = value; }
        }

        // Check to see if InvokeArgsStream property is set
        internal bool IsSetInvokeArgsStream()
        {
            return this._invokeArgsStream != null;
        }

    }
}