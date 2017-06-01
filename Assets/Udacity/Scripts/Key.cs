using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {
	public int velocityRotation = 80;
	public GameObject[] keysPositions;

	//Create a reference to the KeyPoofPrefab and Door

	private void Awake() {
		int randomKeyPosition = Random.Range(0, keysPositions.Length);
		transform.position = keysPositions[randomKeyPosition].transform.position;
	}

	void Update() {
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked() {
		// Instatiate the KeyPoof Prefab where this key is located
		// Make sure the poof animates vertically
		// Call the Unlock() method on the Door
		// Set the Key Collected Variable to true
		// Destroy the key. Check the Unity documentation on how to use Destroy
	}

}
