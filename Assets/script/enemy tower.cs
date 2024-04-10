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

    [Header("enemytower Á¤º¸")]
    [SerializeField] float enemytowerHp = 30f;
    public GameObject soldier;


    // Start is called before the first frame update


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision .tag == Tool.GetGameTag(GameTag. ssoldier))
        {

        }




    }
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Hit(float _damage)
    {
        enemytowerHp -= _damage;

        if (enemytowerHp <= 0)
        {
            destroyFunctiom();
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
