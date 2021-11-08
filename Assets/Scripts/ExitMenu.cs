using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMenu : MonoBehaviour
{
    public GameObject Menuu;
    public void OpenGame()
    {
        Menuu.SetActive(false);
        Time.timeScale = 1;
    }
}
