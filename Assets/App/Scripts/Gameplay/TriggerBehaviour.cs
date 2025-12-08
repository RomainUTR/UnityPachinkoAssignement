using UnityEngine;
using Sirenix.OdinInspector;

public class TriggerBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            if (gameObject.CompareTag("RespawnTrigger"))
            {
                Scores.ballLeft++;
                Scores.ballsInAction--;
                Destroy(other.gameObject);
            }
            else if (gameObject.CompareTag("ClearTrigger"))
            {
                Scores.ballsInAction--;
                Destroy(other.gameObject);
            }
        }
    }
}
