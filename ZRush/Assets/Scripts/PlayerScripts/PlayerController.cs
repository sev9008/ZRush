using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// this script should be used for the movement and player controls.
/// this does not necesarrily include everything the player can do
/// planned functions include:
/// 
/// first or third person switching
/// mantle
/// jump
/// slide
/// crouch
/// sprint (maybe jsut make player run faster when they have no weapon out)
/// </summary>
public class PlayerController : MonoBehaviour
{
    
    //misc variables
    private InputManager inputManager;
    [SerializeField]
    private float MovespeedControler;

    //variables for moving
    private float playerSpeed;
    private CharacterController controller;
    private Vector3 playerVelocity = Vector3.zero;
    public GameObject PlayerBody;
    [SerializeField]
    private bool isSprinting;

    //variables for is grounded
    [SerializeField]
    private bool IsGrounded;
    public LayerMask GroundMask;
    public Transform GroundCheck;
    private float GroundDistance = 0.1f;

    //variables for jumping
    [SerializeField]
    private float JumpVel = 1.0f;
    [SerializeField]
    private float gravityValue = -9.81f;
    [SerializeField]
    private bool Jumping;
    [SerializeField]
    private float fallmult = 2.5f; //increase gravity pull for better feel    
    [SerializeField]
    private bool CanDBLJump;
    private float jumptimer = .1f;
    private float timercount;



    //variables for character size
    private float height;

    //varialbes for onslope
    [SerializeField]
    private bool IsOnSlope;
    [SerializeField]
    private float SlopeRayLength = 1.5f;
    [SerializeField]
    private float SlopeForce = 50f;

    //public Animator Player_AnimatorFull;


    /// <summary>
    /// Get the character controller, input manager, and the main scene's camera
    /// </summary>
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        inputManager = InputManager.Instance;
        //CameraTransform = Camera.main.transform;
        height = controller.height;
    }
    void Update()
    {
        Jump();
        SpeedController();
    }
    void FixedUpdate()
    {
        CheckIsGrounded();
        Move();

        //OnSlope();//executes additional gravity to cause palyer to hug slopes
    }

    /// <summary>
    /// check fi the character is grounded.  
    /// first run a spherecast to see if the ground is within a certain distance from teh character's feet
    /// if this is false then use CharacterController.isgrounded
    /// 
    /// the reason this is done is because CharacterController.isgrounded is really inconsitent.  So I perfer to just use both to appease the unity gods
    /// </summary>
    private void CheckIsGrounded()
    {
        IsGrounded = Physics.CheckSphere(GroundCheck.position, GroundDistance, GroundMask, QueryTriggerInteraction.Ignore);
        if (!IsGrounded)
        {
            IsGrounded = controller.isGrounded;
        }
    }
    /// <summary>
    /// This function controls the jumping of the palyer
    /// </summary>
    private void Jump()
    {
        if (inputManager.PlayerJump())
        {
            if (IsGrounded)
            {
                playerVelocity.y = Mathf.Sqrt(JumpVel * -1f * gravityValue);//apply upwords movement only then the palyer is grounded and jump is pressed
                IsGrounded = false;
                Jumping = true;
                CanDBLJump = true;
                timercount = 0;
                return;
            }
            else if (CanDBLJump)
            {
                playerVelocity.y = Mathf.Sqrt(JumpVel * -1f * gravityValue);//apply upwords movement only then the palyer is grounded and jump is pressed
                Jumping = true;
                CanDBLJump = false;
                timercount = 0;
                return;
            }
        }
        //else if (!inputManager.PlayerJump() && Jumping)
        if (Jumping)
        {
            timercount += Time.deltaTime;//wait for .1 seconds then check if it is grounded or not
            if (IsGrounded && timercount > jumptimer)
            {
                Debug.Log("grounded");
                Jumping = false;
                CanDBLJump = false;
            }
        }

        if (!IsGrounded)
        {
            playerVelocity += Vector3.up * gravityValue * (2.5f - 1) * Time.deltaTime; // increases fall gravity for better feel when not grounded
        }

        controller.Move(playerVelocity * Time.deltaTime);
    }

    /// <summary>
    /// Controls the speed of teh character
    /// </summary>
    private void SpeedController()//add speed change for sprinting and sliding
    {
        if (inputManager.PlayerSprint() != 0)
        {
            playerSpeed = MovespeedControler * 2f;
            isSprinting = true;
        }
        else
        {
            playerSpeed = MovespeedControler;
            isSprinting = false;
        }
    }

    /// <summary>
    /// This function applies movement to the player
    /// </summary>
    private void Move()
    {
        Vector3 movement = inputManager.GetPlayerMovement();
        //Debug.Log(movement);

        //if we set this to camera transform forward it will go slow as camera transform will sometimes point into the ground
        Vector3 move = PlayerBody.transform.right * movement.x + PlayerBody.transform.forward * movement.y;
        move = Vector3.ClampMagnitude(move, 1f);

        controller.Move(move * playerSpeed * Time.deltaTime);//used for moving
    }

    private void OnSlope()
    {
        Vector3 movement = inputManager.GetPlayerMovement();

        if (Jumping || inputManager.PlayerJump())
        {
            IsOnSlope = false;
            Jump();
            return;
        }

        //Debug.DrawRay(transform.position, Vector3.down * height / 2 * SlopeRayLength, Color.red);
        if (Physics.Raycast(transform.position, Vector3.down, out var hit, height / 2 * SlopeRayLength))
        {
            if (hit.normal != Vector3.up)
            {
                IsOnSlope = true;
            }
            else
            {
                IsOnSlope = false;
            }
        }
        else
        {
            IsOnSlope = false;
        }

        //if (!IsGrounded && sliding && IsOnSlope)//increase gravity alot so slide can hug the ground
        //{
        //    SlideForce.y -= 2000 * Time.deltaTime;
        //}

        if ((movement.y != 0 || movement.x != 0) && IsOnSlope && !IsGrounded)
        {
            Debug.Log("apply slope force");
            controller.Move(Vector3.down * height / 2 * SlopeForce * Time.deltaTime);
        }
    }
    
}