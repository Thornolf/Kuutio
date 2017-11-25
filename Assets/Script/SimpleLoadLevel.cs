using UnityEngine;
using System.Collections;

public class SimpleLoadLevel : MonoBehaviour {
	public static void SimpleLoad(string level)
	{
		Application.LoadLevel (level);
	}

}
