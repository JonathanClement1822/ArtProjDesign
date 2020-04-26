using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scoring : MonoBehaviour
{
    // Counter for the Non-copyrighted Images
   static public int Pic1 = 0;
    // Counter for the Non-copyrighted Images
    static public int Pic2 = 0;
    // Value of amount of choices
    static public int finalVal = 0;
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex >= 14)
        {

            Debug.Log("Reached The end!");

        }
    }

    // Update is called once per frame
    void Update()
    {
        //This restricts the scene from changing when you reach the last one
        if (SceneManager.GetActiveScene().buildIndex != 14 || SceneManager.GetActiveScene().buildIndex != 13)
        {
            //This Changes the Scene to the next one. Checks for a '1' key press
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                //This adds value by 1 everytime the specified key is pressed
                Pic1++;
                Debug.Log(Pic1);
                Debug.Log(Pic2);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            //This Changes the Scene to the next one. Checks for a '2' key press.
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                //This adds value by 1 everytime the specified key is pressed
                Pic2++;
                Debug.Log(Pic1);
                Debug.Log(Pic2);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

            }
        }
        //This sets what finalVal is
        finalVal = 4;
    }
}
