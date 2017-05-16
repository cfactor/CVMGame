using UnityEngine;
using System.Collections;

public class CVMPlaceBuilding : MonoBehaviour {

	public GameObject BldingPrefab;

	private CVMPlaceBuilding[] BldngArray;
	public static GameObject selectedBlding;

  

    // Use this for initialization
    void Start () {
		//look at the building array and find the buildings
		BldngArray = GameObject.FindObjectsOfType<CVMPlaceBuilding>();
		//if not black, set color to black
		GetComponent<SpriteRenderer> ().color = Color.black;
	}
	
	// Update is called once per frame
	void Update () {
    }

	void OnMouseDown(){

		//if new building is selected, set all others to black
		foreach (CVMPlaceBuilding thisBlding in BldngArray) {
			thisBlding.GetComponent<SpriteRenderer> ().color = Color.black;
		}
        //selected building is now white

   
        GetComponent<SpriteRenderer> ().color = Color.white;
		//use the buildingprefab in BuildingSelect
		selectedBlding = BldingPrefab;

	}

}
