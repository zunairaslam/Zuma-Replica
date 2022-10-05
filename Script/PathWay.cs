using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathWay : MonoBehaviour
{
    public Transform[] target;
    public float speed = 3f;
    private int currentPos;
    PointPath scripts;

    private void Start()
    {
        scripts = GameObject.Find("PathWay").GetComponent<PointPath>();
        target = scripts.path;
    }
    void Update()
    {
        Debug.Log(currentPos);
        if (transform.position != target[currentPos].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[currentPos].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else
        {
            currentPos = (currentPos + 1);
        }
           
        
    }
}
