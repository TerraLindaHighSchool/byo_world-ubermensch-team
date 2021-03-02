using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrthoCameraMan : MonoBehaviour
{
    public int distance;
    // x^2 + 9x^2 = y^2
    
    void Update()
    {
        int proportion = 3;
        float floatX = Mathf.Sqrt((distance^2)/(proportion^2+1));
        this.gameObject.transform.position = new Vector3(floatX, 3 * floatX, floatX);
        Debug.Log(floatX);
    }
}
