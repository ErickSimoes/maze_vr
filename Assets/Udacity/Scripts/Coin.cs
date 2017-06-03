using UnityEngine;

public class Coin : MonoBehaviour {
	//Create a reference to the CoinPoofPrefab
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

	public void OnCoinClicked() {
		// Instantiate the CoinPoof Prefab where this coin is located
		// Make sure the poof animates vertically
		// Destroy this coin. Check the Unity documentation on how to use Destroy
		rotate = true;
	}

}
