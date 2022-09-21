using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class PlayerInteraction : MonoBehaviour
{
    public bool isBusy = false;
    public Interactable interaction;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Interactable interactable = collision.gameObject.GetComponent<Interactable>();

        if (interactable != null)
        {
            interaction = interactable;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Interactable interactable = collision.gameObject.GetComponent<Interactable>();
        
        if (interactable != null)
        {
            if (interactable.Equals(interaction))
            {
                interaction = null;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Interactable interactable = collider.gameObject.GetComponent<Interactable>();

        if (interactable != null)
        {
            interaction = interactable;
        }
    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        Interactable interactable = collider.gameObject.GetComponent<Interactable>();

        if (interactable != null)
        {
            if (interactable.Equals(interaction))
            {
                interaction = null;
            }
        }
    }

    private void Update()
    {
        if (!isBusy && Input.GetButtonDown("Fire1"))
        {
            interaction?.Interact();
        }
    }
}
