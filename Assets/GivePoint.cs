using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GivePoint : MonoBehaviour
{
    // Start is called before the first frame update\
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            GameSystem.Instance.TargetDestroyed(100);
        }
    }
}
