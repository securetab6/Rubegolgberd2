using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movmentc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, 50) * Time.deltaTime * Input.GetAxis("Horizontal");
        transform.position += new Vector3(0, 50, 0) * Time.deltaTime * Input.GetAxis("Vertical");
    }
}
