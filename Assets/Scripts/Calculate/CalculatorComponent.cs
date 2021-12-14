// Copyright (c) 2021 Koji Hasegawa.
// This software is released under the MIT License.

using System;
using UnityEngine;
using UnityEngine.UI;

namespace InliningExample
{
    [RequireComponent(typeof(Text))]
    public class CalculatorComponent : MonoBehaviour
    {
        [SerializeField]
        private string calculatorName;

        private ICalculator _calculatorImpl;
        private Text _textComponent;
        private const int Count = 100_000_000;

        private void Awake()
        {
            var t = Type.GetType(calculatorName);
            _calculatorImpl = (ICalculator)Activator.CreateInstance(t);
            _textComponent = gameObject.GetComponent<Text>();
        }

        private void Update()
        {
            var start = DateTime.Now;
            var i = _calculatorImpl.Calculate(Count);
            var timeSpan = DateTime.Now - start;
            _textComponent.text = $"{timeSpan.TotalMilliseconds:0.000}";
            Debug.Log(i);
        }
    }
}
