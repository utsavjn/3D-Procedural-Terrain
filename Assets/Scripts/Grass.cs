using UnityEngine;
using System.Collections;

public class Grass : MonoBehaviour {

static int numGrass = 1000;
public GameObject Prefab;
static GameObject[] grass;

	// Use this for initialization
	void Start () {
	grass = new GameObject[numGrass];
	for(int i=0; i<numGrass; i++){
	grass[i] = (GameObject) Instantiate(Prefab, Vector3.zero, Quaternion.identity);
	grass[i].SetActive(false);
	}
	}
	static public GameObject getGrass()
	{
	for(int i=0; i<numGrass; i++)
	{
	if(!grass[i].activeSelf){
	return grass[i];
	}
	}return null;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
