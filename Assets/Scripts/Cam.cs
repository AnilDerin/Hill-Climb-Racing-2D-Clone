using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public Transform target;
    public Vector3 target_offset;


    // Start is called before the first frame update
    void Start()
    {
        target_offset = transform.position - target.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.position = new Vector3(target.position.x + target_offset.x, target.position.y + target_offset.y, transform.position.z);
    }
}
