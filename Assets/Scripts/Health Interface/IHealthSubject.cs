public interface IHealthSubject
{
    void AddObserver(IHealthObserver observer);
    void RemoveObserver(IHealthObserver observer);


    void NotifyObservers(HealthChangeType type); // advanced (NEW)
}