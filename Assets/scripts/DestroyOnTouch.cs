﻿using UnityEngine;
using System.Collections;

public class DestroyOnTouch : MonoBehaviour {
	
	public GameObject objectToBeDestroyed;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	void OnTriggerEnter(Collider col){
		if(col.tag == "Player"){
			objectToBeDestroyed.SetActive(false);	
		}	
	}
}
