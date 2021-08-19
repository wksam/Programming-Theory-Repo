using System;
using UnityEngine;

// INHERITANCE
public class Shape : MonoBehaviour
{
    // ENCAPSULATION
    protected float width, height, length;
    public static event Action<Shape> OnMouseOverObject;
    public static event Action OnMouseExitObject;

    private void Start()
    {
        width = transform.localScale.x;
        height = transform.localScale.y;
        length = transform.localScale.z;
    }

    // ABSTRACTION
    public virtual float Volume()
    {
        return width * height * length;
    }

    // ABSTRACTION
    public virtual float Surface()
    {
        return width * height;
    }

    // ABSTRACTION
    protected float Radius()
    {
        return width / 2;
    }

    private void OnMouseOver()
    {
        OnMouseOverObject(this);
    }

    private void OnMouseExit()
    {
        OnMouseExitObject();
    }
}
