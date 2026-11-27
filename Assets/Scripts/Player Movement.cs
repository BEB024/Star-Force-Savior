using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;

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
        float yOffset = movement.y * moveSpeed * Time.deltaTime;

        transform.localPosition = new Vector3(transform.localPosition.x + xOffset, transform.localPosition.y + yOffset, 0f);
    }

}
