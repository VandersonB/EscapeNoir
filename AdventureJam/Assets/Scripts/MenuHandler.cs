using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public string jogar, creditos, menu;
   

	public void OnStartButtonPressed()
    {
        SceneManager.LoadScene(jogar);
    }

    public void OnCreditsButtonPressed()
    {
        SceneManager.LoadScene(creditos);
    }

    public void OnBackButtonPressed()
    {
        SceneManager.LoadScene(menu);
    }
}
