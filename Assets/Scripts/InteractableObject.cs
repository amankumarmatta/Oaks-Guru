using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public ICommand bounceCommand;
    public ICommand soundCommand;
    public ICommand messageCommand;

    private void Start()
    {
        bounceCommand = new ClickCommand("Bounce");
        soundCommand = new ClickCommand("PlaySound");
        messageCommand = new ClickCommand("ShowMessage");
    }

    private void OnMouseDown()
    {
        bounceCommand.Execute(gameObject);
        soundCommand.Execute(gameObject);
        messageCommand.Execute(gameObject);
    }
}