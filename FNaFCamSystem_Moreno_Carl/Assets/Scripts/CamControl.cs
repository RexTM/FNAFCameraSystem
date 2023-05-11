using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    public Camera[] cameras;

    private int activeCameraIndex = 0;

    private bool isCameraOpen = false;
    private int currentCameraIndex = 0;

    public CamControl camControl;

    public void Start()
    {
 
        /* for (int i = 1; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(false);
        }
        */
        
        //SetActiveCamera(activeCameraIndex);

        /* foreach (Camera camera in cameras)
        {
            camera.enabled = false;
        }
        */
        
    }

    public void Update()
    {
        //Check if the player clicked the bottom of the screen
        if (Input.GetMouseButtonDown(0) && Input.mousePosition.y < Screen.height * 0.1f)
        {
            if (!isCameraOpen)
            {
                isCameraOpen = true;
                currentCameraIndex = 0;
                cameras[currentCameraIndex].enabled = true;
            }
            else
            {
                cameras[currentCameraIndex].enabled = false;
                currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;
                cameras[currentCameraIndex].enabled = true;
            }
        }
    }

    public void SetActiveCamera(Camera targetCamera)
    {
        cameras[activeCameraIndex].gameObject.SetActive(false);

        int targetCameraIndex = System.Array.IndexOf(cameras, targetCamera);

        if (targetCameraIndex < 0) return;

        targetCamera.gameObject.SetActive(true);
        activeCameraIndex = targetCameraIndex;
    }
}
