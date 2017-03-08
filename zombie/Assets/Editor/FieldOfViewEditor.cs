using UnityEngine;
using System.Collections;
using UnityEditor;


[CustomEditor(typeof(FieldofView))]
public class FieldOfViewEditor : Editor {

	void OnSceneGUI(){
//		FieldofView fow = (FieldofView)target;
		FieldofView fov=(FieldofView)target;
		//FieldofView fov=target as FieldofView;
		Handles.color = Color.white;
		Handles.DrawWireArc (fov.transform.position, Vector3.up, Vector3.forward, 360, fov.viewRadius);
		Vector3 viewAngleA = fov.DirFromAngle (-fov.viewAngle / 2,false);
		Vector3 viewAngleB = fov.DirFromAngle (fov.viewAngle / 2,false);

		Handles.DrawLine (fov.transform.position, fov.transform.position + viewAngleA * fov.viewRadius);
		Handles.DrawLine (fov.transform.position, fov.transform.position + viewAngleB * fov.viewRadius);

		Handles.color = Color.red;
		foreach (Transform visibleTarget in fov.visibleTargets) {
			Handles.DrawLine (fov.transform.position, visibleTarget.position);
		}
	
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
