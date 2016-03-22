using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void OnGUI () {
	const int buttonWidth = 84;
	const int buttonHeight =60;
	Rect buttonRect = new Rect(Screen.width/2 -(buttonWidth/2), (2*Screen.height/3)-(buttonHeight/2), buttonWidth, buttonHeight );

	if(GUI.Button(buttonRect, "PLAY")){
	Application.LoadLevel("Terrain");
	}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
