using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;
	
	EventTracker tracker;

	void Awake()
	{
		Time.timeScale = 1;
		instance = this;
		tracker = GetComponent< EventTracker >();
	}

	public void Win()
	{
		Debug.Log("Win!");
		Time.timeScale = 0;
		GUIManager.instance.ShowWinPanel();
	}

	public void Lose()
	{
		Debug.Log("LOOSE !");
		tracker.LevelFail();
		Time.timeScale = 0;
		GUIManager.instance.ShowLosePanel();
	}

	public void Restart()
	{
		Debug.Log("Restart!");
		tracker.LevelFail();
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void NextLevel()
	{
		int levelIndex = int.Parse(System.Text.RegularExpressions.Regex.Match(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name, @"\d+").Value);

		tracker.LevelComplete();

		if (levelIndex == 4)
			levelIndex = -1;
		
		SceneManager.LoadScene("level" + (levelIndex + 1));
	}

	public void Quit()
	{
		tracker.LevelQuit();
		Application.Quit();
	}
}
