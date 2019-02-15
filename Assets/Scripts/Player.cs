using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;
    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0.0f, z);

        rb.AddForce (movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
        if (other.gameObject.tag == "endin")
        {
            gameObject.SetActive(false);
            if (count >= 8)
            {
                winText.text = "You Win!";
            }

        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        //if (count >= 8)
        //{
        //    winText.text = "You Win!";
        //}
    }
}