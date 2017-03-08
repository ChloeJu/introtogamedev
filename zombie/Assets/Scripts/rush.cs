using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class rush : MonoBehaviour {
	NavMeshAgent nav;
//	dialogue box;

	public  bool gameOverOne=false;

//	public GameObject dialog;

//	public string[] GameOverOne;
	//public Slider slider;

	public List<GameObject> friends = new List<GameObject>();
	// Use this for initialization
	void Start () {
		nav = GetComponentInParent<NavMeshAgent> ();
//		box = dialog.GetComponent<dialogue> ();
		GameObject[] friendsStatic = GameObject.FindGameObjectsWithTag("friend");

		//going through the static array of friends
		for (int i = 0; i < friendsStatic.Length; i++) 
		{
			//assign to the list (dynamic array)
			friends.Add (friendsStatic[i]);
		}

		StartCoroutine (Wait ());

	}
	
	// Update is called once per frame
	void Update () {
		foreach (GameObject friend in friends) {
			
			nav.SetDestination (friend.transform.position);
			if(Vector3.Distance(friend.transform.position,gameObject.transform.position)<=1f){
				//friend.SetActive (false);
				friends.Remove (friend);
				Destroy (friend);
				Debug.Log ("nearby");
				//Destroy (friend.gameObject);
			}
		}



		}


//		if (end&&!box.dialogActive) {
//			box.dialogLines = GameOverOne;
//			box.currentLine = 0;
//			box.ShowDialogue ();
//		}




	IEnumerator Wait(){
		Debug.Log ("first");
		yield return new WaitForSecondsRealtime (6);
		Debug.Log ("second");
		gameOverOne= true;



	}

	//void OnTriggerEnter(Collider other){
	//	if (other.tag == "stranger") {
	//		Vector3 target = new Vector3 (other.transform.position.x, other.transform.position.y, other.transform.position.z);
	//		nav.SetDestination (target);
	//	}
	//}


}
