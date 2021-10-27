using UnityEngine;

public class CameraAction : MonoBehaviour
{

    private Transform cameraTransform { get; set; } = null;
    private void Start()
    {
        cameraTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        DrawRay();

        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, Camera.main.farClipPlane));

            if (Physics.Raycast(cameraTransform.position, worldPosition - cameraTransform.position, out RaycastHit hit))
            {
                Debug.Log(hit.transform.name);
                Tower tower = hit.transform.GetComponent<Tower>();
                if(tower != null)
                {
                    tower.Upgrade();
                }
            }
        }
    }
    private void DrawRay()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, Camera.main.farClipPlane));

        Debug.DrawRay(cameraTransform.position, worldPosition - cameraTransform.position, Color.red);
    }
}
