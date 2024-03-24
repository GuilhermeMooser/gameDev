using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    public GameObject enemyBullet;
    public Transform spawnPoint;
    public float rangeToShoot;

    public float enemySpeed;
    [SerializeField] private float Timer = 5;
    
    bool isShooting;

    
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        enemy.SetDestination(Player.position);
        
        float distance = Vector3.Distance(transform.position, Player.position);

        if (distance <= rangeToShoot)
        {
            if (!isShooting)
            {
                InvokeRepeating("ShootAtPlayer", 0f, 0.5f);
                isShooting = true;
            }
        }
        else
        {
            CancelInvoke("ShootAtPlayer");
            isShooting = false;
        }
    }
    
    void ShootAtPlayer()
    {
        GameObject bulletObj = Instantiate(enemyBullet, spawnPoint.position, spawnPoint.rotation);

        Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
        bulletRig.AddForce((Player.position - spawnPoint.position).normalized * 100, ForceMode.Impulse);
        Destroy(bulletObj, 1f);
    }
}
