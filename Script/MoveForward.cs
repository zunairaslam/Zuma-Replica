using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public Transform firePoint;
    public float speed = 40f;
    private GameObject bullet;

    public GameObject[] projectilePrefebs;
    // Start is called before the first frame update
    void Start()
    {
        //bullet = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
            
        }
        
    }

    void Shoot()
    {
       bullet = Instantiate(projectilePrefebs[Random.Range(0, projectilePrefebs.Length)], firePoint.position, Quaternion.identity);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.forward * speed,ForceMode.Impulse);
       
    }
}
