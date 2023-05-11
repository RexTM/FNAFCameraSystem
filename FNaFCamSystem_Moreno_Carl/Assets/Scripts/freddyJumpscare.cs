using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freddyJumpscare : MonoBehaviour
{
    public GameObject freddyImage;
    private void Awake()
    {
        freddyImage.SetActive(false);
    }

    //Creates the jumpscare effect
    public void jumpscareRoom()
    {
            freddyImage.SetActive(true);
            Debug.Log("freddy!!!!");
        Invoke("hideObject", 1.5f);
    }

    void hideObject()
    {
        freddyImage.SetActive(false);
    }

}
