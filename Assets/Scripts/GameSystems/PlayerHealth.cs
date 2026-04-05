using System.Collections.Generic;
using UnityEngine;
public enum HealthChangeType
{
    Damage,
    Heal
}

public class PlayerHealth : MonoBehaviour, IHealthSubject
{
    public int maxHealth = 100;
    public int currentHealth;

    private List<IHealthObserver> observers = new List<IHealthObserver>();

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        if (currentHealth > 0)
        {
            currentHealth -= amount;
            currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

            NotifyObservers(HealthChangeType.Damage);
        }
    }

    public void Heal(int amount)
    {
        if(currentHealth < maxHealth)
        {
            currentHealth += amount;
            currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

            NotifyObservers(HealthChangeType.Heal);
        }
    }

    public void AddObserver(IHealthObserver observer)
    {
        if (!observers.Contains(observer))
            observers.Add(observer);
    }

    public void RemoveObserver(IHealthObserver observer)
    {
        if (observers.Contains(observer))
            observers.Remove(observer);
    }

    public void NotifyObservers(HealthChangeType type)
    {
        foreach (var observer in observers)
        {
            if (observer is IAdvancedHealthObserver advanced)
            {
                advanced.OnHealthChanged(currentHealth, maxHealth, type);
            }
            else
            {
                observer.OnHealthChanged(currentHealth, maxHealth);
            }
        }
    }
}