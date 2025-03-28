using UnityEngine;
using TMPro;

public class InteractionManager : MonoBehaviour
{
    public static InteractionManager Instance;
    public TextMeshProUGUI infoText;

    private void Awake()
    {
        Instance = this;
    }

    public void DisplayMessage(string message)
    {
        infoText.text = message;
    }
}