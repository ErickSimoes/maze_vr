using UnityEngine;

public class Door : MonoBehaviour {
	private bool locked = true;
	private bool opening = false;

	public Animator doorAnimation;

	public AudioSource audioSource;
	public AudioClip doorLocked;
	public AudioClip doorOpened;

	void Start() {
		doorAnimation.StartPlayback();
	}

	void Update() {
		if (opening) {
			doorAnimation.StopPlayback();
			GetComponent<BoxCollider>().enabled = false;
		}
	}

	public void OnDoorClicked() {
		if (!locked) {
			opening = true;
			audioSource.clip = doorOpened;
		} else {
			audioSource.clip = doorLocked;
		}
		audioSource.Play();
	}

	public void Unlock() {
		locked = false;
	}
}
