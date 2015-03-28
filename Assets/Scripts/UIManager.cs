using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

	Texture firstPlaceTexture;
	Texture secondPlaceTexture;

	void Start() {
		firstPlaceTexture = Resources.Load("number1") as Texture;
		secondPlaceTexture = Resources.Load("number1") as Texture;
	}

	void OnGUI() {
		if(!firstPlaceTexture){
			Debug.LogError("Assign a Texture in the inspector.");
			return;
		}
		int w1 = firstPlaceTexture.width/2;
		int h1 = firstPlaceTexture.height/2;
		GUI.DrawTexture(new Rect(10, Screen.height - h1 - 10, w1, h1), firstPlaceTexture);

		if(!secondPlaceTexture){
			Debug.LogError("Assign a Texture in the inspector.");
			return;
		}
		int w2 = secondPlaceTexture.width/2;
		int h2 = secondPlaceTexture.height/2;
		GUI.DrawTexture(new Rect(Screen.width - w2 - 10, Screen.height - h2 - 10, w2, h2), firstPlaceTexture);
	}

	void Update() {
	
	}
}
