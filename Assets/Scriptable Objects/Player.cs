using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private FloatVariable _hitPoints; // Obtained by UI reference. Is this the best way?

        /// <summary>
        /// The value of the ScriptableObject is persisted not only between scenes,
        /// but also between game sessions. So when the value is incremented here,
        /// the next time the game is run the incrmented value will be the initial value.
        /// </summary>
        private void Start()
        {
            Debug.Log("Player hitpoints before increment: " + _hitPoints.Value.ToString());
            _hitPoints.Value += 2f;
            Debug.Log("Player hitpoints after increment: " + _hitPoints.Value.ToString());
        }
    }
}
