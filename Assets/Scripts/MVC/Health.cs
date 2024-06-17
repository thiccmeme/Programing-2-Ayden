using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.Ayden.namespaces.MVC
{
    public class Health : MonoBehaviour
    {
        /// <summary>
        /// Invokes when the health value is updated
        /// first value is current health
        /// last value is max health
        /// </summary>
        public event Action<int, int> OnHealthUpdated;

        private int _currentHealth;
        private const int minHealth = 0;
        private const int maxHealth = 100;
        

        public void Increment(int amount)
        {
            _currentHealth += amount;
            _currentHealth = Mathf.Clamp(_currentHealth, minHealth, maxHealth);
            UpdateHealth();
        }

        public void Decrement(int amount)
        {
            _currentHealth -= amount;
            _currentHealth = Mathf.Clamp(_currentHealth, minHealth, maxHealth);
            UpdateHealth();
        }

        public void Restore()
        {
            _currentHealth = maxHealth;
            UpdateHealth();
        }

        private void UpdateHealth()
        {
            OnHealthUpdated?.Invoke(_currentHealth, maxHealth);
        }

        public void Start()
        {
            Restore();
        }

    }
}
