using UnityEngine;

public class EnemyCombatTrigger : MonoBehaviour
{
    public GameObject enemy;
    public GameManager gameManager;
    public string combatSceneName;

    private void Start()
    {
        gameManager = GameManager.Instance;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameManager.MarkEnemyForDestruction(enemy);  // Mark the enemy for destruction
            gameManager.EnterCombatScene(combatSceneName);  // Enter combat scene
        }
    }
}

