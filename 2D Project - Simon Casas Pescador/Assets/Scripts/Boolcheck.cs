using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boolcheck : MonoBehaviour {

 public bool items1;
 public bool items2;
 public GameObject ShipDoor;


	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player" && items1 == true && items2 == true){

				ShipDoor.SetActive(true);

		}
	}
}
