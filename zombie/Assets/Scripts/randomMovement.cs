using UnityEngine;
using System.Collections;

public class randomMovement : MonoBehaviour {

	public float timer;
	public int waitNewTarget;
	public float speed;
	public NavMeshAgent nav;
	public float range = 100;
	public Vector3 target;
	turnAround ta;


	// Use this for initialization
	void Start () {
		nav = gameObject.GetComponent<NavMeshAgent> ();	
		ta = GetComponentInChildren<turnAround> ();
	}

	
	// Update is called once per frame
	void Update () { 
		timer += Time.deltaTime;
		if (timer >= waitNewTarget) {
			newTarget ();
			timer = 0;

	
		}
	



	}
		//nav.SetDestination (target);

	void OnTriggerEnter(Collider other){
		if (other.tag == "rotate") {
			Debug.Log ("you rotate");
			transform.RotateAround (transform.position, Vector3.up, 180);
		}
	}






	void newTarget(){
		float nowX = gameObject.transform.position.x;
		float nowZ = gameObject.transform.position.z;
		float xPos = nowX + Random.Range (nowX - range, nowX + range);
		float zPos = nowZ + Random.Range (nowZ - range, nowZ + range);

		target = new Vector3 (xPos, gameObject.transform.position.y,zPos);
		nav.SetDestination(target);

		//if(ta.stuck)
		//	nav.SetDestination(new Vector3(-xPos, gameObject.transform.position.y,zPos));
		//DFADFADSF
	}


		
	
	}

		