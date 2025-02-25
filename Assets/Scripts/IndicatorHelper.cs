﻿using UnityEngine;
using UnityEngine.UI;

namespace BNG
{
    /// <summary>
    /// Shows a ring at the grab point of a grabbable if within a certain distance
    /// </summary>
    public class IndicatorHelper : MonoBehaviour
    {
        public float maxShowDistance = 2f;

        Canvas canvas;
        CanvasScaler canvasScaler;
        Transform mainCam;

        bool currentValue = true;

        void Start()
        {
            mainCam = Camera.main.transform;
            canvas = GetComponent<Canvas>();
            canvasScaler = GetComponent<CanvasScaler>();
        }

        void Update()
        {
            float currentDistance = Vector3.Distance(transform.position, mainCam.position);
            bool newValue = currentDistance <= maxShowDistance;
            if (currentValue == newValue)
            {
                return;
            }

            currentValue = newValue;
            canvas.enabled = newValue;

            if (canvasScaler)
            {
                canvasScaler.enabled = newValue;
            }
        }
    }
}

