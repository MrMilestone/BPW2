using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Death : MonoBehaviour {

public GameObject currentCheckpoint;
public GameObject player;

  void OnTriggerEnter2D(Collider2D other){
    if(other.name == "Player"){
      RespawnPlayer();

    	}
		}
		public void RespawnPlayer(){
			Debug.Log ("Player Respawn");
			player.transform.position = currentCheckpoint.transform.position;
		}
	}
