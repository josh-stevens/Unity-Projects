using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	
		/*
		 this.transform.position.x = mousePos won't work
		 The transform position must be changed as a whole vector3,
		 since the individual x y z components can't be changed.
		 Therefore, a temporary vector variable is created to change
		 the paddle position. 
		*/
		
		Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y, 0f);
		
		// mousePos is given in pixels. First we must convert it to
		// world units so it can be put in the transform component.
		// We also want to clamp it so it doesn't leave the screen which is 16
		// units wide. The paddle is 1 unit wide, so we use 0.5 and 15.5
		// since the transform is based on the middle of the paddle.
		
		float mousePos = Mathf.Clamp (Input.mousePosition.x / Screen.width * 16, 0.5f, 15.5f);
		paddlePos.x = mousePos;
		
		this.transform.position = paddlePos;
	}
}
