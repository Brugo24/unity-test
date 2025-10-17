using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.5f * Time.deltaTime, 0f, 0f);
    }
}
