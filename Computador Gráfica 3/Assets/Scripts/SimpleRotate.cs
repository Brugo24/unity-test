using UnityEngine;

public class SimpleRotate : MonoBehaviour
{
    public float degrees = 50f;
    private bool rotatestate = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotatestate)
        {
            transform.Rotate(0f, degrees * Time.deltaTime, 0f);
        }
    }

    private void OnMouseDown()
    {
        rotatestate = !rotatestate;
    }
}
