using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckInfo : MonoBehaviour
{
    /*This allows you to drag and drop an image from the inspector. put this on code on the image you want to hide, 
    then drag the same image onto the code in the inspector*/
    public Image image;

    //Code is in update so that it keeps checking if the key is held down or not
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {

            //This changes the images alpha(Oppacity) to 0% when key is held
            image = GetComponent<Image>();
            image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);


        }
        if (Input.GetKeyUp(KeyCode.B))
        {

            //This changes the images alpha(Oppacity) to 100% when key is released
            image = GetComponent<Image>();
            image.color = new Color(image.color.r, image.color.g, image.color.b, 100f);


        }
    }
}
