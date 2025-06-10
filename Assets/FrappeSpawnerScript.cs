using UnityEngine;

public class FrappeSpawnerScript : MonoBehaviour
{

    public GameObject frappePrefab;
    public float spawnInterval;
    private float timer = 0;
    public float highestOffset;

    void Start()
    {
        spawnFrappe();
    }

    void Update()
    {
        if (timer < spawnInterval)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnFrappe();
            timer = 0;
        }
    }
    void spawnFrappe()
    {
        float lowestPoint = transform.position.y - highestOffset;
        float highestPoint = transform.position.y + highestOffset;

        Instantiate(frappePrefab, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
