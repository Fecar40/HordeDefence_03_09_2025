using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndZoneCollision : MonoBehaviour
{
    //public event Action EnemyCollidedEndZone;

    private void OnTriggerEnter(Collider other)
    {
        /*if (other.TryGetComponent<Crate>(out _))
            Destroy(other.gameObject);
        if (other.TryGetComponent<ArchBase>(out _))
            Destroy(other.gameObject);
        if (other.TryGetComponent<EnemyHealth>(out _))
            EnemyCollidedEndZone?.Invoke();*/
        SceneManager.LoadScene(0);
    }
}
