using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SelectCharcter : MonoBehaviour
{
    public GameObject selectCharacter;
    public GameObject mainMenu;

    public void OnBackButton()
    {
        selectCharacter.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void OnCharacter1()
    {
        SceneManager.LoadScene("ZombieLand");
    }

    public void OnCharacter2()
    {
        SceneManager.LoadScene("ZombieLand2");
    }

    public void OnCharacter3()
    {
        SceneManager.LoadScene("ZombieLand3");
    }
}
