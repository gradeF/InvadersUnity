using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
	#region Public Fields
	public static GameManager instance;
	public bool isGameOver = false;
	public TMP_Text scoreText;
	public GameObject gameoverUI;
	public List<GameObject> Invaders;
	#endregion


	#region Protected Fields
	#endregion


	#region Private Fields
	private int score = 0;
    #endregion


    #region MonoBehaviour Callbacks
    private void Awake()
    {
        if(instance == null)
        {
			instance = this;
        }
        else
        {
			Destroy(gameObject);
        }
    }
    private void Start()
	{
		
	}
	private void Update()
	{
		ScoreChecker();
		if(isGameOver && Input.GetKeyDown(KeyCode.Return))
        {
			SceneManager.LoadScene("01Game");
			Time.timeScale = 1;
        }
		else if(isGameOver && Input.GetKeyDown(KeyCode.Escape))
        {
			SceneManager.LoadScene("00Start");
			Time.timeScale = 1;
        }
		
	}
	#endregion


	#region Public Methods
	public void AddScore(int newScore)
    {
		if(!isGameOver)
        {
			score += newScore;
			scoreText.text = ""+score;
        }
    }
	public void OnPlayerDead()
    {
		isGameOver = true;
		gameoverUI.SetActive(true);
		Time.timeScale = 0;
    }
	#endregion

	#region Private Methods
	private void ScoreChecker()
    {
		if(score == 300)
        {
			isGameOver = true;
			gameoverUI.SetActive(true);
		}
    }
	#endregion
}
