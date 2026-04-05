using UnityEngine;

public class HealthLogger : MonoBehaviour, IHealthObserver
{
    public PlayerHealth playerHealth;

    private void Start()
    {
        playerHealth.AddObserver(this);
    }

    public void OnHealthChanged(int currentHealth, int maxHealth)
    {
        Debug.Log($"Health Updated: {currentHealth}/{maxHealth}");
    }

    private void OnDestroy()
    {
        playerHealth.RemoveObserver(this);
    }
}