using UnityEngine;
using System.Collections;

public class CVMBuildingSpawn : MonoBehaviour {
	public Camera PlayCam;
    
      private Vector2 mousPOS;

    void OnMouseDown(){
		Vector2 rawpos = WPMouseCalc ();
		Vector2 pos = SnapToGrid (rawpos);
		Instantiate (CVMPlaceBuilding.selectedBlding, pos, Quaternion.identity);
        mousPOS = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(Mathf.Round(mousPOS.x), Mathf.Round(mousPOS.y));

        Instantiate(CVMPlaceBuilding.selectedBlding, mousPOS, Quaternion.identity);
    }

	Vector2 SnapToGrid (Vector2 rawWorldPos) {
		float newX = Mathf.RoundToInt (rawWorldPos.x);
		float newY = Mathf.RoundToInt (rawWorldPos.y);
		return new Vector2 (newX, newY);
	}

	Vector2 WPMouseCalc(){
		float mouseX = Input.mousePosition.x;
		float mouseY = Input.mousePosition.y;
		float DistCam = 10f;

		Vector3 Triplet = new Vector3 (mouseX, mouseY, DistCam);
		Vector2 worldPos = PlayCam.ScreenToWorldPoint (Triplet);

		return worldPos;
	}
}
