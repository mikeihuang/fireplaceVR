using UnityEngine;
using System.Collections;

public class FloorTextureTile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.GetComponent<Renderer>().material.mainTextureScale = new Vector2(10 , 10);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
