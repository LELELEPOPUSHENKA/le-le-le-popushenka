using UnityEngine;

public class AnimatiiMena : MonoBehaviour
{
    public Animator animator;
    int izWalkingHash, izRunningHash, izJumpHash, izDancingHash;
    void Start()
    {
        animator = GetComponent<Animator>();
        izWalkingHash = Animator.StringToHash("izHoditi");
        izRunningHash = Animator.StringToHash("izBeg");
        izJumpHash = Animator.StringToHash("izPrizhok");
        izDancingHash = Animator.StringToHash("izTanci");
    }

    void Update()
    {
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");
        bool dancingPressed = Input.GetKey("g");
        bool JumpPressed = Input.GetKey("space");

        if (forwardPressed)
        {
            animator.SetBool(izWalkingHash, true);
        }
        else animator.SetBool(izWalkingHash, false);

        if (forwardPressed && runPressed)
        {
            animator.SetBool(izRunningHash, true);
        }
        else animator.SetBool(izRunningHash, false);

        if (dancingPressed)
        {
            animator.SetBool(izDancingHash, true);
        }
        else animator.SetBool(izDancingHash, false);

        if (JumpPressed)
        {
            animator.SetBool(izJumpHash, true);
        }
        else animator.SetBool(izJumpHash, false);
    }
}
