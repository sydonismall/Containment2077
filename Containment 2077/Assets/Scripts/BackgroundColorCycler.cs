using UnityEngine;
using UnityEngine.UI; // Required for UI components

public class BackgroundColorCycler : MonoBehaviour
{
    public Image backgroundImage; // For UI background
    public SpriteRenderer backgroundSprite; // For Sprite background
    public Color[] colors; // Array of colors to cycle through
    private int currentColorIndex = 0;

    public void CycleColor()
    {
        if (colors.Length == 0) return;

        // Increment color index
        currentColorIndex = (currentColorIndex + 1) % colors.Length;

        // Apply the color to the appropriate background
        if (backgroundImage != null)
        {
            backgroundImage.color = colors[currentColorIndex];
        }
        else if (backgroundSprite != null)
        {
            backgroundSprite.color = colors[currentColorIndex];
        }
    }
}
