using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textfade : MonoBehaviour {
public GameObject Target;



		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.gameObject.tag == "Player"){

				Debug.Log("Player is in");
				Target.SetActive(true);

			}
		}
		void OnTriggerExit2D(Collider2D other)
		{
			if(other.gameObject.tag == "Player")
			{

				Destroy(Target);
				Debug.Log("Player is out");

			}

		}

	}
