using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
	public void RestartGame()
    {
		Time.timeScale = 1f;
		SceneManager.LoadScene("Menu");
	}
	public void Quit()
	{
		Debug.Log("QUIT!");
		Application.Quit();
	}
}