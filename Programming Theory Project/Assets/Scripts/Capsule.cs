using UnityEngine;

// INHERITANCE
public class Capsule : Shape
{
    // POLYMORPHISM
    public override float Volume()
    {
        return (4 * Mathf.PI * Mathf.Pow(Radius(), 3) / 3) + (Mathf.PI * Mathf.Pow(Radius(), 2) * height);
    }

    // POLYMORPHISM
    public override float Surface()
    {
        return SphereSurfaceArea() + LateralSurfaceArea();
    }

    // ABSTRACTION
    private float SphereSurfaceArea()
    {
        return 4 * Mathf.PI * Mathf.Pow(Radius(), 2);
    }

    // ABSTRACTION
    private float LateralSurfaceArea()
    {
        return 2 * Mathf.PI * Radius();
    }
}
