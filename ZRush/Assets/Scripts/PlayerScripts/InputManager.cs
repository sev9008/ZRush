using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is the class for our user inputs.  
/// This way other scripts that interact with input system wont need to instantiate it.
/// 
/// its basically a singleton object that will always be in the scene
/// It will constantly check if the input manager ahs recieved any input
/// </summary>
public class InputManager : MonoBehaviour
{
    
    private static InputManager _instance;

    public static InputManager Instance
    {
        get
        {
            return _instance;
        }
    }

    private PlayerActs playerControls;

    private void Awake()
    {
        if (_instance != null && Instance != this)//this case statement will delete itself if an instance of this singleton object already exists in the scene
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }

        playerControls = new PlayerActs();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }
    public Vector2 GetPlayerMovement()
    {
        return playerControls.Player.Movement.ReadValue<Vector2>();
    }
    public Vector2 GetMouseDelta()
    {
        return playerControls.Player.Look.ReadValue<Vector2>();
    }
    public Vector2 GetMousePosition()
    {
        return playerControls.Player.MouePosition.ReadValue<Vector2>();
    }
    public float GetScrollWheel()
    {
        return playerControls.Player.ScrollWheelY.ReadValue<float>();
    }
    public bool PlayerJump()
    {
        return playerControls.Player.Jump.triggered;
    }
    public float PlayerFireLMB()
    {
        return playerControls.Player.FireLMB.ReadValue<float>();
    }
    public float PlayerFireRMB()
    {
        return playerControls.Player.FireRMB.ReadValue<float>();
    }
    public bool PlayerReload()
    {
        return playerControls.Player.Reload.triggered;
    }
    public bool PlayerCrouch()
    {
        return playerControls.Player.Crouch.triggered;
    }
    public float PlayerSprint()
    {
        return playerControls.Player.Sprint.ReadValue<float>();
    }

    /*
    public bool PlayerAbility1()
    {
        return playerControls.Player.Ability1.triggered;
    }
    public bool PlayerAbility2()
    {
        return playerControls.Player.Ability2.triggered;
    }
    public bool PlayerAbility3()
    {
        return playerControls.Player.Ability3.triggered;
    }
    public bool PlayerAbility4()
    {
        return playerControls.Player.Ability4.triggered;
    }
    public bool PlayerAbility5()
    {
        return playerControls.Player.Ability5.triggered;
    }
    public bool PlayerAbility6()
    {
        return playerControls.Player.Ability6.triggered;
    }
    public bool PlayerAbility7()
    {
        return playerControls.Player.Ability7.triggered;
    }
    public bool PlayerAbility8()
    {
        return playerControls.Player.Ability8.triggered;
    }
    public bool PlayerAbility9()
    {
        return playerControls.Player.Ability9.triggered;
    }
        

    public bool DebugSpawnWave()
    {
        return playerControls.Player.DebugSpawnWave.triggered;
    }
    public bool DebugKillWave()
    {
        return playerControls.Player.DebugKillWave.triggered;
    }
    public bool DebugStopWave()
    {
        return playerControls.Player.DebugStopWave.triggered;
    }
    */




    //public float GetScrollDown()
    //{
    //    Debug.Log("ScrollDown");
    //    return playerControls.Player.ScrollDown.ReadValue<float>();
    //}
    //public bool PlayerDash()
    //{
    //    return playerControls.Player.Dash.triggered;
    //}
    //public float PlayerLeanLeft()
    //{
    //    return playerControls.Player.LeanLeft.ReadValue<float>();
    //}
    //public float PlayerLeanRight()
    //{
    //    return playerControls.Player.LeanRight.ReadValue<float>();
    //}
}
