using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamClick : MonoBehaviour
{
    public GameObject cameraSwitcher;
    public Camera targetCamera;

    public void OnClick()
    {
        cameraSwitcher.GetComponent<CamControl>().SetActiveCamera(targetCamera);
    }
}
