using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
	void Update()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			SceneManager.LoadScene("Game");
		}
		if (Input.GetButtonDown("Cancel"))
		{
			Debug.Log("Quitting");
			Application.Quit();
		}

	}
}
