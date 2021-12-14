// Copyright (c) 2021 Koji Hasegawa.
// This software is released under the MIT License.

using UnityEngine.Scripting;

namespace InliningExample
{
    [Preserve]
    public class NoDivideCalculator : ICalculator
    {
        public int Calculate(int count)
        {
            var sum = 0;
            for (var i = 0; i < count; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}
