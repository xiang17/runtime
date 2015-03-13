﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class mincore
    {
        [DllImport(Libraries.CoreConsole_L2, SetLastError = true)]
        internal extern static int SetConsoleTextAttribute(IntPtr hConsoleOutput, short wAttributes);
    }
}
