using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    [SerializeField] RectTransform zeiger;
    [SerializeField] Image area;
    [SerializeField] float areaAngle = 30;
    [SerializeField] float moveSpeed = 1;
    [SerializeField] float areaStartAngle = 270;
    void Start()
    {
        
    }
    void Update()
    {
        var eu = zeiger.transform.eulerAngles;
        eu.z += Time.deltaTime * moveSpeed;
        float x = eu.z;
        zeiger.transform.eulerAngles = eu;


        eu = area.transform.eulerAngles;
        eu.z = areaStartAngle - 270;
        area.transform.eulerAngles = eu;

        float a = areaStartAngle;
        float b = areaStartAngle - areaAngle;

        area.fillAmount = areaAngle / 360.0f;

        print((a < x && x < b)  +" " + a + " " + x + " " + b); 
    }

}
