using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour, IHealthObserver
{
    public Image healthSlider;
    public PlayerHealth playerHealth;

    public float lerpSpeed = 5f;

    private float targetValue;

    private void Start()
    {
        playerHealth.AddObserver(this);
        targetValue = 1f;
    }

    private void Update()
    {
        healthSlider.fillAmount = Mathf.Lerp(
            healthSlider.fillAmount,
            targetValue,
            Time.deltaTime * lerpSpeed
        );
    }

    public void OnHealthChanged(int currentHealth, int maxHealth)
    {
        targetValue = (float)currentHealth / maxHealth;
    }

    private void OnDestroy()
    {
        playerHealth.RemoveObserver(this);
    }
}