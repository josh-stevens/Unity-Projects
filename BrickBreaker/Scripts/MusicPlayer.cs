using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static bool instance = false;
	
	void Awake() {
	
		if (instance)
		{
			Destroy (gameObject);
			print ("Duplicate music player self-destructing!");
		}
		else {
			instance = true;
			GameObject.DontDestroyOnLoad (gameObject);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
