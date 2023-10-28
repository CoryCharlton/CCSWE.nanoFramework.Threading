﻿//
// Copyright (c) .NET Foundation and Contributors
// Portions Copyright (c) Microsoft Corporation.  All rights reserved.
// See LICENSE file in the project root for full license information.
//

namespace CCSWE.nanoFramework.Threading.Internal
{
    internal readonly struct WorkItem
    {
        // TODO: I think I want to turn this into an Action and remove the state
        public readonly WaitCallback CallBack;
        public readonly object? State;

        public WorkItem(WaitCallback callBack, object? state)
        {
            CallBack = callBack;
            State = state;
        }
    }
}
