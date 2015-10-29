using UnityEngine;
using System.Collections;

public class KeyboardController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += new Vector3 (1, 0, 0) * Input.GetAxis ("Horizontal");
		this.transform.position += new Vector3 (0, 1, 0) * Input.GetAxis ("Vertical");
	}
}
