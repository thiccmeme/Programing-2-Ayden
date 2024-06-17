using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.Ayden.namespaces.MVC
{
    public class Shooter : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);// creates ray at mouse position from camera
                if (Physics.Raycast(ray,out RaycastHit hit, Mathf.Infinity))
                {
                    var shootable = hit.transform.GetComponent<IShootable>();
                    shootable?.GetDamage();// check to make sure hit component has getdamage component, if not do nothing
                }
            }
        }
    }
}
