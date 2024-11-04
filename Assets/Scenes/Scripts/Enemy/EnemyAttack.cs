using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    [SerializeField] float range;
    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // if player is dead, do nothing
        if (player == null) return;
        var playerPos = player.transform.position;

        var displacement = playerPos - transform.position;
        var distance = displacement.magnitude;

        if (distance < range)
        {
            GetComponent<Weapon>().Shoot(displacement / distance);
        }

    }
}