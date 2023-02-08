using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateFixedUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Fixed update is Update but fixed
    void FixedUpdate()
    {
        Debug.Log("dushfuidsf :" + Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("12325477987806654 :" + Time.deltaTime);
    }
}
