using UnityEngine;

public class DragStrategy : IDragStrategy
{
    public void OnDrag(GameObject obj)
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f;
        obj.transform.position = Camera.main.ScreenToWorldPoint(mousePos);
    }

    public void OnDrop(GameObject obj)
    {
        
    }
}
