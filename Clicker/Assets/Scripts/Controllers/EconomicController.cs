using UnityEngine;
using TMPro;

public class EconomicController : MonoBehaviour
{
    public static EconomicController Instance;

    public  TextMeshProUGUI[] MoneyText = new TextMeshProUGUI[2]; 
    public int Money
    {
        get { return _money; }
        set 
        {
            _money = value;
            UpdateText();
        }
    }

    private int _money;

    private void Awake()
    {
        _money = PlayerPrefs.GetInt(GlobalConstant.TOTAL_MONEY_KEY);
        UpdateText();
        Instance = this;
    }

    private void UpdateText()
    {
        for(int i = 0; i < MoneyText.Length; i++)
        {
            MoneyText[i].text = Money.ToString();
        }
    }
    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt(GlobalConstant.TOTAL_MONEY_KEY, _money);
        PlayerPrefs.Save();
    }
}
