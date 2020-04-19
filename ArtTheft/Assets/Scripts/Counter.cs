using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Counter : MonoBehaviour
{
    public float Count;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed left click, casting ray.");
            //CastRay();



            /*Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);


            if (hit.collider != null)
            {

                Debug.Log("Something was clicked!");
                Count++;
            }*/
        }
       /* void CastRay()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                Debug.DrawLine(ray.origin, hit.point);
                Debug.Log("Hit detected");
                if (hit.collider == hit) Count = Count + 0.1f;
            }
        }*/





    }
}

