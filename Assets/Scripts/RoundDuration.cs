using UnityEngine;
using System;

public class RoundDuration : MonoBehaviour
{

    public static RoundDuration Instance;

    private int _roundDuration = 0;
    public int Duration => _roundDuration;

    private float _timer = 0f;

    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= 1)
        {
            _timer = 0f;

            _roundDuration++;

           
        }
    }
}
