using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImpact : MonoBehaviour
{
    private readonly GameManager gameManager = GameManager.Instance;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1.5f); 
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        EnemyTracking enemy = other.GetComponent<EnemyTracking>();
        if (enemy != null)
        {
            Destroy(enemy.gameObject);
            gameManager.AddScore(1);
        }
    }
}
