using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float xLimitRange = 5f;
    [SerializeField] private float yLimitRange = 5f;

    Vector2 movement;

    void Start()
    {
        
    }

    void Update()
    {
        ShipTranslation();
    }

    public void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    public void ShipTranslation()
    {
        float xOffset = movement.x * moveSpeed * Time.deltaTime;
        float newXPosition = transform.localPosition.x + xOffset;
        float clampedXPosition = Mathf.Clamp(newXPosition, -xLimitRange, xLimitRange);

        float yOffset = movement.y * moveSpeed * Time.deltaTime;
        float newYPosition = transform.localPosition.y + yOffset;
        float clampedYPosition = Mathf.Clamp(newYPosition, -yLimitRange, yLimitRange);

        transform.localPosition = new Vector3(clampedXPosition, clampedYPosition, 0f);
    }

}
