using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public GameObject capsulePrefab;

    public void SpawnCube() => SpawnObject(cubePrefab);
    public void SpawnSphere() => SpawnObject(spherePrefab);
    public void SpawnCapsule() => SpawnObject(capsulePrefab);

    private void SpawnObject(GameObject prefab)
    {
        IObjectSpawner spawner = new ObjectSpawner(prefab, RandomPosition());
        GameObject obj = spawner.SpawnObject();
    }

    private Vector3 RandomPosition()
    {
        return new Vector3(Random.Range(-5, 5), 1, Random.Range(-5, 5));
    }
}