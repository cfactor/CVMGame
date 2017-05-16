using UnityEngine;
using System.Collections;

public class CVMTempBuild : MonoBehaviour {

	// Use this for initialization

	public GameObject finalObj;

	private Vector2 mousPOS;


	// Update is called once per frame
	void Update () {
		mousPOS = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		transform.position = new Vector2 (Mathf.Round (mousPOS.x), Mathf.Round (mousPOS.y));


			RaycastHit2D rayHit = Physics2D.Raycast (transform.position, Vector2.zero, Mathf.Infinity);
		
				if (rayHit.collider.gameObject.tag == "Playgrid" && this.gameObject.tag == "Building") {
					Instantiate (finalObj, transform.position, Quaternion.identity);
				}
			
	}
}
