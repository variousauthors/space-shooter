using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {
	private Rigidbody rb;

	public float speed;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody> ();
	
		rb.velocity = transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
