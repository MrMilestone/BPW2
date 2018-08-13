using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {
    public static GameMaster gm;

    void Start()
    {
        if (gm == null)
        {
            gm = this;
        }
    }
    public Transform PlayerPrefab;
    public Transform spawnPoint;

    public void RespawnPlayer() {
        Instantiate (PlayerPrefab, spawnPoint.position, spawnPoint.rotation);
    }
   
    
    public static void KillPlayer (Player player) {
		Destroy (player.gameObject);
        gm.RespawnPlayer();
         
	}

}