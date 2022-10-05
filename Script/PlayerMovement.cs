using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Camera mainCamera;
    public Vector3 mousePosition;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Inputkeys();
        
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Inputkeys()
    {
        mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.y = 0f;
    }

    private void Movement()
    {
        transform.LookAt(mousePosition);
    }
}
