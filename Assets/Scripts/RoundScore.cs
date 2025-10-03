using UnityEngine;
using UnityEngine.Events;

public class RoundScore : MonoBehaviour
{
    //[SerializeField] private SoldierSpawner _soldierSpawner;
    [SerializeField] private RoundDuration _roundDuration;

    public UnityAction<int> Changed;
    public UnityAction<int> Finished;

    private int _score = 0;

    private void OnEnable()
    {
        //_soldierSpawner.AmountLimiterTriggered += OnAmountLimiterTriggered;
       
    }

    private void OnDisable()
    {
        //_soldierSpawner.AmountLimiterTriggered -= OnAmountLimiterTriggered;
        
    }

    private void OnAmountLimiterTriggered()
    {
        Add();
    }

    private void OnRoundDurationChanged()
    {
        Add();
    }

    private void Add()
    {
        _score++;
        Changed?.Invoke(_score);
    }
}
