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
using System;
using System.Net;
using System.Collections.Generic;
using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

using Amazon.S3.Util;
using System.Globalization;
using Amazon.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for GetObject operation
    /// </summary>
    public class GetObjectResponseUnmarshaller : S3ReponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {   
            GetObjectResponse response = new GetObjectResponse();
            
            UnmarshallResult(context,response);                        
                 
                        
            return response;
        }
        
        private static void UnmarshallResult(XmlUnmarshallerContext context,GetObjectResponse response)
        {

            response.ResponseStream = context.Stream;
                            
            IWebResponseData responseData = context.ResponseData;
            if (responseData.IsHeaderPresent("x-amz-delete-marker"))
                response.DeleteMarker = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-delete-marker"));
            if (responseData.IsHeaderPresent("accept-ranges"))
                response.AcceptRanges = S3Transforms.ToString(responseData.GetHeaderValue("accept-ranges"));
            if (responseData.IsHeaderPresent("x-amz-expiration"))
                response.Expiration = new Expiration(responseData.GetHeaderValue("x-amz-expiration"));
            if (responseData.IsHeaderPresent("x-amz-restore"))
            {
                bool restoreInProgress;
                DateTime? restoreExpiration;
                AmazonS3Util.ParseAmzRestoreHeader(responseData.GetHeaderValue("x-amz-restore"), out restoreInProgress, out restoreExpiration);

                response.RestoreInProgress = restoreInProgress;
                response.RestoreExpiration = restoreExpiration;
            }
            if (responseData.IsHeaderPresent("Last-Modified"))
                response.LastModified = S3Transforms.ToDateTime(responseData.GetHeaderValue("Last-Modified"));
            if (responseData.IsHeaderPresent("ETag"))
                response.ETag = S3Transforms.ToString(responseData.GetHeaderValue("ETag"));
            if (responseData.IsHeaderPresent("x-amz-missing-meta"))
                response.MissingMeta = S3Transforms.ToInt(responseData.GetHeaderValue("x-amz-missing-meta"));
            if (responseData.IsHeaderPresent("x-amz-version-id"))
                response.VersionId = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-version-id"));
            if (responseData.IsHeaderPresent("Cache-Control"))
                response.Headers.CacheControl = S3Transforms.ToString(responseData.GetHeaderValue("Cache-Control"));
            if (responseData.IsHeaderPresent("Content-Disposition"))
                response.Headers.ContentDisposition = S3Transforms.ToString(responseData.GetHeaderValue("Content-Disposition"));
            if (responseData.IsHeaderPresent("Content-Encoding"))
                response.Headers.ContentEncoding = S3Transforms.ToString(responseData.GetHeaderValue("Content-Encoding"));
            if (responseData.IsHeaderPresent("Content-Length"))
                response.Headers.ContentLength = long.Parse(responseData.GetHeaderValue("Content-Length"), CultureInfo.InvariantCulture);
            if (responseData.IsHeaderPresent("Content-Type"))
                response.Headers.ContentType = S3Transforms.ToString(responseData.GetHeaderValue("Content-Type"));
            if (responseData.IsHeaderPresent("Expires"))
                response.Expires = S3Transforms.ToDateTime(responseData.GetHeaderValue("Expires"));
            if (responseData.IsHeaderPresent("x-amz-website-redirect-location"))
                response.WebsiteRedirectLocation = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-website-redirect-location"));
            if (responseData.IsHeaderPresent("x-amz-server-side-encryption"))
                response.ServerSideEncryptionMethod = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-server-side-encryption"));
            if (responseData.IsHeaderPresent("x-amz-server-side-encryption-customer-algorithm"))
                response.ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.FindValue(responseData.GetHeaderValue("x-amz-server-side-encryption-customer-algorithm"));
            if (responseData.IsHeaderPresent(HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader))
                response.ServerSideEncryptionKeyManagementServiceKeyId = S3Transforms.ToString(responseData.GetHeaderValue(HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader));
            if (responseData.IsHeaderPresent("x-amz-replication-status"))
                response.ReplicationStatus = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-replication-status"));
            if (responseData.IsHeaderPresent(HeaderKeys.XAmzStorageClassHeader))
                response.StorageClass = S3Transforms.ToString(responseData.GetHeaderValue(HeaderKeys.XAmzStorageClassHeader));

            foreach (var name in responseData.GetHeaderNames())
            {
                if (name.StartsWith("x-amz-meta-", StringComparison.OrdinalIgnoreCase))
                    response.Metadata[name] = responseData.GetHeaderValue(name);
            }

            return;
        }
        
        public override bool HasStreamingProperty
        {
           get { return true;}
        }

        private static GetObjectResponseUnmarshaller _instance;

        public static GetObjectResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GetObjectResponseUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
