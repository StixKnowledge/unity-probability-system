using UnityEngine;

public class ProbabiltySystem : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject platformPrefab;
    public GameObject obstaclePlatformPrefab;

    [Header("Probability Settings")]
    [Range(0, 100)]
    [Tooltip("Percentage chance to spawn an obstacle platform (e.g., 20 means 20% Obstacle, 80% Normal)")]
    public float obstacleProbability = 20f;

    //SAMPLE USAGE
    void SpawnPlatform()
    {
        // --- PROBABILITY LOGIC ---
        GameObject prefabToSpawn;
        float roll = Random.Range(0f, 100f);

        if (roll < obstacleProbability)
        {
            // Success! Spawn the rare/harder platform
            prefabToSpawn = obstaclePlatformPrefab;
        }
        else
        {
            // Default: Spawn the normal platform
            prefabToSpawn = platformPrefab;
        }
        Instantiate(prefabToSpawn, Vector(0, 0), Quaternion.identity);
    }
}