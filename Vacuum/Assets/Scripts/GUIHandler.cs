﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GUIHandler : MonoBehaviour {

    public Text coins;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        coins.text = DataCollection.Coins.ToString();
	}
}
