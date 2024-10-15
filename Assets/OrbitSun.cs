using UnityEngine;

public class OrbitSun : MonoBehaviour
{
    public Transform sun; 
    public float orbitSpeed = 10f; 
    public float orbitRadius = 5f; 

    private float angle;

    void Update()
    {
      
        angle += orbitSpeed * Time.deltaTime;

        float x = Mathf.Cos(angle) * orbitRadius;
        float z = Mathf.Sin(angle) * orbitRadius;
        transform.position = new Vector3(x, transform.position.y, z);
    }
}
