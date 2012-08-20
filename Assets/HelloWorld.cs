using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {
	
	private int StartingLife = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI()
	{
		GUILayout.BeginVertical();
		GUILayout.Label("Hello World");
		GUILayout.Label ("Starting Life = " + StartingLife);
		GUILayout.Label ("This is the experimental branch");
		GUILayout.EndVertical();
			
	}
}
