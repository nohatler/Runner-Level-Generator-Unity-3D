using System.Collections.Generic;
using UnityEngine;

public class GeneratorSegments : MonoBehaviour
{
    [SerializeField] private GeneratorConfig _generatorConfig;
    [SerializeField] private Transform _target;

    private List<GameObject> _segments = new List<GameObject>();
    private float _sizeSegment;
    private float _spawnPositionSegment;

    private void Update()
    {
        if (_segments.Count == 0)
        {
            _sizeSegment = _generatorConfig.GetSizeSegment();
            for (int i = 0; i < _generatorConfig.GetMaxActiveSegments(); i++)
                SPAWNSEGMENT();
        }

        if (_target.position.z - _sizeSegment * _generatorConfig.GetChuckSize() > _spawnPositionSegment - _generatorConfig.GetMaxActiveSegments() * _sizeSegment)
        {
            for (int i = 0; i < _generatorConfig.GetChuckSize(); i++)
            {
                SPAWNSEGMENT();
                DESTROYSEGMENT();
            }
        }
    }
    public void SPAWNSEGMENT()
    {
        var randomIndex = Random.Range(0, _generatorConfig.GetSegments().Count);
        var randomSegment = _generatorConfig.GetSegmentByIndex(randomIndex);
        var segmentPrefab = randomSegment.segmentPrefab;
        var newSegment = Instantiate(segmentPrefab);
        _segments.Add(newSegment);

        newSegment.transform.position = new Vector3(newSegment.transform.position.x, newSegment.transform.position.y, _spawnPositionSegment);
        _spawnPositionSegment += _sizeSegment;
    }
    public void DESTROYSEGMENT()
    {
        Destroy(_segments[0]);
        _segments.RemoveAt(0);
    }
}
// Autor git: nohatler