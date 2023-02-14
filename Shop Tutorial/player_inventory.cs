using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_inventory : MonoBehaviour
{
    public GameObject slotContainer;
    private int slotCount = 8;
    private GameObject slot;
    private GameObject slotImage;
    
    void Start()
    {
        // Debug Code
        for(int i = 0; i < slotCount; i++){
            slot = slotContainer.transform.GetChild(i).gameObject;
            slotImage = slot.transform.GetChild(0).gameObject;    
            if(slotImage.GetComponent<Image>().sprite == null){
                Debug.Log("slot " + (i+1) + " empty");
            }
            else{
                Debug.Log("slot " + (i+1) + " not empty");
            }            
        }
    }

    public void AddItem(GameObject itemPanel){
        GameObject image;
        Sprite icon;

        image = itemPanel.transform.GetChild(0).gameObject;
        icon = image.GetComponent<Image>().sprite;

        for(int i = 0; i < slotCount; i++){
            slot = slotContainer.transform.GetChild(i).gameObject;
            slotImage = slot.transform.GetChild(0).gameObject;    
            if(slotImage.GetComponent<Image>().sprite == null){
                slotImage.GetComponent<Image>().sprite = icon; 
                slotImage.GetComponent<Image>().color = new Color32(255,255,255,255);
                break;
            }                    
        }
        return;
    }

}
