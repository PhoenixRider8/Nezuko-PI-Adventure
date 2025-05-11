using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    //InputMap
    private PlayerControls input;
    private PlayerControls.OnFootActions onFoot;

    //PlayerMovement
    PlayerMovement movement;

    //PlayerLook
    PlayerLook look;

    private void Awake()
    {
        movement = GetComponent<PlayerMovement>();
        look = GetComponent<PlayerLook>();

        input = new PlayerControls(); //Since we are not attaching PlayerControls script to any GameObject, so we use "new" keyword
        onFoot = input.OnFoot;
        onFoot.Jump.performed += ctx => movement.Jump(); //jump action perfromed
    }

    private void FixedUpdate()
    {
        movement.ProcessMove(onFoot.Movement.ReadValue<Vector2>());  //Send ReadValue of Vector2 type
    }

    private void LateUpdate()
    {
        look.ProcessLook(onFoot.Look.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        onFoot.Enable();
    }

    private void OnDisable()
    {
        onFoot.Disable();
    }
}