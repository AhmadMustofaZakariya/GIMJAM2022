using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float jumpForce = 4f;
    [SerializeField] float speed = 0.2f;
    private Animator animator;
    private Rigidbody rb;
    private PlayerInput playerInput;
    private PlayerInputActions playerInputActions;
    private PickObject pickObject;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
        animator = GetComponent<Animator>();

        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
        playerInputActions.Player.Jump.performed += Jump;
        playerInputActions.Player.Run.performed += Run;
        playerInputActions.Player.Run.canceled += RunCanceled;
    }

    private void RunCanceled(InputAction.CallbackContext context)
    {
        if (context.canceled)
        {
            speed = 0.2f;
            animator.SetBool("running", false);
        }
    }

    private void Run(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            speed = 0.3f;
            animator.SetBool("running", true);
        }
    }

    private void Jump(InputAction.CallbackContext context)
    {
        Debug.Log("Jump1!");
        if (context.performed)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            animator.SetBool("jump", true);
        }
    }

    private void FixedUpdate()
    {
        Vector2 inputVector = playerInputActions.Player.Movement.ReadValue<Vector2>();
        Vector3 movement = new Vector3(inputVector.x, 0, inputVector.y);
        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);
        }
        rb.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Impulse);

        animator.SetFloat("speed", rb.velocity.magnitude);
    }
    
}
