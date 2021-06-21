using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform gameObj;
    public GameObject level;

    private void OnTriggerEnter(Collider collider)
    {
        
        Instantiate(level,gameObj.transform.position, Quaternion.identity);
        Destroy(level, 10f);
    }
}
