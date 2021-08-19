using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI volumeText;
    [SerializeField] private TextMeshProUGUI surfaceText;

    private void OnEnable()
    {
        Shape.OnMouseOverObject += UpdateUI;
        Shape.OnMouseExitObject += UpdateUI;
    }

    private void OnDisable()
    {
        Shape.OnMouseOverObject -= UpdateUI;
        Shape.OnMouseExitObject -= UpdateUI;
    }

    void UpdateUI(Shape shape)
    {
        nameText.SetText($"Name: {shape.name}");
        volumeText.SetText($"Volume: {shape.Volume()}m³");
        surfaceText.SetText($"Surface: {shape.Surface()}m²");
    }

    void UpdateUI()
    {
        nameText.SetText($"Name: -");
        volumeText.SetText($"Volume: -");
        surfaceText.SetText($"Surface: -");
    }
}
