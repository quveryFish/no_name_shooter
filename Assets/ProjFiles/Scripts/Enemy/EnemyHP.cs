using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public static EnemyHP instance;
    private float enemyHP = 50;
    public void TakeDamage(float damage)
    {
        enemyHP -= damage;
        if (enemyHP <= 0)
        {
            Destroy(gameObject);
        }
    }
    
}
