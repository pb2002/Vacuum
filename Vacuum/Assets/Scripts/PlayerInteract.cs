using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {


	// Use this for initialization
	void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Collectable")
        {
            if (collider.GetComponent<Collectable>() != null)
                collider.GetComponent<Collectable>().OnCollect();
        }
        
    }
}
