using UnityEngine;

public class ObjectSpawner : IObjectSpawner
{
    private GameObject prefab;
    private Vector3 spawnPosition;

    public ObjectSpawner(GameObject prefab, Vector3 position)
    {
        this.prefab = prefab;
        this.spawnPosition = position;
    }

    public GameObject SpawnObject()
    {
        return Object.Instantiate(prefab, spawnPosition, Quaternion.identity);
    }
}