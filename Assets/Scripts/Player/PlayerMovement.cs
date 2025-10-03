using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private FloatingJoystick _joystick;

    [SerializeField]  private float MinAllowedPositionX = -2f;
    [SerializeField]  private float MaxAllowedPositionX = 2f;
    [SerializeField] private  float Speed = 8f;

    private void Update()
    {
        float moveX = _joystick.Horizontal * Speed * Time.deltaTime;

        transform.Translate(moveX, 0f, 0f);

        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, MinAllowedPositionX, MaxAllowedPositionX);
        transform.position = position;
    }
}
