using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AnimatiaPalki : MonoBehaviour
{
    private Animator animator;
    private string animationTrigger = "PlayAnimation";

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger(animationTrigger);
        }
    }
}