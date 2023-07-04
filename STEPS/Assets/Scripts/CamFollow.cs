using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //camera goes to target's position in  x and y  axes
        //camera  stays in position at axis z
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);

    }
}
