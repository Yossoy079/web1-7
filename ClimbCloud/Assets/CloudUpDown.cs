using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudUpDown : MonoBehaviour {
    Vector3 myPosition;

    // Use this for initialization
    void Start()
    {
        myPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(myPosition.x, Mathf.PingPong(Time.time, myPosition.y + 3), myPosition.z);
    }
}
