using UnityEngine;
using System.Collections;

public class CircleGerbatine : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward * -90 * Time.deltaTime);
		}


	public Collider2D otherObject;
	void OnTriggerEnter2D(Collider2D other)
	{
		print (other.tag);
		if (other.tag == "Player") {
			SimpleLoadLevel.SimpleLoad ("Start");
		}
	}
}
