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
        if (pm.movement.x == 1)
        {
            anim.SetBool("directionRight", true);
            anim.SetBool("directionLeft", false);
            anim.SetBool("directionUp", false);
            anim.SetBool("directionDown", false);
        }
        if (pm.movement.x == -1)
        {
            anim.SetBool("directionRight", false);
            anim.SetBool("directionLeft", true);
            anim.SetBool("directionUp", false);
            anim.SetBool("directionDown", false);
        }
        if (pm.movement.y == 1)
        {
            anim.SetBool("directionRight", false);
            anim.SetBool("directionLeft", false);
            anim.SetBool("directionUp", true);
            anim.SetBool("directionDown", false);
        }
        if (pm.movement.y == -1)
        {
            anim.SetBool("directionRight", false);
            anim.SetBool("directionLeft", false);
            anim.SetBool("directionUp", false);
            anim.SetBool("directionDown", true);
        }
        if (pm.currentSpeed == pm.walkSpeed)
        {
            anim.SetBool("walking", true);
            anim.SetBool("running", false);
        }
        if (pm.currentSpeed == pm.runSpeed)
        {
            anim.SetBool("running", true);
            anim.SetBool("walking", false);
        }
        if (!pm.isMoving)
        {
            anim.SetBool("running", false);
            anim.SetBool("walking", false);
        }
    }
}
