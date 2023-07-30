using UnityEngine;
using UnityEngine.EventSystems;

public class FallingCoin : MonoBehaviour, IPointerClickHandler
{
    public int _collectReward = 100;
    [SerializeField] private float _speed = 1f;

    private void Update()
    {
        transform.position += new Vector3(0,1,0) * _speed * Time.deltaTime;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        AudioManager.Instance.PlaySFX("FallingCarrot");
        EconomicController.Instance.Money += _collectReward;
        Destroy(gameObject);
    }
}
