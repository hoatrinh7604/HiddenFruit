using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonNumberController : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] TextMeshProUGUI textValue;
    [SerializeField] int value;
    [SerializeField] Sprite[] listSprites;

    private void Start()
    {
        button.onClick.AddListener(() => OnPressButton());
    }

    public void SetInfo(int value)
    {
        this.value = value;
        textValue.text = value.ToString();
        button.image.sprite = listSprites[value];

        button.gameObject.SetActive(true);
    }

    public void OnPressButton()
    {
        //GamePlayController.Instance.OnPressHandle(value);
        //button.interactable = false;
    }
}
