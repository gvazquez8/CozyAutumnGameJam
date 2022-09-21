using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Interactable : MonoBehaviour
{
    public virtual bool Interact()
    {
        Debug.LogWarning(gameObject.name + ": Base Interact() called.");
        return true;
    }
}
