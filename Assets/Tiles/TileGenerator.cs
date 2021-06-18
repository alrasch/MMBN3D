using System;
using UnityEngine;

namespace Tiles
{
    public class TileGenerator : MonoBehaviour
    {
        public GameObject frame;
        public GameObject tile;
        void Start()
        {
            Tuple<int, int, int>[] tilePositions =
            {
                Tuple.Create(0, 0, 0),
                Tuple.Create(1, 0, 0),
                Tuple.Create(2, 0, 0),
                Tuple.Create(3, 0, 0),
                Tuple.Create(4, 0, 0),
                Tuple.Create(5, 0, 0),
                Tuple.Create(6, 0, 0),
                Tuple.Create(0, 0, 1),
                Tuple.Create(1, 0, 1),
                Tuple.Create(2, 0, 1),
                Tuple.Create(3, 0, 1),
                Tuple.Create(4, 0, 1),
                Tuple.Create(5, 0, 1),
                Tuple.Create(6, 0, 1),
            };
            foreach (var (x, y, z) in tilePositions)
            {
                Instantiate(frame, new Vector3(x, y, z),
                    Quaternion.identity);
                Instantiate(tile, new Vector3(x, y, z),
                    Quaternion.identity);
            }
        }
    }
}