using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CharacterController))]
public class RunCharacter : MonoBehaviour
{
	static readonly int runState = Animator.StringToHash("Base Layer.Run");
	static readonly int jumpState = Animator.StringToHash("Base Layer.Jump");

	[SerializeField] CharacterController charController;

	Animator animator;
	AnimatorStateInfo currentState;
	StageEvent currentStageEvent;

	float speed = 0f;

	Transform cachedTransform = null;
	Transform CachedTransform { get { return cachedTransform ?? (cachedTransform = transform); } }

	public Vector3 Position
	{
		get { return CachedTransform.position; }
		set { CachedTransform.position = value; }
	}

	public Vector3 CenterPosition
	{
		get { return CachedTransform.TransformPoint(charController.center); }
	}

	bool InEvent { get{ return (currentStageEvent != null); } }

	bool IsJumpState { get { return (currentState.fullPathHash == jumpState); } }

	public bool IsAvairableRun
	{
		get
		{
			if (InEvent && currentStageEvent.IsFailed) return false;
			if (!IsJumpState) return true;
			return false;
		}
	}

	public bool IsAvairableInput
	{
		get { return !IsJumpState; }
	}

	float JumpAnimationSpeed { get { return 1f; } }

	void Start()
	{
		this.animator = GetComponent<Animator>();
	}

	void Update()
	{
		const float accelPerSecond = 0.5f;


		if (IsAvairableRun) speed += accelPerSecond * Time.deltaTime;
		else if (IsJumpState) speed = JumpAnimationSpeed;
		else speed = 0f;
		speed = Mathf.Clamp01(speed);

		UpdateMove();

		animator.SetFloat("Speed", speed);			
		currentState = animator.GetCurrentAnimatorStateInfo(0);
		if (currentState.fullPathHash == runState) UpdateStateRun();
	}

	void UpdateMove()
	{
		const float runThreshold = 0.1f;
		const float runSpeed = 7f;		
		const float jumpSpeed = 4.5f;	

		float forwardSpeed = speed;
		if (speed > runThreshold)
			forwardSpeed *= (IsJumpState) ? jumpSpeed : runSpeed;

		Vector3 velocity = new Vector3(0f, 0f, forwardSpeed);
		velocity = CachedTransform.TransformDirection(velocity); 
		CachedTransform.localPosition += velocity * Time.deltaTime;
	}

	void UpdateStateRun()
	{	if (!IsAvairableInput) return;
		if (InEvent) return;
		if (!InputController.GetClick()) return;
		Jump();
	}

	public void OnEventEnter(StageEvent stageEvent)
	{
		currentStageEvent = stageEvent;
	}

	public void OnEventExit()
	{
		currentStageEvent = null;
	}

	public void Jump()
	{
		if (animator.IsInTransition(0)) return;
		animator.SetTrigger("Jump");
	}
}
