using UnityEngine;
using System.Collections;

public class Tree : MonoBehaviour {

static int numTrees = 75;
public GameObject Prefab;
static GameObject[] trees;

	// Use this for initialization
	void Start () {
	trees = new GameObject[numTrees];
	for(int i=0; i<numTrees; i++){
	trees[i] = (GameObject) Instantiate(Prefab, Vector3.zero, Quaternion.identity);
	trees[i].SetActive(false);
	}
	}
	static public GameObject getTree()
	{
	for(int i=0; i<numTrees; i++)
	{
	if(!trees[i].activeSelf){
	return trees[i];
	}
	}return null;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
