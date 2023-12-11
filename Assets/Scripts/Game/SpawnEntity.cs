using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class SpawnEntity : MonoBehaviour
{

    public GameObject entity;
    public GameObject target;
    public GameObject localization;
    public float spawnPerSec;

    private float targetTime;
    private float timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = targetTime = 1/(spawnPerSec*60);
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0.0f)
        {
            timeLeft = targetTime;
            spawnEntity();
        }
    }

    void spawnEntity()
    {

        Vector3 center = localization.transform.position;
        Vector3 size = localization.GetComponent<Renderer>().bounds.size;

        Vector2 position = new Vector2(UnityEngine.Random.Range(center.x - size.x / 2, center.x + size.x / 2),
            UnityEngine.Random.Range(center.z - size.z / 2, center.z + size.z / 2));

        GameObject spawned = Instantiate(entity, new Vector3(position.x, entity.GetComponent<Renderer>().bounds.size.y/2, position.y), Quaternion.identity);
        spawned.GetComponent<EnemyTracking>().target = target;
    }
}
