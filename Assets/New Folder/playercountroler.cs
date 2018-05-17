using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playercountroler : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
    private int score;
    public Text scoreText;
    private float jumpTime;
   
    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();
        score = 0;
        scoreText.text = "Score: " + score.ToString();
        jumpTime = 0;
    }

    // Update is called once per frame
    void Update() {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float j = Input.GetAxis("Jump");
        if (j > 0)
        {
            jumpTime = jumpTime - Time.deltaTime;
            if (jumpTime < 0) { j = 0; };
        }

        Vector3 dir = new Vector3(h, j * 5, v);

       

        rb.AddForce(dir * speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        { jumpTime = 1; }

    }
     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            score++;
            scoreText.text = "Score: " + score.ToString();
        }
     }
    
 }