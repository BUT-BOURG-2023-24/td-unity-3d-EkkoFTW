using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    private int score = 0;
    public int Score { get { return score; } }
    public void AddScore(int amount) { score += amount;}
    internal void ReloadGame()
    {
        score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
