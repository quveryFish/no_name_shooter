using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletLifeTime;

    private void Update()
    {
        BulletLife();
    }

    private void BulletLife()
    {
        bulletLifeTime -= Time.deltaTime;
        if (bulletLifeTime < 0)
        {
            Destroy(gameObject);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("dfgjkdfg");
        Destroy(gameObject);

    }
}
