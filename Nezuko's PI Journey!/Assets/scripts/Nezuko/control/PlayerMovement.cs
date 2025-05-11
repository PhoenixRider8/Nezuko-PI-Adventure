using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    //Character Controller
    CharacterController controller;
    private Vector3 playerVelocity;
    public float speed = 5f;

    [SerializeField] Text PIVal;
    [SerializeField] Camera cam;

    //Jump
    private bool isGrounded;
    private float gravity = -9.8f;
    public float JumpLimit = 3f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        isGrounded = controller.isGrounded; //Check for ground (for any mesh with collider)
    }

    public void Jump()
    {
        if (isGrounded)
        {
            playerVelocity.y = Mathf.Sqrt(JumpLimit * -3f * gravity); //jump till jumpLimit
        }
    }

    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirect = Vector3.zero;

        moveDirect.x = input.x; //A and D key inputs
        moveDirect.z = input.y; //W and S key inputs

        controller.Move(transform.TransformDirection(moveDirect) * speed * Time.deltaTime); //move towards moveDirect

        //Gravity
        playerVelocity.y += gravity * Time.deltaTime;
        if (isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        controller.Move(playerVelocity * Time.deltaTime);
    }

    public void startGame()
    {
        print("Time to play");
        // Get the CinemachineBrain component from the main camera
        CinemachineBrain cinemachineBrain = Camera.main.GetComponent<CinemachineBrain>();

        // Get the active virtual camera (if any)
        CinemachineVirtualCamera activeVirtualCamera = cinemachineBrain.ActiveVirtualCamera as CinemachineVirtualCamera;

        // Disable the active virtual camera (if any)
        if (activeVirtualCamera != null)
        {
            activeVirtualCamera.gameObject.SetActive(false);
        }

        cam.gameObject.SetActive(true);

        PIVal.gameObject.SetActive(true);
        MazeManager.GameIndex = 0;

        // Make the main camera active (if needed)
        // (This is usually done by default when virtual cameras are disabled)
    }
}