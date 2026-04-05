using UnityEngine;

public class DamageZone : MonoBehaviour
{
    public int damagePerTick = 10;
    public float tickRate = 1f;

    private float timer;
    PlayerHealth health;
    private void OnTriggerStay(Collider other)
    {
        if (health == null)
        {
            health = other.GetComponent<PlayerHealth>();
        }
        else if (health != null && other.gameObject != health.gameObject)
        {
            health = other.GetComponent<PlayerHealth>();
        }

        if (health == null) return;

        timer += Time.deltaTime;

        if (timer >= tickRate)
        {
            health.TakeDamage(damagePerTick);
            timer = 0f;
        }
    }
}