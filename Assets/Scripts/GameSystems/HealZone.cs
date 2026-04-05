using UnityEngine;

public class HealZone : MonoBehaviour
{
    public int healPerTick = 10;
    public float tickRate = 1f;

    private float timer;
    PlayerHealth health;
    private void OnTriggerStay(Collider other)
    {
        if(health == null)
        {
            health = other.GetComponent<PlayerHealth>();
        }
        else if(health != null && other.gameObject != health.gameObject)
        {
            health = other.GetComponent<PlayerHealth>();
        }

        if (health == null) return;

        timer += Time.deltaTime;

        if (timer >= tickRate)
        {
            health.Heal(healPerTick);
            timer = 0f;
        }
    }
}