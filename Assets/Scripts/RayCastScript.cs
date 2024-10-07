using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastScript : MonoBehaviour
{
    private Camera _cam;
    public List<GameObject> Guns = new List<GameObject>();

    void Start()
    {
        _cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 100f;
        mousePos = _cam.ScreenToWorldPoint(mousePos);

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 100))
            {
                Debug.Log(hit.transform.name);
                if(hit.collider.gameObject.name == "ActiveGunLoot(Clone)")
                {
                    Guns[1].SetActive(true);
                }else if (hit.collider.gameObject.name == "AutoGunLoot(Clone)")
                {
                    Guns[0].SetActive(true);
                }
                else
                {
                    return;
                }
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
