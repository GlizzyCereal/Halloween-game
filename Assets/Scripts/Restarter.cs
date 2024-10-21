using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Restarter : MonoBehaviour
{
    public TextMeshProUGUI pointsText;
    private int points;

    // Start is called before the first frame update
    void Start()
    {
        points = int.Parse(pointsText.text);
    }

    // Update is called once per frame
    void Update()
    {
        points = int.Parse(pointsText.text);
        if (points < 0)
        {
            RestartGame();
        }
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
