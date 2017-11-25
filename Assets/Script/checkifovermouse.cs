using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class checkifovermouse : MonoBehaviour {

	void Update () 
	{
		// Check if the left mouse button was clicked
		if(Input.GetMouseButton(0))
		{
			print ("In da boucle");
			print ("Input: " + Input.GetMouseButtonDown(0));
			// Check if the mouse was clicked over a UI element
			if(!EventSystem.current.IsPointerOverGameObject())
			{
				Debug.Log("Did not Click on the UI");
			}
		}	
	}
}