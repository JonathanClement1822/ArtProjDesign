using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckInfo : MonoBehaviour
{
    public Image image;
    //public Image imageInfo;
    //public Image image2;
    //public Image imageInfo2;
    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B)) {

            //First Image
            image = GetComponent<Image>();
            image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
           // imageInfo = GetComponent<Image>();
            //imageInfo.color = new Color(imageInfo.color.r, imageInfo.color.g, imageInfo.color.b, 100f);
            //Second Image
            //image2 = GetComponent<Image>();
            //image2.color = new Color(image2.color.r, image2.color.g, image2.color.b, 0f);
            //imageInfo2 = GetComponent<Image>();
            //imageInfo2.color = new Color(imageInfo2.color.r, imageInfo2.color.g, imageInfo2.color.b, 100f);

        }
        if (Input.GetKeyUp(KeyCode.B)) {

            //FirstImage
            image = GetComponent<Image>();
            image.color = new Color(image.color.r, image.color.g, image.color.b, 100f);
            //imageInfo = GetComponent<Image>();
            //imageInfo.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
            //image2 = GetComponent<Image>();
            //image2.color = new Color(image2.color.r, image2.color.g, image2.color.b, 100f);
            //imageInfo2 = GetComponent<Image>();
            //imageInfo2.color = new Color(imageInfo2.color.r, imageInfo2.color.g, imageInfo2.color.b, 0f);


        }
    }
}
