using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KillCounterUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText = null;
    private readonly GameManager gameManager = GameManager.Instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + gameManager.Score;
    }
}
