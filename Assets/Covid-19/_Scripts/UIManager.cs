using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject InfoPanel;
    public Toggle InfoPanelToggle;
    public GameObject SelectedInfoPanel;
    public Toggle SelectedInfoPanelToggle;
    public void ToggleInfoPanel() 
    {
        InfoPanel.SetActive(InfoPanelToggle.isOn);
    }

    public void ToggleSelectedInfoPanel() 
    {
        SelectedInfoPanel.SetActive(SelectedInfoPanelToggle.isOn);
    }
}
