using UnityEngine;

public class PlayerArmory : MonoBehaviour
{
    [SerializeField] private Guns[] _guns;
    [SerializeField] private int _currentGunIndex;
    private void Start()
    {
        TakeGunByIndex(_currentGunIndex);
    }

    public void TakeGunByIndex(int gunIndex)
    {
        _currentGunIndex = gunIndex;
        for (int i = 0; i < _guns.Length; i++)
        {
            if (i == gunIndex)
            {
                _guns[i].Activate();
            }
            else
            {
                _guns[i].Deactivate();
            }
        }
    }

    public void AddBulets(int gunIndex, int numberOfBullets)
    {
        //_guns[gunIndex].AddBullets(numberOfBullets);
    }
}
