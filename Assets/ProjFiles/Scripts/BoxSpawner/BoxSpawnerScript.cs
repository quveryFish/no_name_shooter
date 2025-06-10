using UnityEngine;

public class BoxSpawnerScript : MonoBehaviour
{
    private float timerToSpawnBox = 3.5f;
    private float time = 3.5f;

    [SerializeField] private GameObject boxPrefab;
    void Update()
    {
        timerToSpawnBox -= Time.deltaTime;
        if (timerToSpawnBox <= 0)
        {
            Instantiate(boxPrefab, gameObject.transform.position, Quaternion.identity);
            timerToSpawnBox = time;
        }
    }
}
