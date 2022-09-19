using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnBecameInvisible : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Debug.Log(name + " became invisible. Destroyed.");
        Destroy(gameObject);
    }
}
