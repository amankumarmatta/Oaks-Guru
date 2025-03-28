using UnityEngine;

public class ClickCommand : ICommand
{
    private string interactionType;

    public ClickCommand(string interactionType)
    {
        this.interactionType = interactionType;
    }

    public void Execute(GameObject obj)
    {
        switch (interactionType)
        {
            case "Bounce":
                obj.GetComponent<Animator>().SetTrigger("Bounce");
                break;
            case "PlaySound":
                obj.GetComponent<AudioSource>().Play();
                break;
            case "ShowMessage":
                string friendlyName = GetFriendlyName(obj.name);
                InteractionManager.Instance.DisplayMessage($"You clicked: {friendlyName}");
                break;
        }
    }

    private string GetFriendlyName(string objectName)
    {
        if (objectName.Contains("Cube"))
            return "Cube";
        else if (objectName.Contains("Sphere"))
            return "Sphere";
        else if (objectName.Contains("Capsule"))
            return "Capsule";
        else
            return objectName;
    }
}