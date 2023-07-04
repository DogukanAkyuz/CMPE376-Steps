using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdamScream : MonoBehaviour
{
    public float fireRate = 0.2f;
    public Transform firingPoint;
    public GameObject bulletPrefab;
    public AudioSource scr;
    public Animator anim;

    float timeUntilFire;
    PlayerMovementScript pm;

    private void Start()
    {
        pm = gameObject.GetComponent<PlayerMovementScript>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if( Input.GetMouseButtonDown(1) && timeUntilFire < Time.time)
        {
            anim.SetTrigger("Scream");
            Shoot();
            timeUntilFire = Time.time + fireRate;
        }
    }

    void Shoot()
    {
        Scream();
        float angle = pm.isFacingRigt ? 0f : 180f;
        Instantiate(bulletPrefab, firingPoint.position, Quaternion.Euler(new Vector3(0f, 0f, angle)));
    }

    private void Scream()
    {
        scr.Play();
    }
}
