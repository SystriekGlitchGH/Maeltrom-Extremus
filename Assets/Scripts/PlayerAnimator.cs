using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public PlayerMovement pm;
    private Animator anim;
    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (pm.currentSpeed == pm.walkSpeed && pm.isMoving)
        {
            anim.SetBool("walking", true);
            anim.SetBool("running", false);
            anim.SetFloat("moveX", pm.movement.x);
            anim.SetFloat("moveY", pm.movement.y);
        }
        if (pm.currentSpeed == pm.runSpeed && pm.isMoving)
        {
            anim.SetBool("running", true);
            anim.SetBool("walking", false);
            anim.SetFloat("moveX", pm.movement.x);
            anim.SetFloat("moveY", pm.movement.y);
        }
        if (!pm.isMoving)
        {
            anim.SetBool("running", false);
            anim.SetBool("walking", false);
        }
    }
}
