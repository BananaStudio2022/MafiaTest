using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterPanel : MonoBehaviour
{
    [SerializeField] private GameObject letterCanvas;
    [SerializeField] private GameObject inventoryCanvas;

    public void LetterHandler(){
        letterCanvas.SetActive(true);
        inventoryCanvas.SetActive(false);
    }
}
