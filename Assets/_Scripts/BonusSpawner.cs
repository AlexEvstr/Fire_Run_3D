using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _bonus;
    [SerializeField] private GameObject _player;

    private void Start()
    {
        StartCoroutine(SpawnBonus());
    }

    private IEnumerator SpawnBonus()
    {
        while(true)
        {
            float time = Random.Range(2, 5);
            float yPosition = Random.Range(1, 5);
            yield return new WaitForSeconds(time);
            var bonus = Instantiate(_bonus);
            bonus.transform.position = new Vector3(0, yPosition, _player.transform.position.z + 100);
        }
    }
}
