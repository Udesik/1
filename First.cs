using UnityEngine;

public class sphere : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime); 
    }
}
