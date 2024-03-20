using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

	private Animator anim;
	private CharacterController controller;

	public float speed = 600.0f;
	public float turnSpeed = 400.0f;
	private Vector3 moveDirection = Vector3.zero;
	public float gravity = 20.0f;
	public float gravity2 = -20.0f;
	public float jumpHeight;
	[SerializeField] GameObject gameOver;
	[SerializeField] GameObject gameOver2;
	private bool canJump = true;
	
	


	public Timer script;

	void Start()
	{
		controller = GetComponent<CharacterController>();
		anim = gameObject.GetComponentInChildren<Animator>();
		

	}

	void Update()
	{

		float turn = Input.GetAxis("Horizontal");
		transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
		controller.Move(moveDirection * Time.deltaTime);
		moveDirection.y -= gravity * Time.deltaTime;



		



		if (canJump)
		{
			// Process jump input only when the player is allowed to jump
			if (Input.GetKeyDown(KeyCode.Space))
			{
				
				Jump();
				
				

			}


		}
		void Jump()
		{
			// Your jump logic here
			moveDirection.y = Mathf.Sqrt(2 * jumpHeight * gravity);
			// Disable jumping for a certain duration 
			//StartCoroutine(DisableJumpForSeconds(0.1f));
		}
		/*
		System.Collections.IEnumerator DisableJumpForSeconds(float seconds)
		{
			// Disable jumping for the specified duration
			canJump = false;
			yield return new WaitForSeconds(seconds);
			canJump = true;
		}

		*/

		if (controller.transform.position.y < -7)
		{
			gameOver.SetActive(true);
			
		}

		if (controller.transform.position.y > 12)
		{
			gameOver2.SetActive(true);
			
		}


		if (Input.GetKey("w"))
		{
			anim.SetInteger("AnimationPar", 1);
		}

		else
		{
			anim.SetInteger("AnimationPar", 0);
		}




		if (script.remainingTime > 1)
		{
			script.remainingTime -= Time.deltaTime;

		}

		if (script.remainingTime < 2)
		{
			canJump = false;



		}

		if (script.remainingTime < 1)
		{

			script.remainingTime = 0;
			script.timerText.color = Color.red;
			gravity = -1.0f;

		}




	}

	private void FixedUpdate()
	{




		if (controller.isGrounded)
		{
			canJump = true;
			moveDirection = transform.forward * Input.GetAxis("Vertical") * speed;
			
			Debug.Log("IsGrounded!");


		}
		else
		{
			canJump = false;
			Debug.LogError("IsNotGrounded");


		}






	}
}
