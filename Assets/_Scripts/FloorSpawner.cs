using System.Collections;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _floorParts;
    private int _zPosition = 120;
    private int _index;

    private void Start()
    {
        StartCoroutine(SpawnFloor());
    }

    private IEnumerator SpawnFloor()
    {
        while (true)
        {
            _index = Random.Range(0, _floorParts.Length);
            yield return new WaitForSeconds(1.5f);
            var floor = Instantiate(_floorParts[_index]);
            floor.transform.position = new Vector3(0, 0, _zPosition);
            _zPosition += 20;
        }
    }
}