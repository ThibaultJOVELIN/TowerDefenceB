using UnityEngine;
using System.Collections.Generic;

public class Tower : MonoBehaviour
{
    public GameObject _upgrade = null;
    private GameObject upgrade { get { return _upgrade; } }

    private List<Enemy> enemies { get; set; } = null;

    public float _fireRate = 0.1f;
    private float fireRate { get { return _fireRate; } set { _fireRate = value; } }

    private float currentFireRate { get; set; } = 0;

    public bool canShoot { get; set; } = true;
    private void Start()
    {
        enemies = new List<Enemy>();
    }

    private void Update()
    {
        if (!canShoot)
        {
            currentFireRate += Time.deltaTime;
            if (currentFireRate >= fireRate)
            {
                canShoot = true;
                currentFireRate = 0;
            }
            return;
        }

        if ( enemies != null && enemies.Count > 0)
        {
            if(canShoot)
            {
                //Shoot on the enemy
                
                canShoot = false;
                Destroy(enemies[0].gameObject);
                enemies.RemoveAt(0);
            }
            
        } 
        
    }

    public void  Upgrade()
    {
        if(upgrade == null)
        {
            return;
        }
        Instantiate(upgrade, transform.position, transform.rotation);
        Destroy(gameObject);

    }
    private void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        if(enemy != null)
        {
            enemies.Add(enemy);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemies.Remove(enemy);
        }
    }
}
