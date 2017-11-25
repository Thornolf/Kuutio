using UnityEngine;
using System.Collections;

public class EnnemyKill : MonoBehaviour {

	public Collider2D otherObject;
	void OnTriggerEnter2D(Collider2D other)
	{
		print (other.tag);
		if (other.tag == "Player") {
			Destroy (other.gameObject);
			Application.LoadLevel (Application.loadedLevel);
		}
	}
}
