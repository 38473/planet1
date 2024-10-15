using UnityEngine;

public class ScaleSolarSystem : MonoBehaviour
{
    private float initialDistance;
    private Vector3 initialScale;

    void Update()
    {
        
        if (Input.touchCount == 2)
        {
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);

            if (touch1.phase == TouchPhase.Began || touch2.phase == TouchPhase.Began)
            {
      
                initialDistance = Vector2.Distance(touch1.position, touch2.position);
      
                initialScale = transform.localScale;
                Debug.Log("Initial Distance: " + initialDistance);
            }
            else if (touch1.phase == TouchPhase.Moved || touch2.phase == TouchPhase.Moved)
            {
               
                float currentDistance = Vector2.Distance(touch1.position, touch2.position);
                Debug.Log("Current Distance: " + currentDistance);

                if (Mathf.Approximately(initialDistance, 0)) return;

                float scaleFactor = currentDistance / initialDistance;
                Debug.Log("Scale Factor: " + scaleFactor);

       
                transform.localScale = initialScale * scaleFactor;
            }
        }
    }
}