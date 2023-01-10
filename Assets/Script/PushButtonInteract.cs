using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButtonInteract : MonoBehaviour
{
    [SerializeField] private string interactText;
    private Animator animator;
    private bool isOpen;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void Interact()
    {
        isOpen = !isOpen;
        //animator.SetBool("IsOpen", isOpen);
        Debug.Log("Door is Open");
    }

    public string GetInteractText()
    {
        return interactText;
    }
}
