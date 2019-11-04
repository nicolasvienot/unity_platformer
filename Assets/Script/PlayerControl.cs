using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
	public Rigidbody2D rb;
	Animator m_Animator;

	public Transform groundCheck;
	public Transform stuckCheck;
	public float groundCheckRadius;
	public float stuckCheckRadius;
	public LayerMask whatIsGround;
	public LayerMask whatIsStuck;
	private bool onGround;
	private bool onStuck;
	public bool facingRight = true;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		m_Animator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
		float h = Input.GetAxis("Horizontal");
		if(h > 0 && !facingRight)
			Flip();
		else if(h < 0 && facingRight)
			Flip();
		
//		// RIGHT
//
//		bool rdown = Input.GetKeyDown(KeyCode.RightArrow);
//		bool rheld = Input.GetKey(KeyCode.RightArrow);
//		bool rup = Input.GetKeyUp(KeyCode.RightArrow);
//
//		if (rdown) {
//			m_Animator.SetTrigger("run");
//			Debug.Log(Screen.width);
//		}
//		if (rheld)
//		{	
//			rb.velocity = new Vector2(3, rb.velocity.y);
//		}
//		if (rup) {
//			m_Animator.ResetTrigger("run");
//			m_Animator.SetTrigger("iddle");
//		}
//
//		// LEFT
//
//		bool ldown = Input.GetKeyDown(KeyCode.LeftArrow);
//		bool lheld = Input.GetKey(KeyCode.LeftArrow);
//		bool lup = Input.GetKeyUp(KeyCode.LeftArrow);
//
//		if (ldown) {
//			m_Animator.SetTrigger("run");
//		}
//		if (lheld)
//		{	
//			rb.velocity = new Vector2(-3, rb.velocity.y);
//		}
//		if (lup) {
//			m_Animator.ResetTrigger("run");
//			m_Animator.SetTrigger("iddle");
//		}
//
//		// JUMP
//
		onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
		onStuck = Physics2D.OverlapCircle(stuckCheck.position, stuckCheckRadius, whatIsStuck);
		
//		if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.UpArrow)) && (onGround || onStuck))
//		{
////		m_Animator.ResetTrigger("iddle");
//			m_Animator.SetTrigger("JumpTrigg");
//			rb.velocity = new Vector2(rb.velocity.x, 5);
//		}
//		if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.UpArrow)) && onStuck)
//		{
//			m_Animator.SetTrigger("JumpTrigg");
//
//			rb.velocity = new Vector2(rb.velocity.x, 5);
//		}


		// ANDROID PART

		//		if (Input.touchCount == 1)
		//		{
		//			rb.velocity = new Vector2(3, rb.velocity.y);
		//		}
		//		if (Input.touchCount == 2 && rb.velocity.x == 0)
		//		{
		//			rb.velocity = new Vector2(rb.velocity.x, 4);
		//		}
	

//		foreach(Touch touch in Input.touches)
//		{
//
//			// RIGHT
//
//			if (touch.phase == TouchPhase.Began && touch.position.x > 2000 )
//			{
//				m_Animator.SetTrigger("run");
//			}
//			if ((touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary) && touch.position.x > 2000 )
//			{
//				rb.velocity = new Vector2(3, rb.velocity.y);
//			}
//			if (touch.phase == TouchPhase.Ended && touch.position.x > 2000 )
//			{
//				m_Animator.ResetTrigger("run");
//				m_Animator.SetTrigger("iddle");
//			}
//
//			// LEFT
//
//			if (touch.phase == TouchPhase.Began && touch.position.x < 1000 )
//			{
//				m_Animator.SetTrigger("run");
//			}
//			if ((touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary) && touch.position.x < 1000 )
//			{
//				rb.velocity = new Vector2(-3, rb.velocity.y);
//			}
//			if (touch.phase == TouchPhase.Ended && touch.position.x < 1000 )
//			{
//				m_Animator.ResetTrigger("run");
//				m_Animator.SetTrigger("iddle");
//			}
//
//			// JUMP
//
//			if (touch.phase == TouchPhase.Began && touch.position.x > 1000 && touch.position.x < 2000 && (onGround || onStuck))
//			{
//				m_Animator.SetTrigger("JumpTrigg");
//				rb.velocity = new Vector2(rb.velocity.x, 5);
//			}
//			if ((touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary) && touch.position.x > 1000 && touch.position.x < 2000 && (onGround || onStuck))
//			{
//				m_Animator.SetTrigger("JumpTrigg");
//				rb.velocity = new Vector2(rb.velocity.x, 5);
//			}
//			if (touch.phase == TouchPhase.Ended && touch.position.x > 1000 && touch.position.x < 2000 && (onGround || onStuck))
//			{
//				m_Animator.SetTrigger("JumpTrigg");
//				rb.velocity = new Vector2(rb.velocity.x, 5);
//			}
//		}


		foreach(Touch touch in Input.touches)
		{

			// RIGHT

			if (touch.phase == TouchPhase.Began && touch.position.x > ((Screen.width / 3) * 2) )
			{
				m_Animator.SetTrigger("run");
			}
			if ((touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary) && touch.position.x > ((Screen.width / 3) * 2) )
			{
				rb.velocity = new Vector2(3, rb.velocity.y);
			}
			if (touch.phase == TouchPhase.Ended && touch.position.x > ((Screen.width / 3) * 2) )
			{
				m_Animator.ResetTrigger("run");
				m_Animator.SetTrigger("iddle");
			}
//
//			// LEFT
//
			if (touch.phase == TouchPhase.Began && touch.position.x < (Screen.width / 3) )
			{
				m_Animator.SetTrigger("run");
			}
			if ((touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary) && touch.position.x < (Screen.width / 3) )
			{
				rb.velocity = new Vector2(-3, rb.velocity.y);
			}
			if (touch.phase == TouchPhase.Ended && touch.position.x < (Screen.width / 3) )
			{
				m_Animator.ResetTrigger("run");
				m_Animator.SetTrigger("iddle");
			}
//
			// JUMP
			if (touch.phase == TouchPhase.Began && touch.position.x > (Screen.width / 3) && touch.position.x < ((Screen.width / 3) * 2) && (onGround || onStuck))
			{
				m_Animator.ResetTrigger("iddle");
				m_Animator.SetTrigger("JumpTrigg");
				rb.velocity = new Vector2(rb.velocity.x, 5);
			}
//			if ((touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary) && touch.position.x > (Screen.width / 3) && touch.position.x < (Screen.width / 3 * 2) && (onGround || onStuck))
//			{
//				m_Animator.SetTrigger("JumpTrigg");
//				rb.velocity = new Vector2(rb.velocity.x, 5);
//			}
//			if (touch.phase == TouchPhase.Ended && touch.position.x > (Screen.width / 3) && touch.position.x < (Screen.width / 3 * 2) && (onGround || onStuck))
//			{
//				m_Animator.SetTrigger("JumpTrigg");
//				rb.velocity = new Vector2(rb.velocity.x, 5);
//			}
		}
	}

	void Flip ()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
