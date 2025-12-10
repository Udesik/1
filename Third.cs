using UnityEngine;

public class Third : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _growthRate = new Vector3(1f, 1f, 1f);

    void Update()
    {
        transform.localScale += _growthRate * _speed * Time.deltaTime;
    }
}
