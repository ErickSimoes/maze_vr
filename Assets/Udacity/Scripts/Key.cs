using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour {
	public GameObject[] keysPositions;
	public GameObject KeyPoofPrefab;
	public Door door;
	public Image imageKey;

	private Vector3 keyPosition;
	private int velocityRotation = 80;
	private bool haveKey = false;
	private bool destroyedKey = false;

	private AudioSource audioSource;

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
		door.Unlock();
		haveKey = true;
		audioSource.Play();
		Instantiate(KeyPoofPrefab, transform.position, Quaternion.Euler(-90, 0, 0));
		imageKey.color = Color.white;
	}

}
