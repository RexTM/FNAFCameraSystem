using UnityEngine;
using UnityEngine.EventSystems;

public class CameraButton : MonoBehaviour, IPointerEnterHandler
{
    public GameObject cameraSystems;

    public void OnPointerEnter(PointerEventData eventData)
    {
        cameraSystems.SetActive(true);
    }
}
