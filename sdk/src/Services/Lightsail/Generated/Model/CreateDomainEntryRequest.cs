/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDomainEntry operation.
    /// Creates one of the following entry records associated with the domain: Address (A),
    /// canonical name (CNAME), mail exchanger (MX), name server (NS), start of authority
    /// (SOA), service locator (SRV), or text (TXT).
    /// 
    ///  
    /// <para>
    /// The <code>create domain entry</code> operation supports tag-based access control via
    /// resource tags applied to the resource identified by domainName. For more information,
    /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
    /// Dev Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateDomainEntryRequest : AmazonLightsailRequest
    {
        private DomainEntry _domainEntry;
        private string _domainName;

        /// <summary>
        /// Gets and sets the property DomainEntry. 
        /// <para>
        /// An array of key-value pairs containing information about the domain entry request.
        /// </para>
        /// </summary>
        public DomainEntry DomainEntry
        {
            get { return this._domainEntry; }
            set { this._domainEntry = value; }
        }

        // Check to see if DomainEntry property is set
        internal bool IsSetDomainEntry()
        {
            return this._domainEntry != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name (e.g., <code>example.com</code>) for which you want to create the
        /// domain entry.
        /// </para>
        /// </summary>
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

    }
}