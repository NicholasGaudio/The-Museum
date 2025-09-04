using UnityEngine;

public class CursorActivator : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true; // Ensure cursor is visible
        Cursor.lockState = CursorLockMode.None; // Ensure cursor is not locked
    }
}
