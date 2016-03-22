using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

public float TargetDistance;
public float LookDistance;
public float followDistance;
public float movementSpeed;
public float damping;
public Transform target;
Rigidbody body;
Renderer myRenderer;


	// Use this for initialization
	void Start () {
	myRenderer = GetComponent<Renderer>();
	body = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	TargetDistance = Vector3.Distance(target.position,transform.position);
	if (TargetDistance< LookDistance){
	myRenderer.material.color = Color.red;
	lookAtPlayer();
	}
	if(TargetDistance<followDistance){
	follow();
	}
	}
void lookAtPlayer(){
Quaternion rotation = Quaternion.LookRotation(target.position - transform.position);
transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime*damping);

}
void follow (){
body.AddForce(transform.forward*movementSpeed);
}
}