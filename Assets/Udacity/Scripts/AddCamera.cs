using UnityEngine;

public class AddCamera : MonoBehaviour {

	public Canvas canvas;

	// Use this for initialization
	void Start() {
		canvas.renderMode = RenderMode.ScreenSpaceCamera;
	}

	// Update is called once per frame
	/*void Update() {
		if (canvas.worldCamera == null) {
			canvas.worldCamera = GameObject.Find("Main Camera Right").GetComponent<Camera>();
		}
	}*/
}
