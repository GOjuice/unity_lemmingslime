using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime_Core : MonoBehaviour {
	private Rigidbody2D rb;
	public float jump_Ammount=20.0f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();


	}
	
	// Update is called once per frame
	void FixedUpdate () {

		rb.velocity = (new Vector2(2,rb.velocity.y));// 이동 시 y축 속도 유지
		if(Input.GetButtonDown("Jump")){
		SlimeJump();
		}

	}

	public void SlimeJump(){
		rb.velocity = new Vector2 (rb.velocity.x, 0);
		rb.AddForce(new Vector2(0,50),ForceMode2D.Impulse);
		Debug.Log ("실행한다");
	}
}
