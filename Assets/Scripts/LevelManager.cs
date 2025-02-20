using UnityEngine;
using System.Collections; // Required for IEnumerator

public class LevelManager : MonoBehaviour
{
    // Static instance for singleton pattern
    public static LevelManager main;

    // Array of transforms to hold the spawn points
    public Transform[] SpawnPoints;

    // Prefab for the enemy to spawn
    public GameObject enemyPrefab;

    // Time interval between spawns in seconds
    public float spawnInterval = 5f;

    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        // Assign the instance to main
        main = this;
    }

    // Start is called before the first frame update
    private void Start()
    {
        // Start the coroutine to spawn enemies
        StartCoroutine(SpawnEnemies());
    }

    // Coroutine to handle enemy spawning
    private IEnumerator SpawnEnemies()
    {
        // Infinite loop to keep spawning enemies
        while (true)
        {
            // Wait for the defined interval before spawning next enemy
            yield return new WaitForSeconds(spawnInterval);

            // Select a random spawn point from the array
            int spawnIndex = Random.Range(1, SpawnPoints.Length);
            Transform spawnPoint = SpawnPoints[spawnIndex];

            // Instantiate the enemy prefab at the selected spawn point's position and rotation
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}

