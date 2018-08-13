using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxing : MonoBehaviour {

    public Transform[] backgrounds; //Array list of all backgrounds and foregrounds to be Parallaxed
    private float[] parallaxScales; // Proportion of cameras movement to move the Backgrounds.
    public float smoothing = 1f;     //How smooth the parallax will move, Set above 0 always.

    private Transform cam;          //Reference to main cameras transform.
    private Vector3 previousCamPos; //Store position of camera in previous frame.


    // Called before start. references go here.
     void Awake(){
        //set camera reference.
        cam = Camera.main.transform;
    }

    // Use this for initialization
    void Start () {
        //The previous ffame had the current frame camera position.
        previousCamPos = cam.position;

        // asigning corresponding parallaxScales
        parallaxScales = new float[backgrounds.Length];

        for (int i = 0; i < backgrounds.Length; i++ ) {
            parallaxScales[i] = backgrounds[i].position.z * -1;
        }
	}
	
	// Update is called once per frame
	void Update () {

        //for each Bacground
        for (int i = 0; i < backgrounds.Length; i++ ) {
            //paralax is the oposite of the camera movement.

            float parallax = (previousCamPos.x - cam.position.x) * parallaxScales[i];

            //set target x position = current position + parallax

            float backgroundTargetPosX = backgrounds[i].position.x + parallax;

            // target position which is backgrounds current position
            Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX, backgrounds[i].position.y, backgrounds[i].position.z);
            //fade between current position and the target position.
            backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);

        }
        //set the previous CamPosition to the cameras position at the end of the frame
        previousCamPos = cam.position;
	}
}
