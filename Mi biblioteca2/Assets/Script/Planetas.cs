using UnityEngine;
using System.Collections;

public class Planetas : MonoBehaviour {
	public GameObject center;
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(new Vector3(0,10,0), Vector3.up, speed * Time.deltaTime);
	
	}
}
