using UnityEngine;
using Sirenix.OdinInspector;

public class TriggerBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Scores.BallLeft++;
            Destroy(other.gameObject);
        }
    }
}
