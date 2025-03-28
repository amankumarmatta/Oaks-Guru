using UnityEngine;

public class DragManager : MonoBehaviour
{
    public DraggableObject cube;
    public DraggableObject sphere;
    public DraggableObject capsule;

    private void Start()
    {
        Debug.Log("Drag Manager Initialized");
    }
}
