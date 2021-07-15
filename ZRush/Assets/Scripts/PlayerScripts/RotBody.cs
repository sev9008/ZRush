using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotBody : MonoBehaviour
{
    private Transform CameraTransform;
    //variables for rotatebody
    public GameObject PlayerBody;
    public float RotLerpSpeed = 0;
    private void Start()
    {
        CameraTransform = Camera.main.transform;
    }

    void FixedUpdate()
    {
        RotateBody();
    }

    /// <summary>
    /// This will rotate the body of the palyer to follow thje camera's rotation
    /// </summary>
    private void RotateBody()
    {
        Vector3 Originrot = PlayerBody.transform.eulerAngles;
        Vector3 rot = PlayerBody.transform.eulerAngles;
        rot.y = CameraTransform.eulerAngles.y;
        Quaternion OR = Quaternion.Euler(Originrot);
        Quaternion R = Quaternion.Euler(rot);

        PlayerBody.transform.rotation = Quaternion.Lerp(OR, R, Time.deltaTime * RotLerpSpeed);
        //PlayerBody.transform.rotation = R;
    }
}
