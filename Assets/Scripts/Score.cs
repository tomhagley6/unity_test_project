using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
        // scoreText.text = FindObjectOfType<Transform>().position.z.ToString("0");
    }
}
