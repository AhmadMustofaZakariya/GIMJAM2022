using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickObject : MonoBehaviour, IInteractable
{
    [SerializeField] private string interactText;
    private Animator animator;
    public GameObject videoPlayer;
    public int timeStop;
    private void Awake()
    {
        videoPlayer.SetActive(false);
    }
    public void Pick()
    {
        Debug.Log("Object Picked");
        //play cutsceene
        videoPlayer.SetActive(true);
        Destroy(videoPlayer, timeStop);
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
