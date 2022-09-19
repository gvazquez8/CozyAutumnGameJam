using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerProperties : MonoBehaviour
{
    public enum SpawnDirection
    {
        Up,
        Down,
        Left,
        Right,
    };

    public SpawnDirection facing;

    public Vector2 GetDirectionVector()
    {
        Vector2 direction;

        switch (facing)
        {
            case SpawnDirection.Up:
                direction = Vector2.up;
                break;
            case SpawnDirection.Down:
                direction = Vector2.down;
                break;
            case SpawnDirection.Left:
                direction = Vector2.left;
                break;
            case SpawnDirection.Right:
                direction = Vector2.right;
                break;
            default:
                direction = Vector2.zero;
                break;
        }

        return direction;
    }
}
