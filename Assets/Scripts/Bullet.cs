using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    private float velocity = 10;
    private GameObject enimy;

    void Start()
    {
        enimy = GameObject.Find("Enimy");
    }

    void Update ()
    {
        Move();
        ChangeDirection();
	}

    private void Move()
    {
        Vector3 bulletPosition = this.transform.position;
        Vector3 moving = transform.forward * Time.deltaTime * velocity;
        this.transform.position = bulletPosition + moving;
    }

    private void ChangeDirection()
    {
        Vector3 currentPosition = this.transform.position;
        Vector3 enimyPosition = enimy.transform.position;
        Vector3 enimyDirection = enimyPosition - currentPosition;

        this.transform.rotation = Quaternion.LookRotation(enimyDirection);
    }
}
