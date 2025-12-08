using UnityEngine;
using Sirenix.OdinInspector;

public class SpawnerBehaviour : MonoBehaviour
{
    [SerializeField, Required] private GameObject prefabToSpawn;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnPrefab();
        }
    }

    void SpawnPrefab()
    {
        float spawnX = Random.Range(-20f, 20f);
        if (Scores.BallLeft > 0)
        {
            Instantiate(prefabToSpawn, new Vector3(spawnX, transform.position.y, transform.position.z), Quaternion.identity);
            Scores.BallLeft--;
        }
        else
        {
            Debug.Log("No more balls left to spawn!");
            //Todo : game over logic
        }
    }
}
