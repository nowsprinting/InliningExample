// Copyright (c) 2021 Koji Hasegawa.
// This software is released under the MIT License.

using UnityEngine;

namespace InliningExample
{
    public class FizzBuzzComponent : MonoBehaviour
    {
        private void Update()
        {
            Debug.Log(FizzBuzz.Answer(Time.frameCount));
        }
    }
}
