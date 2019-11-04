using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame ()
	{
		// SceneManager.LoadScene("mygameplat");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void MenuGame ()
	{
		// SceneManager.LoadScene("mygameplat");
		SceneManager.LoadScene("Menu");
	}

	public void QuitGame ()
	{
		Application.Quit();
	}


}
