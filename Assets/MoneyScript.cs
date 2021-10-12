using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour
{
    public TextMeshProUGUI moneyText;
    public Button buton5tl;
    public Button buton10tl;
    public Button buton50tl;
    int money;
    // Start is called before the first frame update
    void Start()
    {
        money = 150;
        moneyText.text = money.ToString();
        buton5tl.onClick.AddListener(ButonClick5tl);
        buton10tl.onClick.AddListener(ButonClick10tl);
        buton50tl.onClick.AddListener(ButonClick50tl);
    }
    void ButonClick5tl()
    {
        money = money - 5;
    }
    void ButonClick10tl()
    {
        money = money - 10;
    }
    void ButonClick50tl()
    {
        money = money - 50;
    }

    // Update is called once per frame
    void Update()
    {
        
        moneyText.text = money.ToString();
    }
}
