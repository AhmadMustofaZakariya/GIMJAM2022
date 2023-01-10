using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray)
            {
                if(collider.TryGetComponent(out PushButtonInteract pushButtonInteract))
                {
                    pushButtonInteract.Interact();
                }
            }
        }       
    }

    public PushButtonInteract GetInteractableObject()
    {
        float interactRange = 2f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {
            if (collider.TryGetComponent(out PushButtonInteract pushButtonInteract))
            {
                return pushButtonInteract;
            }
        }
        return null;
    }
}
