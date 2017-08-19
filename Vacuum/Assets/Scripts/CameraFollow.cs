using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject focus;
	// Use this for initialization
	void Start () {
        
	}
	
    void FollowObject()
    {
        if (focus == null)
            return;
        transform.position = Vector3.Lerp(transform.position, focus.transform.position - new Vector3(0,0, 10), 0.125f);
    }
	// Update is called once per frame
	void FixedUpdate () {
        FollowObject();
    }
}
