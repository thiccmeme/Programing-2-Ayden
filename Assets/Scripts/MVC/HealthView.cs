using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace com.Ayden.namespaces.MVC
{
    public class HealthView : MonoBehaviour
    {

        [SerializeField] private Health health;
        [SerializeField] private TMP_Text txtHealth;

        private void OnEnable()
        {
            health.OnHealthUpdated += UpdateHealthView;
        }

        private void OnDisable()
        {
            health.OnHealthUpdated -= UpdateHealthView;
        }

        private void UpdateHealthView(int currentHealth, int maxHealth)
        {
            txtHealth.SetText($"HP {currentHealth} / {maxHealth}");
        }
    }
}
