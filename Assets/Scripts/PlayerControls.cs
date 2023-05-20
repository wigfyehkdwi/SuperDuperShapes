using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float moveSpeed = 600f;
    private float movement = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1; // ? Is this necesary?
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;
    }
}
