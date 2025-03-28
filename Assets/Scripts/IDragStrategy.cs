using UnityEngine;

public interface IDragStrategy
{
    void OnDrag(GameObject obj);
    void OnDrop(GameObject obj);
}
