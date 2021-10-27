using UnityEngine;

public class Enemy : MonoBehaviour
{

    private Transform enemyTransform { get; set; } = null;

    private void Start()
    {
        enemyTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime;
    }
}
