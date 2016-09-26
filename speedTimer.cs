using UnityEngine;
using System.Collections;

public class speedTimer : MonoBehaviour {
    private Rigidbody2D rb;

    public float xSpeed = 4.0f;
    public float ySpeed = 100.0f;
    private float movex = 0f;				//binary values for Horiz movement
    private float movey = 0f;				//binary values for Vert movement
    float timeLeft = 5.0f;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();


    }

    void Update()
    {
        timeLeft -= Time.deltaTime;        // time left = time - change in time
        if (timeLeft >= 0)              //if time is greater than zero, apply speed boost
        {
            xSpeed = 6;
            if (Input.GetKey(KeyCode.A))
                movex = -1;
            else if (Input.GetKey(KeyCode.D))
                movex = 1;
            else
                movex = 0;
         
            Vector2 movement = new Vector2(movex * xSpeed, movey * ySpeed);

            rb.AddForce(movement * xSpeed);
        }
    }

}
