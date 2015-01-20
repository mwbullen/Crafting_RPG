using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ItemDragDrop : MonoBehaviour {

	public void onDrag() {
		transform.position = Input.mousePosition;

	}

}
