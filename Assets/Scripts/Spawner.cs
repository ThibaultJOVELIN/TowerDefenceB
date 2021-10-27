using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float _spawnTime = 0.1f;
    private float spawnTime { get { return _spawnTime; } }

    private float currentSpawnTime { get; set; } = 0;

    public GameObject _enemyPrefab = null;
    private GameObject enemyPrefabs { get { return _enemyPrefab; } }

    private void Start()
    {

    }

    private void Update()
    {
        currentSpawnTime += Time.deltaTime;
        if (currentSpawnTime >= spawnTime)
        {
            currentSpawnTime = 0;
            Vector3 randomPos = transform.position;
            randomPos.x += Random.Range(-6.0f, 6.0f);
            Instantiate(enemyPrefabs, randomPos, transform.rotation);
        }
    }
}