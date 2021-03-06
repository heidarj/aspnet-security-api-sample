﻿/* 
*  Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license. 
*  See LICENSE in the source repository root for complete license information. 
*/

using System.Collections.Generic;

namespace MicrosoftGraph_Security_API_Sample.Models
{
    public class SubscriptionCollection
    {
        public IEnumerable<SubscriptionResultModel> Subscriptions { get; set; }
        public string Query { get; set; }
    }
}