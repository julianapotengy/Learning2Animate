using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	private float axisX, axisY, speed;
	private Rigidbody2D body;
	private Animator anim;

	void Start ()
	{
		speed = 10 * Time.deltaTime;
		body = this.GetComponent<Rigidbody2D> ();
		anim = this.GetComponent<Animator>();
	}

	void FixedUpdate()
	{
		float move = Input.GetAxis("Horizontal");
		anim.SetFloat("speed", Mathf.Abs(move));
	}

	void Update ()
	{
		axisX = Input.GetAxis ("Horizontal");
		axisY = Input.GetAxis ("Vertical");
		body.velocity = new Vector2(axisX * speed, axisY);
	}
}
