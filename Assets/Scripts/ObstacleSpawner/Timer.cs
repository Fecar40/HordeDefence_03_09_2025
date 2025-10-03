using System;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _duration = 1f;
    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;

        Debug.Log(_timer);
        if (_timer >= _duration)
        {
            _timer = 0f;

        }
    }
}
