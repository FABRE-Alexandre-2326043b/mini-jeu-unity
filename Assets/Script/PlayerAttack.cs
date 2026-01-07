using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public bool hasFireballAbility = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && hasFireballAbility)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (projectilePrefab != null && firePoint != null)
        {
            Instantiate(projectilePrefab, firePoint.position, transform.rotation);
        }
    }

    public void UnlockAbility()
    {
        hasFireballAbility = true;
        Debug.Log("Pouvoir boule de feu débloqué !");
    }
}