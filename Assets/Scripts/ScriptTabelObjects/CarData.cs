using UnityEngine;

namespace ErfanDeveloper
{
    public enum CarMode
    {
        Red,
        Blue
    }
    [CreateAssetMenu(menuName = "Car Data")]
    public class CarData : ScriptableObject
    {
        public CarMode carMode;
        public Color color;
    }
}