using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using Unity.VisualScripting;
using static enemytower;

public class enemytower : MonoBehaviour
{
    public enum enemyTower
    {
        SmailEnemyTowerA,
        BigEnemyTower,
        SmailEnemyTowerB
    }

    [Header("enemytower ����")]
    [SerializeField] float enemytowerhp = 30f;// Ÿ��hp

  



    // Start is called before the first frame update


    public void OnTriggerEnter2D(Collider2D collision)
    {
       




    }
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(float damage)
    {


        enemytowerhp = enemytowerhp - damage;

        if (enemytowerhp <= 0)
        {
            enemytowerhp = 0;
        }
    }



    public void DestroyOnBodySlam()
    {
        destroyFunctiom();
    }

    private void destroyFunctiom()
    {
        Destroy(gameObject);
    }

}
