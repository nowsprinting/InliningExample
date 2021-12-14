// Copyright (c) 2021 Koji Hasegawa.
// This software is released under the MIT License.

using UnityEngine.Scripting;

namespace InliningExample
{
    [Preserve]
    public class DividedCalculator : ICalculator
    {
        private static int DividedMethod(int i)
        {
            return i;
        }

        public int Calculate(int count)
        {
            var sum = 0;
            for (var i = 0; i < count; i++)
            {
                sum += DividedMethod(i);
            }

            return sum;
        }
    }
}
