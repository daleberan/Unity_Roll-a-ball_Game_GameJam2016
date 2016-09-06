using UnityEngine;
using System.Collections;

public class Move_simple1 : MonoBehaviour {

	public float speed1 = 2;

	private Rigidbody rb;

	public float MoveHorizontal; 
	public float MoveVertical; 


	void Start ()
	{
		rb = GetComponent<Rigidbody> ();

	}
		
	void FixedUpdate () 
	{

		MoveHorizontal = 0;
		MoveVertical = 0;

		if (Input.GetKey (KeyCode.RightArrow))
			   MoveHorizontal = 1; 
		
		if (Input.GetKey (KeyCode.LeftArrow))
				MoveHorizontal = -1; 
		
		if (Input.GetKey (KeyCode.UpArrow))
				MoveVertical = 1; 

		if (Input.GetKey (KeyCode.DownArrow))
				MoveVertical = -1; 


		Vector3 movement = new Vector3 (MoveHorizontal, 0.0f, MoveVertical);

		rb.AddForce(movement*speed1);

	}

}
