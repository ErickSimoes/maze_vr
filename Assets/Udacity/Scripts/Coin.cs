using UnityEngine;

public class Coin : MonoBehaviour {
	private float velocityRotation = 50;
	private bool clicked = false;

	private void Update() {
		transform.Rotate(Vector3.up * Time.deltaTime * velocityRotation);

		if (clicked) {
			velocityRotation += 50;
			transform.localScale += new Vector3(0, -1f, 0.5f);
			transform.position += Vector3.up * 0.01f;

			if (transform.localScale.y <= 0) {
				Destroy(gameObject);
			}
		}
	}

	public void OnCoinClicked() {
		clicked = true;
		GetComponent<AudioSource>().Play();
	}

}
