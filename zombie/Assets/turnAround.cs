using UnityEngine;
using System.Collections;

public class turnAround : MonoBehaviour {

	public bool stuck=false;
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Finish" )
		{
			Debug.Log ("gfDFD");
			stuck = true;
		}

	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Finish" )
		{
			Debug.Log ("gfDFD-=-=-=-=-");
			stuck = false;
		}

	}
	

}
