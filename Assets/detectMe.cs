using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectMe : MonoBehaviour
{
    public Camera dCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        dCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = dCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.GetRayIntersection(ray);

        if (hit.collider != null)
        {
            Destroy(hit.collider.gameObject);

        }else
        {

        }
        //if( Physics.Raycast(ray, out hit ))
        {
            Transform objecthit = hit.transform;
            //Debug.Log("je suis un oiseau et toi?");
          
        }

    }
}
