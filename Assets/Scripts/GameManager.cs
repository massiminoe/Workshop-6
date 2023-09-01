// // COMP30019 - Graphics and Interaction
// // (c) University of Melbourne, 2022

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
 
public class GameManager : MonoBehaviour
{
    [SerializeField] TMPro.TMP_Text scoreText;
    private int score = 0;
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if(_instance == null)
            {
                GameObject go = new GameObject("GameManager");
                go.AddComponent<GameManager>();
            }
            return _instance;
        }
    }

    public void Start() {
        scoreText.SetText(score.ToString());
    }

    public void UpdateScore(int delta) {
        this.score += delta;
        scoreText.SetText(this.score.ToString());
    }
    void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}
