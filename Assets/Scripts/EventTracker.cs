using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;

public class EventTracker : MonoBehaviour
{
	public static EventTracker instance;

	void Awake()
	{
		Debug.Log("Instance !");
		instance = this;
	}

	public void LevelStart()
	{
		Debug.Log("Level start !");
		string sceneName = SceneManager.GetActiveScene().name;
		AnalyticsEvent.LevelStart(sceneName, new Dictionary< string, object > {{"levelNumber",int.Parse(Regex.Match(sceneName, @"\d+").Value) }});
	}

	public void LevelFail()
	{
		Debug.Log("Level fail !");
		string sceneName = SceneManager.GetActiveScene().name;
		AnalyticsEvent.LevelFail(sceneName, new Dictionary< string, object > {{"levelNumber", int.Parse(Regex.Match(sceneName, @"\d+").Value) }});
	}
	
	public void LevelComplete()
	{
		Debug.Log("Level Completed !");
		string sceneName = SceneManager.GetActiveScene().name;
		AnalyticsEvent.LevelComplete(sceneName, new Dictionary< string, object > {{"levelNumber", int.Parse(Regex.Match(sceneName, @"\d+").Value) }});
	}
	
	public void LevelQuit()
	{
		Debug.Log("Level Quit !");
		string sceneName = SceneManager.GetActiveScene().name;
		AnalyticsEvent.LevelQuit(sceneName, new Dictionary< string, object > {{"levelNumber", int.Parse(Regex.Match(sceneName, @"\d+").Value) }});
	}
}
