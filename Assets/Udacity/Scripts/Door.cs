using UnityEngine;

public class Door : MonoBehaviour {
	private bool locked = true;
	private bool opening = false;

	public Animator doorAnimation;

	void Start() {
		doorAnimation.StartPlayback();
	}

	void Update() {
		if (opening) {
			doorAnimation.StopPlayback();
		}
	}

	public void OnDoorClicked() {
		if (!locked) {
			opening = true;
		} else {
			// Play a sound to indicate the door is locked
		}
	}

	public void Unlock() {
		locked = false;
	}
}
