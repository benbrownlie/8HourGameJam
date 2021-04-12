using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBehavior : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject Shooter;
    public float TimeBetweenShots;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject _bullet;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _bullet = Instantiate(Bullet.gameObject, Shooter.transform.position, Shooter.transform.rotation);

            BulletBehavior MoveBullet = _bullet.GetComponent<BulletBehavior>();
        }
    }
}
