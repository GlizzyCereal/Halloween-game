using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using TMPro; 

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private int points = 0;
    public TextMeshProUGUI pointsText;

    void Start()
    {
        points = int.Parse(pointsText.text);
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(move, 0, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Candy"))
        {
            Destroy(collision.gameObject);
            points += 10;
        }
        else if (collision.gameObject.CompareTag("Poison"))
        {
            Destroy(collision.gameObject);
            points -= 10;
        }

        pointsText.text = points.ToString("D3");
    }
}