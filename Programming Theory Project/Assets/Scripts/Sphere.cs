using UnityEngine;

// INHERITANCE
public class Sphere : Shape
{
    // POLYMORPHISM
    public override float Volume()
    {
        return 4 * Mathf.PI * Mathf.Pow(Radius(), 3) / 3;
    }

    // POLYMORPHISM
    public override float Surface()
    {
        return 4 * Mathf.PI * Mathf.Pow(Radius(), 2);
    }
}
