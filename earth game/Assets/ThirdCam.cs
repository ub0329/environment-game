using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdCam : MonoBehaviour
{
    public GameObject target;
    public float Yoffset;
    public float Zoffset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.transform.position.x,target.transform.position.y + Yoffset,target.transform.position.z + Zoffset);
        
        transform.LookAt(target.transform);
    }
}