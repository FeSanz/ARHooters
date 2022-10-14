using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ImageTargetBehaviour : MonoBehaviour
{
    [SerializeField, Tooltip("Modelo activo por target")]
    private GameObject[] Platillos;
    
    [SerializeField, Tooltip("Animacion para indicar enfoque de cámara")]
    private GameObject SearchingAnim;
    
    [SerializeField, Tooltip("Animacion para indicar enfoque de cámara")]
    private TextMeshProUGUI NamePlate;
    
    public void Update()
    {
        if (!Platillos[0].activeInHierarchy && !Platillos[1].activeInHierarchy && !Platillos[2].activeInHierarchy)
        {
            SearchingAnim.SetActive(true);
            NamePlate.SetText("AR Hooters");
        }

        if (Platillos[0].activeInHierarchy)
        {
            NamePlate.SetText("Original\nWings");
        }

        if(Platillos[1].activeInHierarchy)
        {
            NamePlate.SetText("Guacamole\nBurger");
        }
        
        if (Platillos[2].activeInHierarchy)
        {
            NamePlate.SetText("Cerveza de\nbarril");
        }
    }
}
