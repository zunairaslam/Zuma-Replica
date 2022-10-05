using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public List<GameObject> balls;
    public List<GameObject> clones;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BallSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator BallSpawn()
    {
        while (true)
        {
            for(int i = 0; i < 25; i++)
            {
                yield return new WaitForSeconds(.6f);
                Instantiate(balls[Random.Range(0, balls.Count)], transform.position, Quaternion.identity);
                if (i  == 24)
                {
                    StopAllCoroutines();
                }   
            }
        }
    }
}
