using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class rightover: MonoBehaviour {
	public EventSystem eventlol;
	void Update () 
	{
		// Check if the left mouse button was clicked
			// Check if the mouse was clicked over a UI element
		print(eventlol.IsPointerOverGameObject());
		if (EventSystem.current.IsPointerOverGameObject ())
			{
				Debug.Log("You touch right");
			}
	}
}