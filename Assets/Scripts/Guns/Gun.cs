using UnityEngine;

public class Guns : MonoBehaviour
{
    [SerializeField] Rigidbody _bulletPrefab;
    [SerializeField] Transform _spawn;
    [SerializeField] float _bulletSpeed = 18f;
    [SerializeField] float _shotPeriod = 0.2f;
    [SerializeField] AudioSource _shotSound;
    //[SerializeField] GameObject _flash;
    [SerializeField] ParticleSystem _shotEffect;
    private float _timer;
    void Update()
    {
        _timer += Time.unscaledDeltaTime;
        if (_timer > _shotPeriod)
        {
                Shot();
        }
    }

    public virtual void Shot()
    {
        _timer = 0;
        var newbullet = Instantiate(_bulletPrefab, _spawn.position, _spawn.rotation);
        newbullet.linearVelocity = _spawn.forward * _bulletSpeed;
        //_shotSound.Play();
        //_flash.SetActive(true);
        //Invoke(nameof(HideFlash), 0.12f);
        _shotEffect.Play();
    }
    private void HideFlash()
    {
       // _flash.SetActive(false);
    }

    public virtual void Activate()
    {
        gameObject.SetActive(true);
    }

    public virtual void Deactivate()
    {
        gameObject.SetActive(false);
    }

    public virtual void AddBullets(int numberOfBullets)
    {

    }
}
