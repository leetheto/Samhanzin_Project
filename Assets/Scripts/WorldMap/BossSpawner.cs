using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    public GameObject bossPrefab;
    public Transform[] spawnPoints;

    public void SpawnBosses()
    {
        foreach (var point in spawnPoints)
        {
            Instantiate(bossPrefab, point.position, Quaternion.identity);
        }
    }
}
