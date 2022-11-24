using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    [SerializeField]
    public GameObject enemy;

    [SerializeField]
    float spawnTime;

    [SerializeField]
    Transform spawner1;

    [SerializeField]
    Transform spawner2;

    [SerializeField]
    Transform spawner3;

    [SerializeField]
    Transform spawner4;

    Vector3 pos;

    public void FixedUpdate()
    {

        spawnTime -= Time.fixedDeltaTime;

        //executes when spawntime is less than or equal to zero
        if(spawnTime <= 0)
        {
            //generates a random number between 0 and 3
            int random = Random.Range(0, 5);

            Debug.Log("random:" + random);

            if (random == 1)
            {
                Instantiate(enemy, spawner1);
            }
            else if(random == 2)
            {
                Instantiate(enemy, spawner2);
            }
            else if (random == 3)
            {
                Instantiate(enemy, spawner3);
            }
            else if (random == 4)
            {
                Instantiate(enemy, spawner4);
            }

            spawnTime = 3;
        }
    }
}
