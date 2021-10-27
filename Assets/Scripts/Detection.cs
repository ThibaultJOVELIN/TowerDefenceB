using UnityEngine;

public class Detection : MonoBehaviour
{

    private Tower towerParent { get; set; } = null;

    private void Start()
    {
        towerParent = GetComponentInParent<Tower>();

    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy != null)
        {
            towerParent.AddEnemy(enemy);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy != null)
        {
            towerParent.RemoveEnemy(enemy);
        }
    }
}
