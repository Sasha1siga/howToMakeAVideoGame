using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    public Transform Player;
    public Text ScoreText;
    
    void Update()
    {
        ScoreText.text = Player.position.z.ToString("0"); 
    }
}
