using System.Collections;
using System.Collections.Generic;
using Unity.FPS.AI;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    
    public TMPro.TextMeshProUGUI enemyKillCountText;

    public GameObject myObject;
    
    private int _enemyKillCount;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyKillCountText.text = "Enemies Killed: ";
        _enemyKillCount = this.GetComponent<EnemyManager>().NumberOfEnemiesTotal-this.GetComponent<EnemyManager>().NumberOfEnemiesRemaining;

        enemyKillCountText.text = enemyKillCountText.text + _enemyKillCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        _enemyKillCount = this.GetComponent<EnemyManager>().NumberOfEnemiesTotal-this.GetComponent<EnemyManager>().NumberOfEnemiesRemaining;

        enemyKillCountText.text = "Enemies Killed: " + _enemyKillCount.ToString();
    }
}
