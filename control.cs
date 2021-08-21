using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviour : MonoBehaviour{
    public float berat, tinggiLoncat;
    public GameObject head;
	// Use this for initialization
	void Start () {
		
	}
	void OnMouseDown(){
        head.GetComponent<Rigidbody2D> ().gravityScale = berat;
        head.GetComponent<Rigidbody2D> ().velocity = new Vector2(head.GetComponent<Rigidbody2D>().velocity.x, tinggiLoncat);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
