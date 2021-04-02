using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Weapon : MonoBehaviour { 
    public Transform firePoint;
    public GameObject projectilPrefab;
    public string Fired = "Fire1";
    private float fireRate = 0.3f;
    private float nextFire = 0f;
    public int damage = 1;

    public void Shoot()
    {
        GameObject newProjectile = Instantiate(projectilPrefab, firePoint.position, firePoint.rotation);
        
        StartCoroutine(RemoveAfterSeconds(6, newProjectile));
    }
    

    void Update()
    {
        bool fired = Input.GetButton(Fired);
       if(fired && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Shoot();
            Debug.Log("Firing");
            
        }
           
    }
    IEnumerator RemoveAfterSeconds(int seconds, GameObject projectile)
    {
        yield return new WaitForSeconds(seconds);
        Object.Destroy(projectile);
    }
    
    
    
}
