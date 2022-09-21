using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableDoor : Interactable
{
    private SpriteRenderer _renderer;
    private BoxCollider2D _boxCollider;

    private bool _isOpen = false;
    public bool isOpen
    {
        get { return _isOpen; }
        set
        {
            if (_isOpen != value)
            {
                _isOpen = value;

                if (_isOpen)
                {
                    _renderer.enabled = false;
                    _boxCollider.isTrigger = true;
                }
                else
                {
                    _renderer.enabled = true;
                    _boxCollider.isTrigger = false;
                }
            }
        }
    }
    private void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _boxCollider = GetComponent<BoxCollider2D>();
    }

    public override bool Interact()
    {
        isOpen = !isOpen;
        return true;
    }
}
