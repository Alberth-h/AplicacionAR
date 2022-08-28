using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;


public class UIManager : MonoBehaviour
{
    [Header("Main Menu Canvas")]
    [SerializeField] GameObject closeApp;
    [SerializeField] GameObject showItems;
    [SerializeField] GameObject screenShot;

    [Header("Items Menu Canvas")]
    [SerializeField] GameObject itemsOpen;
    [SerializeField] GameObject scrollView;
    [SerializeField] float scrollViewMaxYMovement = 500;
    [SerializeField] float scrollViewMinYMovement = 180;

    [Header("AR Position Canvas")]
    [SerializeField] GameObject delete;
    [SerializeField] GameObject aprove;

    [SerializeField] float delayTime = 0.3f;
    private Vector3 _show = new Vector3(1, 1, 1);
    private Vector3 _hide = new Vector3(0, 0, 0);

    void Start()
    {
        GameManager.instance.OnMainMenu += ActivateMainMenu;
        GameManager.instance.OnItemsMenu += ActivateItemsMenu;
        GameManager.instance.OnARPosition += ActivateARPosition;
    }

    private void ActivateMainMenu()
    {
        closeApp.transform.DOScale(_show, delayTime);
        showItems.transform.DOScale(_show, delayTime);
        screenShot.transform.DOScale(_show, delayTime);

        itemsOpen.transform.DOScale(_hide, delayTime);
        scrollView.transform.DOScale(_hide, delayTime);
        scrollView.transform.DOMoveY(scrollViewMinYMovement, delayTime);

        delete.transform.DOScale(_hide, delayTime);
        aprove.transform.DOScale(_hide, delayTime);
    }

    private void ActivateItemsMenu()
    {
        closeApp.transform.DOScale(_hide, delayTime);
        showItems.transform.DOScale(_hide, delayTime);
        screenShot.transform.DOScale(_hide, delayTime);

        itemsOpen.transform.DOScale(_show, delayTime);
        scrollView.transform.DOScale(_show, delayTime);
        scrollView.transform.DOMoveY(scrollViewMaxYMovement, delayTime);
    }

    private void ActivateARPosition()
    {
        closeApp.transform.DOScale(_hide, delayTime);
        showItems.transform.DOScale(_hide, delayTime);
        screenShot.transform.DOScale(_hide, delayTime);

        itemsOpen.transform.DOScale(_hide, delayTime);
        scrollView.transform.DOScale(_hide, delayTime);
        scrollView.transform.DOMoveY(scrollViewMinYMovement, delayTime);

        delete.transform.DOScale(_show, delayTime);
        aprove.transform.DOScale(_show, delayTime);
    }
}
