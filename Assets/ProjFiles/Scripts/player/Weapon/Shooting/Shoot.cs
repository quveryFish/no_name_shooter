using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject rocketPref;
    [SerializeField] private Transform rocketSpawnPoint;
    private float timer = 0.6f;
    [SerializeField] private float timeToSet = 0.6f;

    private Vector3 pointToMove;
    private void Start()
    {
        timer = timeToSet;

    }
    private void Update()
    {
        timer -= Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            if (timer <= 0)
            {
                toShoot();
                timer = timeToSet;
            }
        }
    }


    private void toShoot()
    {
        Quaternion rotatedRotation = rocketSpawnPoint.rotation * Quaternion.Euler(0, 90, 0);
        GameObject bullet = Instantiate(rocketPref, rocketSpawnPoint.position, rotatedRotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.linearVelocity = rocketSpawnPoint.forward * 10;
    }
}
