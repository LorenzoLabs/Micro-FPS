using System.Collections;
using System.Collections.Generic;
using Unity.FPS.AI;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    
    public TMPro.TextMeshProUGUI enemyKillCountText;
    public TMPro.TextMeshProUGUI finalScoreText;
    
    private int _enemyKillCount;
    private int _finalScore=0;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyKillCountText.text = "Enemies Killed: ";
        finalScoreText.text = "Final Score: ";
        _enemyKillCount = this.GetComponent<EnemyManager>().NumberOfEnemiesTotal-this.GetComponent<EnemyManager>().NumberOfEnemiesRemaining;

        enemyKillCountText.text = enemyKillCountText.text + _enemyKillCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        _enemyKillCount = this.GetComponent<EnemyManager>().NumberOfEnemiesTotal-this.GetComponent<EnemyManager>().NumberOfEnemiesRemaining;

        enemyKillCountText.text = "Enemies Killed: " + _enemyKillCount.ToString();

        _finalScore = 10 * _enemyKillCount;
        finalScoreText.text = "Final Score: " + _finalScore.ToString();
    }
}
