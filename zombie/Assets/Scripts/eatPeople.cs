using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class eatPeople : MonoBehaviour {
	public timeSlider slider;
	public Slider time;
	dialogue box;

	public bool once=false;
	public GameObject[] check;
	public GameObject[] strangers;

	public GameObject gameOver;
	//EndGame gameover;


	public GameObject dialog;
	public GameObject lostcontrol;

	rush eatrush;

	public string[] EatFrienddialogueLines;
	public string[] DetecteddialogueLines;
	public string[] GameOverConditionOne;
	public string[] WinCondition;

	public GameObject detect;
	easyDetection detector;

	// Use this for initialization
	void Start () {
		//gameover = endControl.GetComponent<EndGame> ();
		box = dialog.GetComponent<dialogue> ();
		detector = detect.GetComponent<easyDetection> ();
		eatrush = lostcontrol.GetComponent<rush> ();
	

	}

	void OnTriggerStay(Collider other){
		if (other.gameObject.tag == "friend"&& Input.GetKeyDown (KeyCode.Space) == true) {
			if (!box.dialogActive) {
				box.dialogLines = EatFrienddialogueLines;
				box.currentLine = 0;
				box.ShowDialogue();

				box.over = true;



			}


		} 


		if (other.gameObject.tag == "stranger"&& Input.GetKeyDown(KeyCode.Space)==true) { 
			Destroy (other.gameObject);
			Debug.Log ("haha");
			box.ate = true;

			if (detector.detected&&!box.dialogActive) {				
				box.dialogLines = DetecteddialogueLines;
				box.currentLine = 0;
				box.ShowDialogue();
				box.over = true;


			}

			time.value =0f;
			slider.addTime ();
		}
		
	}

	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "stranger")
			box.ate = false;
			Debug.Log ("exit");
	}
		


	
	// Update is called once per frame
	void Update () {
		check = GameObject.FindGameObjectsWithTag("friend");
		strangers = GameObject.FindGameObjectsWithTag ("stranger");

		if (check.Length == 0&&once==false) {
			once=true;
			lostcontrol.SetActive (false);
			Debug.Log ("alone");
			box.dialogLines = GameOverConditionOne;
			box.currentLine = 0;
			box.ShowDialogue();
			box.over = true;
	
			//gameOver.SetActive (true);
		}

		if (strangers.Length == 0 && once == false) {
			once = true;
			box.dialogLines = WinCondition;
			box.currentLine = 0;
			box.ShowDialogue ();
			box.over = true;
		}




//		if (eatrush.gameOverOne) {
//			Debug.Log ("iwanttosleep");
//			box.dialogLines = GameOverConditionOne;
//			box.currentLine = 0;
//			box.ShowDialogue();
//		}

		//if(
		
		
	
}
}