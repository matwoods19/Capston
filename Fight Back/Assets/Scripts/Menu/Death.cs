using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    //go back to main
    //respawn

    [SerializeField]
    bool respawn;

    [SerializeField]
    bool mainMenu;

    private void Start()
    {
        Time.timeScale = 0;
    }

    void OnColliderExit(Collider other)
    {
        if(respawn == true)
        {
            if(other.tag == "Sword")
            {
                SceneManager.LoadScene(1);
            }
        }

        if(mainMenu == true)
        {
            if(other.tag == "Sword")
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
