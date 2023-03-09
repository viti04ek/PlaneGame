using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float BulletSpeed;
    public AudioSource ShotSound;

    public float ShotPeriod;
    private float _timer;


    void Update()
    {
        _timer += Time.deltaTime;

        if (Input.GetKey(KeyCode.Space))
        {
            if (_timer > ShotPeriod)
            {
                CreateBullet();
                _timer = 0;
            }
        }
    }


    private void CreateBullet()
    {
        GameObject newBullet = Instantiate(BulletPrefab, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody>().velocity = transform.forward * BulletSpeed;

        ShotSound.pitch = Random.Range(0.8f, 1.2f);
        ShotSound.Play();
    }
}
