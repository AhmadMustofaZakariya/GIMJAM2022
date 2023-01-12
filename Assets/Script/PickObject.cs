using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickObject : MonoBehaviour, IInteractable
{
    [SerializeField] private string interactText;
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void Pick()
    {
        Debug.Log("Object Picked");
        //play cutsceene

        //play bgm meme
    }

    public string GetInteractText()
    {
        return interactText;
    }

    public void Interact(Transform interactorTransform)
    {
        Pick();
    }
}
