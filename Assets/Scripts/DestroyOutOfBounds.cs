using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topbound = 47;
    private float lowbound = -46;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > topbound) {
            Destroy(gameObject); }
        else if (transform.position.x < lowbound)
            { Destroy(gameObject); }
    }
}
