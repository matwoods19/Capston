using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    [SerializeField]
    bool start;
    
    [SerializeField]
    bool option;

    [SerializeField]
    bool quit;

    [SerializeField]
    GameObject OptionCanvas;

    [SerializeField]
    GameObject MainCanvas;

    void OnColliderEnter(Collider other)
    {
        if(start == true)
        {
            if(other.tag == "Sword")
            {
                SceneManager.LoadScene(1);
            }
        }

        if(quit == true)
        {
            if(other.tag == "Sword")
            {
                Application.Quit();
            }
        }
    }
}
