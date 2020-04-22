using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scoring : MonoBehaviour
{
   static public int Pic1 = 0;
   static public int Pic2 = 0;
    static public int finalVal = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex >= 10)
        {

            Debug.Log("Reached The end!");

        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Pic1++;
                Debug.Log(Pic1);
                Debug.Log(Pic2);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Pic2++;
                Debug.Log(Pic1);
                Debug.Log(Pic2);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

            }
        }
        finalVal = 4 - Pic2;
    }
}
