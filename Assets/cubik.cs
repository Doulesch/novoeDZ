using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubik : MonoBehaviour
{
    private GameObject top;
    // Start is called before the first frame update
    private void Start()
    {
        top = gameObject.transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
   
}
