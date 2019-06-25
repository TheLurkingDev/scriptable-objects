﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private FloatVariable _hitPoints;

        private void Start()
        {
            Debug.Log("Player hitpoints: " + _hitPoints.Value.ToString());
        }
    }
}