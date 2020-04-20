using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckInfo : MonoBehaviour
{
    public Image image;
    public Image imageInfo;
    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(3)) {
            image = GetComponent<Image>();
            image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
            imageInfo = GetComponent<Image>();
            imageInfo.color = new Color(image.color.r, image.color.g, image.color.b, 100f);

        }
        if (Input.GetMouseButtonUp(3)) {

            image = GetComponent<Image>();
            image.color = new Color(image.color.r, image.color.g, image.color.b, 100f);
            imageInfo = GetComponent<Image>();
            imageInfo.color = new Color(image.color.r, image.color.g, image.color.b, 0f);


        }
    }
}
