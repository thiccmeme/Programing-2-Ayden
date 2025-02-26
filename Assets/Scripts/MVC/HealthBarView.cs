using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace com.Ayden.namespaces.MVC
{
    public class Healthbar : MonoBehaviour
    {
        [SerializeField] private Health health;
        [SerializeField] private Image imgHealthBar;

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
            imgHealthBar.fillAmount = (float)currentHealth / (float)maxHealth;
        }
    }
}
