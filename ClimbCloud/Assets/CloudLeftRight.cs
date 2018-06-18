using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudLeftRight : MonoBehaviour {
    Vector3 myPosition;

	// Use this for initialization
	void Start () {
        myPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Mathf.PingPong(Time.time, myPosition.x + 2), myPosition.y, myPosition.z);
    }
}
