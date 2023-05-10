using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciocan2 : MonoBehaviour
{
    float rotateSpeed = 50f;
    float rotateAngle = 90f; 

   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Lovire());
        }
    }

    IEnumerator Lovire()
    {
        float angle = 0f;
        float time = 0.5f;

        while (angle < rotateAngle)
        {
            angle += rotateSpeed * Time.deltaTime;
            transform.Rotate(Vector3.right, rotateSpeed * Time.deltaTime);
            yield return null;
        }

        yield return new WaitForSeconds(time - rotateAngle / rotateSpeed);

        while (angle > 0f)
        {
            angle -= rotateSpeed * Time.deltaTime;
            transform.Rotate(Vector3.left, rotateSpeed * Time.deltaTime);
            yield return null;
        }
    }
}
