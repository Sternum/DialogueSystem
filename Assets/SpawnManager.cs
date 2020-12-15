using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject cubePrefab;

    public void OnSpawn()
    {
        Instantiate(cubePrefab, transform);
    }
}
