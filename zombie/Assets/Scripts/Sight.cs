using UnityEngine;
using System.Collections;

public class Sight : MonoBehaviour {
	public float fieldOfSightAngle = 110f;
	public bool playerInSight;

	public CapsuleCollider col;
	public GameObject player;
	LineRenderer line;
	public GameObject dialog;

	dialogue box;


	void Awake(){
		//col = GetComponent<Colliders> ();
		line = GetComponent<LineRenderer>();
		box = dialog.GetComponent<dialogue> ();

	}
	
	// Update is called once per frame
	void Update () {
		int a = 1;
		if(playerInSight){
				a=2;}
				Debug.Log(a);
		line.SetPosition(0, transform.position);

		RaycastHit hit;
		if (Physics.Raycast (transform.position,  transform.forward, out hit, col.radius)) {
			line.SetPosition (1, hit.point); 
		}


	}

	void OnTriggerStay(Collider other){
		//Debug.Log ("ohhh" );

		//playerInSight = true;

		if (other.gameObject == player) {
			playerInSight = false;
			Vector3 directrion = other.transform.position - transform.position;
			float angle = Vector3.Angle(directrion, transform.forward);

			if(angle<fieldOfSightAngle*0.5f)
			{
				RaycastHit hit;
				if(Physics.Raycast(transform.position,directrion.normalized,out hit,col.radius)) 
					{
						
						if(hit.collider.gameObject==player){
							playerInSight=true;
							box.detected = true;
						}
					}

			}

		
		}
	
	
	}

	void OnTriggerExit(Collider other){
		if (other.gameObject == player)
			playerInSight = false;
			box.detected = false;
	}






}
