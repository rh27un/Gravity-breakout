using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Ball : MonoBehaviour
{
	public int lives;
	public float deathplane;
	public float spawnOffset;

	protected Text livesText;
	protected Transform paddle;
	protected RectTransform rectTransform;
	protected Rigidbody2D rigidbody;

	void Start()
	{
		livesText = GameObject.Find("Lives").GetComponent<Text>();
		livesText.text = lives.ToString();
		paddle = GameObject.Find("Paddle").transform;
		rectTransform = GetComponent<RectTransform>();
		rigidbody = GetComponent<Rigidbody2D>();
	}

	void Update()
	{

		if (Input.GetButtonDown("Cancel"))
		{
			Application.Quit();
		}
		if(rectTransform.anchoredPosition.y < deathplane)
		{
			
			if(lives > 0)
			{
				rigidbody.velocity = Vector2.zero;
				lives--;
				livesText.text = lives.ToString();
				transform.position = paddle.position + new Vector3(0f, spawnOffset);
			}
			else
			{
				SceneManager.LoadScene("GameOver");
			}
		}
	}
}
