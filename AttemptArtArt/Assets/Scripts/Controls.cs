using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour
{
    //This allows you to move from the controls menu, back to the main menu
    public void Controls2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 15);
    }
}
