using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using Unity.VisualScripting;

public class enemytower : MonoBehaviour
{
    public enum enemyTower
    {
        SmailEnemyTowerA,
        BigEnemyTower,
        SmailEnemyTowerB
    }

    [Header("enemytower Á¤º¸")]
    [SerializeField] float enemytowerHp = 30f;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
  
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
