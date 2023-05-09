using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    public Camera[] cameras;
    public float cameraSwitchDelay = 0.5f;

    private int activeCameraIndex = 0;

    private bool isCameraOpen = false;
    private int currentCameraIndex = 0;

    public CamControl camControl;

    void Start()
    {
        //Disable all cameras except the first one
        for (int i = 1; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(false);
        }

        // Set the active camera to the first one
        // SetActiveCamera(activeCameraIndex);

        //Deactivates cameras at the start
        foreach (Camera camera in cameras)
        {
            camera.enabled = false;
        }
    }

    void Update()
    {
        //Check if the player clicked the bottom of the screen
        if (Input.GetMouseButtonDown(0) && Input.mousePosition.y < Screen.height * 0.1f)
        {
            // If the camera system is closed, open it and activate the first camera
            if (!isCameraOpen)
            {
                isCameraOpen = true;
                currentCameraIndex = 0;
                cameras[currentCameraIndex].enabled = true;
            }
            //If the camera system is open, switch to the next camera
            else
            {
                cameras[currentCameraIndex].enabled = false;
                currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;
                cameras[currentCameraIndex].enabled = true;
            }

            //Wait for a short delay before allowing another camera switch
            StartCoroutine(DelayCameraSwitch());
        }
    }

    public void SetActiveCamera(Camera targetCamera)
    {
        // Disable the currently active camera
        cameras[activeCameraIndex].gameObject.SetActive(false);

        // Find the index of the target camera in the cameras array
        int targetCameraIndex = System.Array.IndexOf(cameras, targetCamera);

        // If the target camera is not in the cameras array, return
        if (targetCameraIndex < 0) return;

        // Set the target camera as the active camera
        targetCamera.gameObject.SetActive(true);
        activeCameraIndex = targetCameraIndex;
    }

    IEnumerator DelayCameraSwitch()
    {
        yield return new WaitForSeconds(cameraSwitchDelay);
    }
}
