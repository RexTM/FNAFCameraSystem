using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    //Variables of the Camera Movement
    public Transform playerCam;
    public int rotateSpeed, clampValue;
    public bool ADKeys, movingLeft, movingRight;
    public int targetFramerate;

    //Creates the frame rate
    void Start()
    {
        Application.targetFrameRate = targetFramerate;
    }

    void Update()
    {
        //If ADKeys is == true, you may rotate the camera left and right with A & D.
        if (ADKeys == true)
        {
            //When you press the A key, the camera will rotate left.
            if (Input.GetKey(KeyCode.A))
            {
                if (playerCam.localRotation == Quaternion.Euler(0, -clampValue, 0))
                {

                }
                else
                {
                    playerCam.Rotate(0, -rotateSpeed, 0);
                }
            }
            //When you press the D key, the camera will rotate right.
            if (Input.GetKey(KeyCode.D))
            {
                if (playerCam.localRotation == Quaternion.Euler(0, clampValue, 0))
                {

                }
                else
                {
                    playerCam.Rotate(0, rotateSpeed, 0);
                }
            }
        }
        //If ADKeys == false, the regular camera rotation will be available.
        if (ADKeys == false)
        {
            //If either movingLeft or movingRight is == true, the camera will rotate left or right.
            if (movingLeft == true)
            {
                if (playerCam.localRotation == Quaternion.Euler(0, -clampValue, 0))
                {

                }
                else
                {
                    playerCam.Rotate(0, -rotateSpeed, 0);
                }
            }
            if (movingRight == true)
            {
                if (playerCam.localRotation == Quaternion.Euler(0, clampValue, 0))
                {

                }
                else
                {
                    playerCam.Rotate(0, rotateSpeed, 0);
                }
            }
        }
    }
    //This will set the movement for the mouse controls
    public void rotateLeft()
    {
        movingLeft = true;
    }
    public void rotateRight()
    {
        movingRight = true;
    }
    public void stopRotateLeft()
    {
        movingLeft = false;
    }
    public void stopRotateRight()
    {
        movingRight = false;
    }
}
