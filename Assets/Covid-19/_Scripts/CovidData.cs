using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class CovidData : MonoBehaviour, IPointerDownHandler
{
    public string place;
    public int confirmed;
    public int recovered;
    public int fatal;

    public GameObject SelectedInfoPanel;
    public TextMeshProUGUI LocationUI;
    public TextMeshProUGUI ConfirmedUI;
    public TextMeshProUGUI RecoveredUI;
    public TextMeshProUGUI FatalUI;

    public void OnPointerDown(PointerEventData eventData)
    {
        SelectedInfoPanel = GameObject.FindGameObjectWithTag("SelectedInfoPanel");
        LocationUI = SelectedInfoPanel.transform.Find("Location").GetComponent<TextMeshProUGUI>();
        ConfirmedUI = SelectedInfoPanel.transform.Find("Confirmed").GetComponent<TextMeshProUGUI>();
        RecoveredUI = SelectedInfoPanel.transform.Find("Recovered").GetComponent<TextMeshProUGUI>();
        FatalUI = SelectedInfoPanel.transform.Find("Fatal").GetComponent<TextMeshProUGUI>();
        SelectedInfoPanel.SetActive(true);
        LocationUI.text = place;
        ConfirmedUI.text = "Confirmed: " + confirmed.ToString();
        RecoveredUI.text = "Recovered: " + recovered.ToString();
        FatalUI.text = "Fatal: " + fatal.ToString();
    }
}
