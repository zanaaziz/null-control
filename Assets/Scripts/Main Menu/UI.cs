using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {
	
	public GUISkin mySkin;
	public Texture2D Logo;
	public Texture2D Footer;

	void OnGUI(){
		GUI.skin = mySkin;
		
		// Creating the Logo.
		if(Logo != null){
			GUI.DrawTexture(new Rect((Screen.width / 2) - 100, 20, 200, 200), Logo);
		}
		
		// Creating the campaign button.
		if(GUI.Button(new Rect((Screen.width/2) -150, (Screen.height / 2) - 50, 300, 30), "Campaign Mode")){
			Application.LoadLevel(2);
		}
		
		// Creating the BTM button.
		if(GUI.Button(new Rect((Screen.width/2) -150, (Screen.height / 2), 300, 30), "Beat The Master")){
			Application.LoadLevel(5);
		}
		
		// Creating survival mode button.
		if(GUI.Button(new Rect((Screen.width/2) -150, (Screen.height / 2) + 50, 300, 30), "Survival Mode")){
			Application.LoadLevel(1);
		}
		
		// Creating quit option button.
		if(GUI.Button(new Rect((Screen.width/2) -150, (Screen.height / 2) + 100, 300, 30), "Quit Game")){
			Application.Quit();
		}
		
		// The footer.
		if(Footer != null){
		GUI.DrawTexture(new Rect((Screen.width / 2) - 150, (Screen.height / 2) + 200, 300, 30), Footer);
		}
	}
}
