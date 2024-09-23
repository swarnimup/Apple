using UnityEngine;
using TMPro; // If using TextMeshPro

public class RoundManager : MonoBehaviour
{
    // Reference to the UI Text or TextMeshProUGUI component
    public TextMeshProUGUI roundText; // Or public Text roundText if using standard Text

    void Start()
    {
        // Check if the roundText is assigned in the Inspector
        if (roundText == null)
        {
            Debug.LogError("Round Text is not assigned in the Inspector!");
        }
        else
        {
            UpdateRoundText();
        }
    }

    public void UpdateRoundText()
    {
        // Your logic to update the round text, for example:
        roundText.text = "Round 1"; // Update this as needed
    }
}
