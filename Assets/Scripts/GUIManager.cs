using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIManager : MonoBehaviour
{

	public GameObject winPanel;
	public GameObject losePanel;

	public static GUIManager instance;

	void Awake()
	{
		instance = this;
	}
	
	public void NextLevelButton()
	{
		GameManager.instance.NextLevel();
	}

	public void RetryButton()
	{
		GameManager.instance.Restart();
	}

	public void QuitButton()
	{
		GameManager.instance.Quit();
	}

	public void ShowWinPanel()
	{
		winPanel.SetActive(true);
	}

	public void ShowLosePanel()
	{
		losePanel.SetActive(true);
	}
}
