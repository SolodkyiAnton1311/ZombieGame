using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : ObjectHealth
{
    [SerializeField] private Image healthSlider;
     private GameManager gameManager;
    void Start()
    {
        baseObject = GetComponent<BaseObject>();
        currentHealth = baseObject.movableObject.maxHealth;
        gameManager = GameManager.Instance;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthSlider.fillAmount = currentHealth/100;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        gameManager.GameOver();
    }
}