using UnityEngine;

public class InvenRotate : MonoBehaviour
{
    private Transform tr;
    internal float rotSpeed = 90f;

    void Start()
    {
        tr = transform;   
    }

    void Update()
    {
        tr.Rotate(0, rotSpeed * Time.deltaTime, 0);
    }
}
