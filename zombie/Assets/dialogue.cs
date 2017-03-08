using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class dialogue : MonoBehaviour {
	public GameObject dBox;
	public Text dText;
	public GameObject indicator;



	public bool detected=false;
	public bool ate = false;
	public bool dialogActive;

	public GameObject gameover;


	public bool ok=false;


	public bool over=false;

	timeSlider slider;

	public string[] dialogLines;
	public int currentLine;
	// Use this for initialization
	void Start () {
		slider = indicator.GetComponent<timeSlider> ();
	}
	
	// Update is called once per frame
	void Update () {


		if (dialogActive&& Input.GetKeyDown (KeyCode.Space) == true) {
			//dBox.SetActive (false);
			//dialogActive = false;

			currentLine++;

		}

		if (currentLine >= dialogLines.Length) {
			dBox.SetActive (false);
			dialogActive = false;
			//indicator.SetActive (true);
			slider.begin=true;
			 
			currentLine = 0;
			if (over) {
				Debug.Log ("gameoverrrrrrr");
				gameover.SetActive (true);


			}
		}
		dText.text = dialogLines[currentLine];

		if (detected && ate)
			Debug.Log ("you did it");
	
	}


	public void ShowBox(string dialogue){
		dialogActive = true;
		dBox.SetActive (true);
		dText.text = dialogue;
	}


	public void ShowDialogue(){
		dialogActive = true;
		dBox.SetActive (true);
	}

}
