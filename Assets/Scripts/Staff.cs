using UnityEngine;

public class Staff : MonoBehaviour
{
    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void PlayAttack()
    {
        animator.SetTrigger("Attack");
    }
}