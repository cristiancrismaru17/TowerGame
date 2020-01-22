using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DeathTrigger : MonoBehaviour
{
    // Start is called before the first frame update\
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameSystem.Instance.StopTimer();
            GameSystem.Instance.FinishRun();
            Destroy(gameObject);
        }
    }
}
