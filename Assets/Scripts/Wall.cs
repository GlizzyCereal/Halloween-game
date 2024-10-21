using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Wall : MonoBehaviour
{
    private int points = 000;
    public TextMeshProUGUI pointsText;

    void Start()
    {
        points = int.Parse(pointsText.text);
    }

    void Update()
    {
        points = int.Parse(pointsText.text);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Candy"))
        {
            points -= 10;
            pointsText.text = points.ToString("D3");
            Debug.Log(points.ToString("D3"));

            Destroy(collision.gameObject, 0.1f);
        }
        else if (collision.gameObject.CompareTag("Poison"))
        {
            Destroy(collision.gameObject);
        }
    }
}