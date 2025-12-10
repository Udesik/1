using UnityEngine;

public class Second : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.Rotate(Vector3.up * _speed * Time.deltaTime);
    }
}
