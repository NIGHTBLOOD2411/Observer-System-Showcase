using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverSystem : MonoBehaviour, IHealthObserver
{
    public PlayerHealth playerHealth;
    private bool isGameOver = false;
    public GameObject GameOverPanel;
    private void Start()
    {
        playerHealth.AddObserver(this);
        GameOverPanel.SetActive(false);
    }

    public void OnHealthChanged(int currentHealth, int maxHealth)
    {
        if (currentHealth <= 0 && !isGameOver)
        {
            isGameOver = true;

            Debug.Log("GAME OVER");
            GameOverPanel.SetActive(true);

            Time.timeScale = 0f;
        }
    }

    public void RestartGame()
    { 
    }

    private void OnDestroy()
    {
        playerHealth.RemoveObserver(this);
    }
}