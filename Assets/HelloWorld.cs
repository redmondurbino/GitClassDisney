using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {
	
	private int StartingLife = 6;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI()
	{
		GUILayout.BeginVertical();
		GUILayout.Label("Go Megadillo");
		GUILayout.Label("Hello World");
		GUILayout.Label ("Starting Life = " + StartingLife);
		GUILayout.Label("Hello World Again");
		GUILayout.Label("Hello World 3 times");
		GUILayout.EndVertical();
			
	}
}
