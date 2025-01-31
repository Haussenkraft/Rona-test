using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;

    public InputAction playerControls;

    Vector2 moveDirection = Vector2.zero;
    public float moveSpeed = 5f;
 
    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame

    void Update()
    {
        moveDirection = playerControls.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        controller.Move(transform.TransformDirection(moveDirection) * moveSpeed * Time.deltaTime);

    }
}
