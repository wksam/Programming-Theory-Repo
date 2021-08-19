using UnityEngine;

// INHERITANCE
public class Cylinder : Shape
{
    // POLYMORPHISM
    public override float Volume()
    {
        return CircleSurfaceArea() * Height();
    }

    // POLYMORPHISM
    public override float Surface()
    {
        return (2 * CircleSurfaceArea()) + LateralSurfaceArea();
    }

    // ABSTRACTION
    private float CircleSurfaceArea()
    {
        return Mathf.PI * Mathf.Pow(Radius(), 2);
    }

    // ABSTRACTION
    private float LateralSurfaceArea()
    {
        return 2 * Mathf.PI * Radius() * 2;
    }

    // ABSTRACTION
    private float Height()
    {
        return height * 2;
    }
}
