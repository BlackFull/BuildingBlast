using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractionMenu : MonoBehaviour
{
    public void lancerJeu()
	{
		SceneManager.LoadScene("Scenes/PlateauVille");
	}
	
	public void quitterJeu()
	{
		Debug.Log("QUIT!");
		Application.Quit();
	}
}
