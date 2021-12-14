﻿// Copyright (c) 2021 Koji Hasegawa.
// This software is released under the MIT License.

using System.Runtime.CompilerServices;

namespace DefaultNamespace
{
    public static class AggressiveInlining
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int DividedMethod(int i)
        {
            return i;
        }
    }
}
