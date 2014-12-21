using UnityEngine;
using System.Collections;

public class MainUIPanel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void ArrangeUICharCards() {
		float y_pos = -50;


		foreach (Transform t in gameObject.transform) {
			GameObject g = t.gameObject;
			//set rectangle
			RectTransform rt = (RectTransform) t;
			//Debug.Log (rt.anchorMax);
			rt.anchoredPosition = new Vector2(0, y_pos);


			//t.localPosition = new Vector3(0, y_pos, 0);

			//rt.an
			y_pos -= 75;

		}
	}
}
