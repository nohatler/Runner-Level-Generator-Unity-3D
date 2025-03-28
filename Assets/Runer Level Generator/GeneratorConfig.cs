using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorConfig : ScriptableObject
{
    [SerializeField] private int _chunkSize;
    [SerializeField] private int _maxActiveSegments;
    [SerializeField] private float _sizeSegment;
    [SerializeField] private List<Segment> _segments;

    [Serializable]
    public class Segment
    {
        public int index; // if u need
        public GameObject segmentPrefab;
    }

    #region Get
    public List<Segment> GetSegments() => _segments;
    public Segment GetSegmentByIndex(int index) => _segments[index];
    public int GetChuckSize() => _chunkSize;
    public int GetMaxActiveSegments() => _maxActiveSegments;
    public float GetSizeSegment() => _sizeSegment;

    #endregion
}
