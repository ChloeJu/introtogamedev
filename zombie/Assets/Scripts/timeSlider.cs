using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timeSlider : MonoBehaviour {

	//public float maxTime;
	float currentTime=0;
	public float slow=0.1f;
	public GameObject lost;

	public Slider indicator;

	public bool begin=false;

	// Use this for initialization
	void Start () {

		//indicator.maxValue = maxTime;
		indicator.value = currentTime;
	
	}

	// Update is called once per frame
	void Update () {
	//	if (Input.GetKeyDown (KeyCode.Space)) {
	//		begin = true;
	//	}
			
		if (begin) {
			currentTime = currentTime + Time.deltaTime * slow;
		}
		indicator.value = currentTime;

		if (currentTime >= 0.95f) {
			
			lost.SetActive (true);
			Debug.Log ("aaaa");
		}
	}

	public void addTime(){
		currentTime = currentTime - 0.27f;
	}
}
