using UnityEngine;

public class GetCamera : MonoBehaviour
{
    public static GetCamera instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public Camera mainCamera;
}
