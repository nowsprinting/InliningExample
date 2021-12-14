// Copyright (c) 2021 Koji Hasegawa.
// This software is released under the MIT License.

using DefaultNamespace;
using UnityEngine.Scripting;

namespace InliningExample
{
    [Preserve]
    public class CallAggressiveInliningMethod : ICalculator
    {
        public int Calculate(int count)
        {
            var sum = 0;
            for (var i = 0; i < count; i++)
            {
                sum += AggressiveInlining.DividedMethod(i);
            }

            return sum;
        }
    }
}
