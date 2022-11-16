using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuInterface : MonoBehaviour
{
    [SerializeField] private Button menuButton;
    [SerializeField] private GameObject menu, coverPanel;
    [SerializeField] private List<Toggle> toggleList;
    [SerializeField] private List<GameObject> pageList;

    private bool menuOn = false;

    void Start()
    {
        for(int i = 0; i < toggleList.Count; i++)
        {
            int index = i;
            toggleList[i].onValueChanged.AddListener(delegate
            {
                TogglePages(index);
            });
        }

        menuButton.onClick.AddListener(ToggleMenu);
    }

    private void TogglePages( int index)
    {
        if (!toggleList[index].isOn)
            return;

        for(int i = 0; i < pageList.Count; i++)
        {
            if (i == index)
                pageList[i].SetActive(true);
            else
                pageList[i].SetActive(false);
        }
        ToggleMenu();
    }

    private void ToggleMenu()
    {

        menuOn = !menuOn;
        menu.SetActive(menuOn);
        coverPanel.SetActive(menuOn);
    }
}
