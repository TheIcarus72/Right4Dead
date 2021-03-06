﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Completed
{
    [Serializable]
    public class Stat {

        [SerializeField]
        private Bars bar;
        private float maxVal = 150;
        private float currentVal = 150;

        public void Start()
        {

        }

        public float CurrentVal
        {
            get
            {
                return currentVal;
            }

            set
            {

                currentVal = value;
                bar.Value = currentVal;
            }
        }

        public float MaxVal
        {
            get
            {
                return maxVal;
            }

            set
            {
                maxVal = value;
                bar.MaxValue = maxVal;
            }
        }

        public void Initialize()
        {
            this.MaxVal = maxVal;
            this.CurrentVal = currentVal;
        }
    }
}
