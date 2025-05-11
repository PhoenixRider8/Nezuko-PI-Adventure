using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    public float xRotation = 0f;

    [Header("Sensitivity")]
    public float xSen = 30f;
    public float ySen = 30f;

    //Process look
    public void ProcessLook(Vector2 input)
    {
        float moveX = input.x;
        float moveY = input.y;

        xRotation -= (moveY * Time.deltaTime) * ySen;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        //cam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); //To look up down

        transform.Rotate(Vector3.up * (moveX * Time.deltaTime) * xSen); //To look left right
    }
}