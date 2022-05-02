using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButton : MonoBehaviour
{
    public GameObject inventoryCanvas;

    public bool GameIsPaused = false;

    void Update() {
        if (Input.GetKeyDown(KeyCode.I)){
            if(GameIsPaused){
                Resume();
            }
            else{
                Pause();
            }
    }        
    }

    void Resume(){
        inventoryCanvas.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause(){
        inventoryCanvas.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
