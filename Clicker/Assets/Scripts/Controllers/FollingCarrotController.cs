using UnityEngine;

public class FollingCarrotController : MonoBehaviour
{
    public int CoinCollectReward = 100;
    [SerializeField] private GameObject _carrotPrefab;

    [SerializeField] private Transform _carrotSpawnPoint1;
    [SerializeField] private Transform _carrotSpawnPoint2;

    [SerializeField] private float _minSpawnInterwal;
    [SerializeField] private float _maxSpawnInterwal;

    private float _spawnActualInterval;

    private void Start()
    {
        SetSpawnInterval();
    }

    private void Update()
    {
        _spawnActualInterval -= Time.deltaTime;

        if(_spawnActualInterval <= 0 )
        {
            SpawnCarrot();
            SetSpawnInterval();
        }
    }

    private void SpawnCarrot()
    {
        var spawnPosition = _carrotSpawnPoint1.position;
        spawnPosition.x = Mathf.Lerp(_carrotSpawnPoint1.position.x, _carrotSpawnPoint2.position.x, Random.Range(0, 1f));
        var go = Instantiate(_carrotPrefab, spawnPosition,Quaternion.identity);
        go.GetComponent<FallingCoin>()._collectReward = CoinCollectReward;
        Destroy(go, 12f);
    }

    private void SetSpawnInterval()
    {
        _spawnActualInterval = Random.Range(_minSpawnInterwal, _maxSpawnInterwal);
    }
}
