using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Collider))]
public class DraggableObject : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Vector3 offset;
    private Camera mainCamera;
    private float fixedYPosition;
    private bool isDraggable = true;

    private void Start()
    {
        mainCamera = Camera.main;
        fixedYPosition = transform.position.y;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (!isDraggable) return;

        offset = transform.position - GetMouseWorldPosition();
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!isDraggable) return;

        Vector3 targetPosition = GetMouseWorldPosition() + offset;
        targetPosition.y = fixedYPosition;
        transform.position = targetPosition;
    }

    public void OnEndDrag(PointerEventData eventData) { }

    public void DisableMovement()
    {
        isDraggable = false;
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Mathf.Abs(mainCamera.transform.position.z);
        return mainCamera.ScreenToWorldPoint(mousePosition);
    }
}
