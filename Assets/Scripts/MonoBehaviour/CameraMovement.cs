#region Libraries
using UnityEngine;
#endregion

#region Dependencies
[RequireComponent(typeof(Camera))]
#endregion

public class CameraMovement : MonoBehaviour
{
    #region Variables
    private new Camera camera;
    [SerializeField] Vector2 minPos;
    [SerializeField] Vector2 maxPos;
    [SerializeField] GameObject player;
    #endregion

    #region Unity Methods
    void Start()
    {
        camera = GetComponent<Camera>();
    }

    void Update()
    {
        (float x, float y) = GetCameraPosition();
        transform.position = new Vector3(x, y, -10f);
    }
    #endregion

    #region Methods
    private (float, float) GetCameraPosition()
    {
        Vector2 playerPos = player.transform.position;
        float cameraHeight = camera.orthographicSize;
        float cameraWidth = cameraHeight * camera.aspect;

        float x = Mathf.Clamp(playerPos.x, minPos.x + cameraWidth, maxPos.x - cameraWidth);
        float y = Mathf.Clamp(playerPos.y, minPos.y + cameraHeight, maxPos.y - cameraHeight);

        return (x, y);
    }
    #endregion
}
