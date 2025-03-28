using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DropArea : MonoBehaviour
{
    public TMP_Text dropMessageText;

    private void OnTriggerEnter(Collider other)
    {
        DraggableObject draggable = other.GetComponent<DraggableObject>();

        if (draggable != null)
        {
            draggable.DisableMovement(); // Stop movement
            UpdateDropMessage(other.gameObject.name);
        }
    }

    private void UpdateDropMessage(string objectName)
    {
        dropMessageText.text = "You dropped a " + objectName;
    }
}
