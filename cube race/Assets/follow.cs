using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform p;
    public Vector3 offsetc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(p.position.x + offsetc.x, p.position.y + offsetc.y, p.position.z + offsetc.z);
    }
}
