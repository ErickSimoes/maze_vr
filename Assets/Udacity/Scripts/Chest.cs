using UnityEngine;

public class Chest : MonoBehaviour {
	public GameObject doorChest;
	private bool rotate = false;

	private void Update() {
		if (rotate) {
			doorChest.transform.Rotate(30 * Time.deltaTime, 0.0f, 0.0f);

			if (doorChest.transform.eulerAngles.x > 350) {
				rotate = false;
			}
		}
	}

	public void OnChestClicked() {
		rotate = true;
	}
}
