using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public GameObject CEffect;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray2D ray = new Ray2D(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null && hit.collider.CompareTag("ClickZone"))
            {
                Debug.Log("Ŭ��!");
                StartCoroutine(Effect());
            }
            
        }
    }

    IEnumerator Effect()
    {
        Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        clickPosition.z = 0;
        GameObject ClickEffect = Instantiate(CEffect, clickPosition, Quaternion.identity);
        yield return new WaitForSeconds(0.2f);
        Destroy(ClickEffect);
    }
}
