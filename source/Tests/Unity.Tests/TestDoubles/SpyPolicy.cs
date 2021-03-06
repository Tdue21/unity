﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using ObjectBuilder2;

namespace Unity.Tests.TestDoubles
{
    /// <summary>
    /// A sample policy that gets used by the SpyStrategy
    /// if present to mark execution.
    /// </summary>
    internal class SpyPolicy : IBuilderPolicy
    {
        private bool wasSpiedOn;

        public bool WasSpiedOn
        {
            get { return wasSpiedOn; }
            set { wasSpiedOn = value; }
        }
    }
}
