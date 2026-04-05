using UnityEngine;

public class HealthAudio : MonoBehaviour, IAdvancedHealthObserver
{
    public AudioSource audioSource;
    public AudioClip damageClip;
    public AudioClip healClip;

    public PlayerHealth playerHealth;

    private void Start()
    {
        playerHealth.AddObserver(this);
    }

    public void OnHealthChanged(int currentHealth, int maxHealth) { }

    public void OnHealthChanged(int currentHealth, int maxHealth, HealthChangeType type)
    {
        if (type == HealthChangeType.Damage)
        {
            audioSource.PlayOneShot(damageClip);
        }
        else if (type == HealthChangeType.Heal)
            audioSource.PlayOneShot(healClip);
    }

    private void OnDestroy()
    {
        playerHealth.RemoveObserver(this);
    }
}