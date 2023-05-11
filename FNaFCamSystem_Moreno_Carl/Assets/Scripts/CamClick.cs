using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamClick : MonoBehaviour
{
    public GameObject cameraSwitcher;
    public Camera targetCamera;
    public GameObject cameraOne;
    public GameObject cameraTwo;
    public GameObject cameraThree;
    public GameObject cameraFour;

    public void OnClick()
    {
        cameraSwitcher.GetComponent<CamControl>().SetActiveCamera(targetCamera);
    }
    
    //Allows the player to switch between cameras sucessfully
    public void cameraLeft()
    {
        cameraOne.SetActive(true);
        cameraTwo.SetActive(false);
        cameraThree.SetActive(false);
        cameraFour.SetActive(false);
    }

    public void cameraRight()
    {
        cameraOne.SetActive(false);
        cameraTwo.SetActive(true);
        cameraThree.SetActive(false);
        cameraFour.SetActive(false);
    }

    public void cameraUp()
    {
        cameraTwo.SetActive(false);
        cameraOne.SetActive(false);
        cameraThree.SetActive(false);
        cameraFour.SetActive(true);

    }

    public void cameraBottom()
    {
        cameraTwo.SetActive(false);
        cameraOne.SetActive(false);
        cameraThree.SetActive(true);
        cameraFour.SetActive(false);
    }

    public void Awake()
    {
        cameraFour.SetActive(false);
        cameraTwo.SetActive(false);
        cameraOne.SetActive(false);
    }
}
