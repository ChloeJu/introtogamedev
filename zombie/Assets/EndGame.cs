using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {
//	public GameObject manager;

	public Text dText;
	public GameObject[] check;

//	public bool detected=false;
//	public bool ate = false;
	public bool dialogActive=false;
	public string[] dialogLines;
	public int currentLine;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (dialogActive&& Input.GetKeyDown (KeyCode.Space) == true) {
			//dBox.SetActive (false);
			//dialogActive = false;

			currentLine++;

		}

		if (currentLine >= dialogLines.Length) {

			dialogActive = false;
			gameObject.SetActive (false);
//			manager.SetActive (true);

			currentLine = 0;
		}
		dText.text = dialogLines[currentLine];

	//	if (detected && ate)
	//		Debug.Log ("you did it");

	}


	public void ShowBox(string dialogue){
		dialogActive = true;

		dText.text = dialogue;
	}


	public void ShowDialogue(){
		dialogActive = true;

	}

}
