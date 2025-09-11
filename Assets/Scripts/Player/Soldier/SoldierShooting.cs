using UnityEngine;

public class SoldierShooting : Soldier
{
    public ParticleSystem shootCollisionParticles;
    [SerializeField] private LayerMask shootableLayers;

    private float _shootTimer = 0f;

    private void Update()
    {
        _shootTimer += Time.deltaTime;

        if (_shootTimer >= fireRate)
        {
            Shoot();
            _shootTimer = 0f;
        }
    }

    private void Shoot()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.LogWarning("Hello");
        if (Physics.Raycast(ray, out RaycastHit hit, range, shootableLayers))
        {
            if (hit.collider.TryGetComponent<IDamageable>(out IDamageable obstacle))
                obstacle.TakeDamage(damage);
            Debug.DrawLine(transform.position, hit.point,Color.green);

            shootCollisionParticles.Play();
            shootCollisionParticles.transform.position = hit.point;
        }
    }
}
