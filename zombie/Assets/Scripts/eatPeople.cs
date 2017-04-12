using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class eatPeople : MonoBehaviour {
	public Image damageScreen;//an image that fills the screen to indicate that the player just gets damaged
	Color flashColor = new Color(255f, 255f, 255f, 1f);//the damage screen will appear on the screen after its color is turned to this
	float flashSpeed = 5f;
	public bool damaged=false;
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



	public AudioSource ate;

	public AudioSource scream;

	// Use this for initialization
	void Start () {
		//gameover = endControl.GetComponent<EndGame> ();
		box = dialog.GetComponent<dialogue> ();
		detector = detect.GetComponent<easyDetection> ();
		eatrush = lostcontrol.GetComponent<rush> ();
		ate = GetComponent<AudioSource> ();
		scream = GetComponent<AudioSource> ();

	}

	void OnTriggerStay(Collider other){
		if (other.gameObject.tag == "friend"&& Input.GetKeyDown (KeyCode.Space) == true) {
			if (!box.dialogActive) {
				box.dialogLines = EatFrienddialogueLines;
				box.currentLine = 0;
				box.ShowDialogue();
				scream.Play ();

				box.over = true;




			}


		} 


		if (other.gameObject.tag == "stranger"&& Input.GetKeyDown(KeyCode.Space)==true) { 
			Destroy (other.gameObject);
			Debug.Log ("haha");
			box.ate = true;
			ate.Play ();
			scream.Play ();
			damaged = true;

			if (detector.detected&&!box.dialogActive) {				
				box.dialogLines = DetecteddialogueLines;
				box.currentLine = 0;
				box.ShowDialogue();
				box.over = true;
				scream.Play ();


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
		if (damaged)
		{
			//after the player gets hit by the enemy, the blood image whill appears and the audioClip "getHit" will be played
			damageScreen.color = flashColor;

		}
		else
		{
			damageScreen.color = Color.Lerp(damageScreen.color, Color.clear, flashSpeed * flashSpeed * Time.deltaTime);
		}

		damaged = false; //to make sure that the damage screen only appears once after each damage


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
			scream.Play ();
	
			//gameOver.SetActive (true);
		}

		if (strangers.Length == 0 && once == false) {
			once = true;
			box.dialogLines = WinCondition;
			box.currentLine = 0;
			box.ShowDialogue ();
			box.over = true;
			scream.Play ();
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