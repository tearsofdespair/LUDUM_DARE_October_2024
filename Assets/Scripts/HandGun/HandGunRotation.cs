using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunRotation : MonoBehaviour
{
    [SerializeField] public Camera mainCamera;
    
    void Update()
    {
        // Получаем позицию курсора в мировых координатах
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.up, transform.position); // Плоскость, на которой находится объект

        float hitDistance;
        if (plane.Raycast(ray, out hitDistance))
        {
            Vector3 mousePosition = ray.GetPoint(hitDistance);

            // Вычисляем направление от объекта к позиции курсора
            Vector3 direction = mousePosition - transform.position;

            // Устанавливаем вращение объекта, чтобы он смотрел в сторону курсора
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = lookRotation;
        }
    }
}
