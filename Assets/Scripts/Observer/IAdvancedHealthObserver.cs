public interface IAdvancedHealthObserver : IHealthObserver
{
    void OnHealthChanged(int currentHealth, int maxHealth, HealthChangeType type);
}