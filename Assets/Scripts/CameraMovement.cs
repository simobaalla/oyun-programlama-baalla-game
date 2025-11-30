using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CameraMovement : MonoBehaviour
{
    public float cameraSp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(cameraSp * Time.deltaTime, 0, 0);
    }
}
