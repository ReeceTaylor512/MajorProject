using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIButtons : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    [SerializeField] private float moveAmount;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Slider slider;
    [SerializeField] private Image repeatBox;
    [SerializeField] private Sprite onSprite;
    [SerializeField] private Sprite offSprite;


    public bool repeatMode = false; 
    public void UpArrow()
    {
        Camera.transform.localPosition += new Vector3(0, moveAmount, 0);
    }

    public void DownArrow()
    {
        Camera.transform.localPosition -= new Vector3(0, moveAmount, 0);
    }
    public void LeftArrow()
    {
        Camera.transform.localPosition -= new Vector3(moveAmount, 0, 0);
    }
    public void RightArrow()
    {
        Camera.transform.localPosition += new Vector3(moveAmount, 0, 0);
    }

    public void LoopMode()
    {
        if(repeatMode == false)
        {
            repeatMode = true;
            repeatBox.sprite = onSprite;
            Regenerate.buttonOn = true;
        }
        else 
        { 
            repeatMode = false;
            repeatBox.sprite = offSprite;
            Regenerate.buttonOn = true;
        }
    }




    public void Update()
    {
        mainCamera.orthographicSize = slider.value;
       
    }

}
