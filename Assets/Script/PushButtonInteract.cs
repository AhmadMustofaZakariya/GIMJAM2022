using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButtonInteract : MonoBehaviour, IInteractable
{
    [SerializeField] private string interactText;
    private Animator animator;
    private bool isOpen;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void ToggleDoor()
    {
        isOpen = !isOpen;
        animator.SetBool("IsOpen", isOpen);
    }

    public string GetInteractText()
    {
        return interactText;
    }

    public void Interact(Transform interactorTransform)
    {
        ToggleDoor();
    }
}
