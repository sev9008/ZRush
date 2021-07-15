using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
//Sometimes this script will get a NullReferenceException.  Im guessing since cinemachine has its own scripts that it uses during runtime it will cause this error when the game isnt running


public class CinemachinePOVextension : CinemachineExtension
{
    
    [SerializeField]
    private float HorizontalSpeed;  //set the mouse sensitivity on the horizontal axis  
    [SerializeField]
    private float Verticalspeed;  //set the mouse sensitivity on the vertical axis 
    [SerializeField]
    private float UpclampAngle = 80f;//this will clamp the camera so it cant look exactly straight up
    [SerializeField]
    private float DownclampAngle = 80f;//this will clamp the camera so it cant look exactly straight up

    private InputManager inputManager;
    private Vector3 startingRotation;

    protected override void Awake()
    {
        inputManager = InputManager.Instance;//get the input manager in the scene
        base.Awake();
    }
    /// <summary>
    /// this fucntion overrides the Cinemachnine mouse input to accept the input manager input
    /// Pretty sure there is an easier way to do this, but the tutorial iw atched suggested this method.
    /// It works so who am I to argue.
    /// </summary>
    protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        //should probably add another if statement here so if controls are disabled the palyer cant look around
        //this could be wierd for cutscenes
        if (vcam.Follow)//if the camera has a follow target
        {
            if (stage == CinemachineCore.Stage.Aim)//override the aim target during stage three of cinemachine pipeline
            {
                if (startingRotation == null)
                {
                    startingRotation = transform.localRotation.eulerAngles;
                }
                Vector2 deltaInput = inputManager.GetMouseDelta();//get the mouse movement from input manager
                startingRotation.x += deltaInput.x * Verticalspeed * Time.deltaTime;//apply x and y rotation * sensitivity to a vector3.
                startingRotation.y += deltaInput.y * HorizontalSpeed * Time.deltaTime;
                startingRotation.y = Mathf.Clamp(startingRotation.y, -DownclampAngle, UpclampAngle);//clamp the vertical look rotation.
                state.RawOrientation = Quaternion.Euler(-startingRotation.y, startingRotation.x, 0f);//apply the vector 3 rotation to the player
            }
        }
    }
}
