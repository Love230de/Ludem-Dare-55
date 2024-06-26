using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public enum GameState
{
    Win,Lose,Pause,Resume,Exit
}
public class GameController : MonoBehaviour
{
    //Since we don't have a start level yet I am just referencing a static instance of this class
    public static GameController instance { get;set; }
    public bool Pause { get => pause; set => pause = value; }
    [SerializeField] private GameObject died;
    [SerializeField] private int maxItemCount;
    [SerializeField] private GameObject pauseMenu;
    //OxygenTimer
    [SerializeField] public OxygenTimer oxygenTimer;
    private int items;
   [SerializeField] private bool pause;

   public void ChangeGameState(GameState gameState)
    {
        switch (gameState)
        {
            case GameState.Win:
                SceneManager.LoadScene(1);
                break;
            case GameState.Lose:
                //Lose
                died.SetActive(true);
                break;
            case GameState.Pause:
                pauseMenu.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0;
                break;
           case GameState.Resume:
                pauseMenu.SetActive(false);
                Time.timeScale = 1.0f;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                break;
            case GameState.Exit:
                Application.Quit();
                break;
            default:
                break;
        }
    }
    public void ExitGame()
    {
        ChangeGameState(GameState.Exit);
    }
    public void Resume()
    {
        pause = false;
    }
    public void IncreaseItems()
    {
        if (items < maxItemCount)
        { 
            items++;
            return;
        }
    }
    private void Update()
    {
        if(items >= maxItemCount)
        {
            ChangeGameState(GameState.Win);
            
        }
        oxygenTimer.UpdateOxygenTimer();
        Debug.Log(oxygenTimer.OxygenAmount);
        if(oxygenTimer.Empty)
        {
           ChangeGameState(GameState.Lose);
        }
        if(Input.GetKeyDown(KeyCode.Escape) && !Pause)
        {
            Pause = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && Pause)
        {
            Pause = false;
        }
       if(Pause)
        {
           
            ChangeGameState (GameState.Pause);
            
        }
        if(!Pause) 
        {
            ChangeGameState(GameState.Resume);
           
        }
    }
    
    private void Awake()
    {
        oxygenTimer.StartOxygen();
        if (instance == null)
        {
            instance = this;
        }
    }


}
