﻿//
//  Copyright (c) Microsoft Corporation. All rights reserved.
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//

namespace Microsoft.PackageManagement.NuGetProvider
{
    /// <summary>
    /// Output using the inner NuGetRequest object.
    /// </summary>
    internal class NuGetRequestOutput : IRequestOutput
    {
        private NuGetRequest internalRequest;
        public NuGetRequestOutput(NuGetRequest request)
        {
            this.internalRequest = request;
        }

        public void Debug(string msg, params object[] args)
        {
            this.internalRequest.Debug(msg, args);
        }

        public void Verbose(string msg, params object[] args)
        {
            this.internalRequest.Verbose(msg, args);
        }

        public void Warning(string msg, params object[] args)
        {
            this.internalRequest.Warning(msg, args);
        }
    }
}
