using Core.Values;
using UnityEngine;

public class MoveFloats : MonoBehaviour
{
    [SerializeField] private FloatValue _x; 
    [SerializeField] private FloatValue _y; 
    [SerializeField] private FloatValue _z;
    [SerializeField] private float _sensitivity = 1;
    private Vector3 touchStart;

    private void Update()
    {
        if (Input.touchCount > 1)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            touchStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 direction = touchStart - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction *= Time.deltaTime * _sensitivity;
            _y.Value += -direction.x;
            _x.Value += -direction.y;
            _z.Value += direction.z;
        }
    }
}
