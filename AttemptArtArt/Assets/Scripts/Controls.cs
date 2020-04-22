using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour
{
    // Start is called before the first frame update
    public void Controls2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 11);
    }
}
