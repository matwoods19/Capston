using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    [SerializeField]
    float speed;

    [SerializeField]
    float AttackTime = 3;

    [SerializeField]
    GameObject Player;

    [SerializeField]
    GameObject canvas;

    Vector3 playerPos = new Vector3(0, 1, 0);
    private void Update()
    {
        Vector3 lookAt = playerPos - transform.position;
        lookAt.y = transform.position.y;
        Quaternion rot = Quaternion.LookRotation(lookAt);
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, 1);
    }

    void FixedUpdate ()
    {

        transform.LookAt(playerPos);


        if (gameObject.transform.position != new Vector3(1, 1, 1))
        {
            transform.position += transform.forward * speed * Time.fixedDeltaTime;
        }
        
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Attack")
        {
            Debug.Log("Start Attack");

            AttackTime -= Time.deltaTime;

            if (AttackTime <= 0)
            {
                canvas.SetActive(true);

                //Time.timeScale = 0;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Sword")
        {
            Destroy(gameObject);
        }
    }
}
