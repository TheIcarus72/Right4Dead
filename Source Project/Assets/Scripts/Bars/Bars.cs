﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Completed
{
    public class Bars : MonoBehaviour {

        [SerializeField]
        private float fillAmount;
        [SerializeField]
        private Image content;
        public float MaxValue { get; set; }


        public float Value
        {
            set
            {
           		//fillAmount = Map(value, 0, MaxValue, 0, 1);
				fillAmount = fill (value, MaxValue);
				Debug.Log (value + " " + MaxValue);
            }

        }



        void Update()
        {
            HandleBar();
    
        }
        
        private void HandleBar()
        {
            content.fillAmount = fillAmount;
        }

        private float Map(float value, float inMin, float inMax, float outMin, float outMax)
        {
            return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
        }

		private float fill(float value, float max)
		{
			return value / max;
		}

    }
}
