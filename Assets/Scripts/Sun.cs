using UnityEngine;
using System.Collections;

public class Sun : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	transform.RotateAround(Vector3.zero,Vector3.right, 10f*Time.deltaTime);
	transform.LookAt(Vector3.zero);
	
	}
}
