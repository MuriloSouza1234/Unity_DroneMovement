using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{   
    public GameObject drone;
    private Vector3 offset = new Vector3(0, 2, -4);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
    transform.position = drone.transform.position + offset;
    }
}
