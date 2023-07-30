using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    [SerializeField] private UpgradePrototype _prototype;
    [SerializeField] private Shop _shop;

    [SerializeField] private TextMeshProUGUI _nameText;
    [SerializeField] private TextMeshProUGUI _descriptionText;
    [SerializeField] private TextMeshProUGUI _priceText;
    [SerializeField] private TextMeshProUGUI _leveText;
    [SerializeField] private Image _image;

    public void UpdateLevelInfo()
    {
        var level = _shop.UpgradeController.GetUpgredeLevel(_prototype);
        var levelinfo = _prototype.Levels[level];

        if(level  >= _prototype.Levels.Count)
        {
            _priceText.text = "-";
            _leveText.text = "MAX lvl";
        }

        _priceText.text = levelinfo.Price.ToString();
        _leveText.text = $"{level + 1} level";
    }

    private void Start()
    {
        _nameText.text =_prototype.Name;
        _descriptionText.text =_prototype.Description;
        _image.sprite = _prototype.Sprite;
    }

    private void OnEnable()
    {
        UpdateLevelInfo();
    }
}
