using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime;
    }
}
