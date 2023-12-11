using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyTracking : MonoBehaviour
{
    public GameObject target = null;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {    
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;
        transform.LookAt(new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z));
        Vector3 direction = target.transform.position - transform.position;
        transform.position += speed * Time.deltaTime * new Vector3(direction.x, 0, direction.z);
    }
}
