using Core.Values;
using UnityEngine;

public class PinchFloat : MonoBehaviour
{
    [SerializeField] private FloatValue _value;
    [SerializeField] private float _sensitivity = 1;

    // Update is called once per frame
    private void Update()
    {
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

            float difference = currentMagnitude - prevMagnitude;

            PerformZoom(difference * Time.deltaTime * _sensitivity);
        }

        var wheel = Input.GetAxis("Mouse ScrollWheel");
        if (wheel == 0) return;
        PerformZoom(wheel * Time.deltaTime * _sensitivity);
    }

    private void PerformZoom(float increment)
    {
        _value.Value -= increment;
    }
}