using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace com.Ayden.namespaces.MVC
{
    public class HealthEventTrigger : MonoBehaviour
    {
        [SerializeField] private Health health;

        public UnityEvent OnHealthUpdatedDefault;

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
            OnHealthUpdatedDefault?.Invoke();
        }
    }
}
