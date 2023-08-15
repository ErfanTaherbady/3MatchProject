using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ErfanDeveloper
{
    public class CarCode : MonoBehaviour
    {
        public CarData carData;

        private SpriteRenderer _spriteRenderer;

        private void Start()
        {
            _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
            _spriteRenderer.color = carData.color;
        }
    }
}