using UnityEngine;

public class MouseLookY : MonoBehaviour
{
    public float mouseSensitivity = 200f;

    private float yRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        yRotation += mouseX;

        transform.rotation = Quaternion.Euler(0f, yRotation, 0f);
    }
}