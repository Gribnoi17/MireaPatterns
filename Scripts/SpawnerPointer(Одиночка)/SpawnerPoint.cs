using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPoint : MonoBehaviour
{
    [SerializeField] private GameObject _spawnObject;
    private float _positionRandomX;
    private float _positionRandomY;
    private Vector3 _spawnPosotion;
    private GameObject _sphere;
    public static SpawnerPoint Instance { get; private set; }

    //Awake вызывается при загрузке экземпляра скрипта.
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject); //При переходе на другую сцену объект не уничтожится 
            return;
        }

        Destroy(this.gameObject);

    }

    private void Start()
    {
        SpawnPoint();
    }

    public void SpawnPoint()
    {
        _positionRandomX = Random.Range(-68f, 68f);
        _positionRandomY = Random.Range(30f, -30f);
        _spawnPosotion = new Vector3(_positionRandomX, _positionRandomY, 69f);
        _sphere = Instantiate(_spawnObject, _spawnPosotion, Quaternion.identity);
    }

    public void DestroyPoint()
    {
        Destroy(_sphere);
    }

}
