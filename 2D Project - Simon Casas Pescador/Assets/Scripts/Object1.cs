using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object1 : MonoBehaviour {

     public GameObject ShipItem;
		 public AudioSource Pickup;
		 public Boolcheck boolBoy;

void start (){
	GameObject g = GameObject.FindGameObjectWithTag ("BoolKeeper");
	boolBoy = g.GetComponent<Boolcheck> ();
}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player"){
			Debug.Log("OBJECT IS NEAR");
			boolBoy.items1 = true;
			Pickup.Play ();
			ShipItem.SetActive(false);
		}
	}
}
