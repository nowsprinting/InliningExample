// Copyright (c) 2021 Koji Hasegawa.
// This software is released under the MIT License.

namespace InliningExample
{
    /// <summary>
    /// Fizz Buzz for inlining example
    /// </summary>
    public static class FizzBuzz
    {
        private static bool IsFizz(int i)
        {
            return i % 3 == 0;
        }

        private static bool IsBuzz(int i)
        {
            return i % 5 == 0;
        }

        private static bool IsFizzBuzz(int i)
        {
            return IsFizz(i) && IsBuzz(i);
        }

        public static string Answer(int i)
        {
            if (IsFizzBuzz(i)) return "Fizz Buzz";
            if (IsFizz(i)) return "Fizz";
            if (IsBuzz(i)) return "Buzz";
            return $"{i}";
        }
    }
}
