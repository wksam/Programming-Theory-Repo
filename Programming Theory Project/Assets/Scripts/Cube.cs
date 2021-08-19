// INHERITANCE
public class Cube : Shape
{
    // ENCAPSULATION
    private const int sideNumber = 6;

    // POLYMORPHISM
    public override float Surface()
    {
        return base.Surface() * sideNumber;
    }
}
