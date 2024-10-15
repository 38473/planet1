using UnityEngine;

public class PinchToZoom : MonoBehaviour
{
    public float zoomSpeed = 0.1f; 
    private Vector3 initialScale; 

    void Start()
    {
        initialScale = transform.localScale; 
    }

    void Update()
    {
        if (Input.touchCount == 2)
        {
            
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);

       
            float prevDistance = (touch1.position - touch1.deltaPosition - (touch2.position - touch2.deltaPosition)).magnitude;
            float currentDistance = (touch1.position - touch2.position).magnitude;

           
            float scaleChange = (currentDistance - prevDistance) * zoomSpeed;

            
            transform.localScale += new Vector3(scaleChange, scaleChange, scaleChange);
        }
    }
}
