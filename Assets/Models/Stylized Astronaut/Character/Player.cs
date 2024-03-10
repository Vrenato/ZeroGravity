using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

		private Animator anim;
		private CharacterController controller;

		public float speed = 600.0f;
		public float turnSpeed = 400.0f;
		private Vector3 moveDirection = Vector3.zero;
		public float gravity = 20.0f;
		public float jumpHeight;
		


	void Start () {
			controller = GetComponent <CharacterController>();
			anim = gameObject.GetComponentInChildren<Animator>();
		}

		void Update (){

        if (controller.transform.position.y < -7)
        {
			Debug.Log("Lezuhant�l, prty over!");
        }


		if (Input.GetKey ("w"))
		{
			anim.SetInteger ("AnimationPar", 1);
		}  

		else
		{
			anim.SetInteger("AnimationPar", 0);
		}

	



		if (Input.GetKeyDown(KeyCode.Space))
		{
			
			moveDirection.y = Mathf.Sqrt(2 * jumpHeight * gravity);
			//animacio hozzarendelese az ugrashoz
			//anim.SetInteger("AnimationPar", 1);
		}

		


		if (controller.isGrounded){
				moveDirection = transform.forward * Input.GetAxis("Vertical") * speed;
			
			}

			float turn = Input.GetAxis("Horizontal");
			transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
			controller.Move(moveDirection * Time.deltaTime);
			moveDirection.y -= gravity * Time.deltaTime;


			
	}
}
