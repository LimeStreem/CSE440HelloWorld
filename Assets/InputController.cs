using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {
	public Sprite firstTexture;

	public Sprite secoundTexture;

	private bool textureFlag = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		this.GetComponent<SpriteRenderer> ().sprite = this.textureFlag ? this.firstTexture : this.secoundTexture;
		this.textureFlag = !this.textureFlag;
	}
}
