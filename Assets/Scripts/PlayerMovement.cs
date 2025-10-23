using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed = 5f;
    public float runSpeed = 8f;

    private float currentSpeed;
    private Vector2 movement;
    private Rigidbody2D rb2D;
    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        currentSpeed = walkSpeed;
    }

    void Update()
    {
        rb2D.linearVelocity = movement * currentSpeed;
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        movement = ctx.ReadValue<Vector2>();
    }

    public void Sprint(InputAction.CallbackContext ctx)
    {
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
