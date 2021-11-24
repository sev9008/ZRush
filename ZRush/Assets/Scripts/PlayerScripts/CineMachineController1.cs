using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;
public class CineMachineController1 : MonoBehaviour
{
    public CinemachineVirtualCamera aimVirtualCamera;
    public bool aiming;
    public void IsAiming(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            aimVirtualCamera.gameObject.SetActive(true);
        }
        if (context.canceled)
        {
            aimVirtualCamera.gameObject.SetActive(false);
        }
    }
}
