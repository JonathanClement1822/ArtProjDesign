using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Move2 : MonoBehaviour
{
    //This moves to the next 2 scenes, This happens when this code is connected to a button object
    public void MovePlus2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
