using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))] // forces Rigidbody2D to be needed
public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed = 5f; // float for walkspeed that can be changed in editor
    public float runSpeed = 8f; // float for runspeed that can be changed in editor

    public float currentSpeed; // used to change the speed if walking or running
    public bool isMoving; // used to check if player is moving, for animator
    public Vector2 movement; // vector2 to track directional movement
    public Rigidbody2D rb2D; // simplifies Rigidbody2D
    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>(); // gets object rigidbody
        currentSpeed = walkSpeed;
    }

    void Update()
    {
        rb2D.linearVelocity = movement * currentSpeed;
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        movement = ctx.ReadValue<Vector2>(); // gets the direction of the input
        if (ctx.ReadValue<Vector2>() != Vector2.zero) // if the ctx is not at 0,0 you are moving
        {
            isMoving = true;
        }
        else{
            isMoving = false;
        }
    }

    public void Sprint(InputAction.CallbackContext ctx)
    {
        // if shift is pressed, have running speed, if not, have walking speed
        if(ctx.ReadValue<float>() == 1) 
        {
            currentSpeed = runSpeed;
        }
        else
        {
            currentSpeed = walkSpeed;
        }
    }
}
