using UnityEngine;

public class Key : MonoBehaviour {
	public GameObject[] keysPositions;
	public GameObject KeyPoofPrefab;

	private Vector3 keyPosition;
	private int velocityRotation = 80;
	private AudioSource audioSource;
	private bool haveKey = false;
	private bool destroyedKey = false;

	//Create a reference to the KeyPoofPrefab and Door

	private void Awake() {
		keyPosition = keysPositions[Random.Range(0, keysPositions.Length)].transform.position;
		transform.position = keyPosition;

		audioSource = GetComponent<AudioSource>();
		audioSource.playOnAwake = false;
	}

	void Update() {
		transform.Rotate(Vector3.up * Time.deltaTime * velocityRotation);

		if (haveKey && !destroyedKey) {
			velocityRotation += 80;
			transform.localScale += new Vector3(0, -1f, 0.5f);
			transform.position += Vector3.up * 0.01f;

			if (transform.localScale.y <= 0) {
				destroyedKey = true;
				Destroy(gameObject);
			}
		}
	}

	public void OnKeyClicked() {
		// ok - Instatiate the KeyPoof Prefab where this key is located
		// ok - Make sure the poof animates vertically
		// Call the Unlock() method on the Door
		// ok - Set the Key Collected Variable to true
		// ok - Destroy the key. Check the Unity documentation on how to use Destroy
		haveKey = true;
		audioSource.Play();
		Instantiate(KeyPoofPrefab, transform.position, Quaternion.Euler(-90, 0, 0));
	}

}
