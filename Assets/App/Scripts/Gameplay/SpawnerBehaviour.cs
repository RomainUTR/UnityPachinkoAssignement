using UnityEngine;
using Sirenix.OdinInspector;

public class SpawnerBehaviour : MonoBehaviour
{
    [SerializeField, Required] private GameObject prefabToSpawn;
    [SerializeField, Required] private GameObject menuManager;

    private int ballsInAction = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnPrefab();
        }
    }

    void SpawnPrefab()
    {
        if (!Scores.isGameEnded)
        {
            float spawnX = Random.Range(-19f, 19f);
            Debug.Log("Ball in action: " + Scores.ballsInAction);
            if (Scores.ballLeft > 0)
            {
                Instantiate(prefabToSpawn, new Vector3(spawnX, transform.position.y, transform.position.z), Quaternion.identity);
                Scores.ballLeft--;
                Scores.ballsInAction++;
            }
            if (Scores.ballLeft <= 0 && Scores.ballsInAction == 0)
            {
                Debug.Log("Game Over!");
                menuManager.GetComponent<MenuManager>().GameOverMenu();
            }
        }
    }
}
