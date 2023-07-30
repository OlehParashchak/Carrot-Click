using UnityEngine;
using UnityEngine.EventSystems;

public class ClickableCarrot : MonoBehaviour, IPointerClickHandler
{
    public EconomicController EconomicController;

    public float GrowingRate = 1f;
    public int MoneyPerClick;

    private void Update()
    {
        if(transform.localScale.x < 0.4)
        {
            transform.localScale += Vector3.one * (Time.deltaTime * GrowingRate);
        }
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        EconomicController.Money += MoneyPerClick;
        AudioManager.Instance.PlaySFX("ClickCarrot");
        transform.localScale = Vector3.one * 0.3f;
    }
}
